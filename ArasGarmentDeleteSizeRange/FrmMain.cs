using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Aras.IOM;
using System.Threading;

namespace ArasGarmentDeleteSizeRange
{
    public partial class FrmMain : Form
    {
        private HttpServerConnection mc_conn = null;
        private Innovator mc_innovator = null;
        Thread mc_thread = null;

        private enum OperationType
        {
            GarmentSizeRange,
            GarmentSizeRange_D1,
            GarmentSizeRange_D1_D2
        }

        public FrmMain()
        {
            InitializeComponent();

            SettingConnectionButton(false);
            SettingCheckItemButton(false);

            pro_CheckItem.Minimum = 0;
            pro_CheckItem.Maximum = 100;
        }

        //--------------------------------------------------------------------------------------------

        private void GetConnection(string l_serverurl, string l_db, string l_username, string l_password)
        {
            mc_conn = IomFactory.CreateHttpServerConnection(l_serverurl.Trim(), l_db.Trim(), l_username.Trim(), Innovator.ScalcMD5(l_password.Trim()));
        }

        private void GetInnovator()
        {
            mc_innovator = IomFactory.CreateInnovator(mc_conn);
        }

        private void ShowError(string errormessage)
        {
            MessageBox.Show(errormessage);
        }

        private void SettingProcess(int maxValue, int CurrentValue)
        {
            decimal getvalue = CurrentValue * 100 / maxValue;
            pro_CheckItem.Value = (int)getvalue;
            pro_CheckItem.Refresh();
        }

        private void SettingConnectionButton(bool bln_ConnectionFlag)
        {
            btn_ConnectionAras.Enabled = !bln_ConnectionFlag;
            btn_disconnection.Enabled = bln_ConnectionFlag;


            txt_serverurl.Enabled = !bln_ConnectionFlag;
            txt_DB.Enabled = !bln_ConnectionFlag;
            txt_username.Enabled = !bln_ConnectionFlag;
            txt_password.Enabled = !bln_ConnectionFlag;

            btn_Start.Enabled = bln_ConnectionFlag;

            txt_SearchAML.Enabled = bln_ConnectionFlag;

            if (!bln_ConnectionFlag)
            {
                tre_Item.Nodes.Clear();
                txt_RunAMLLog.Clear();
            }
        }

        private void SettingCheckItemButton(bool bln_CheckItemFlag)
        {
            btn_Start.Enabled = !bln_CheckItemFlag;

            btn_StartDelete.Enabled = bln_CheckItemFlag;
            tre_Item.Enabled = bln_CheckItemFlag;
            txt_RunAMLLog.Enabled = bln_CheckItemFlag;            
        }

        private void ClearCheckInfomation()
        {
            tre_Item.Nodes.Clear();
            txt_RunAMLLog.Clear();
        }

        private bool RunAMLDeleteItem(string pi_AML)
        {
            SettingProcess(100, 30);

            bool l_returnFlag = true;
            if (string.IsNullOrEmpty(pi_AML))
            {
                return false;
            }
            else
            {
                pi_AML = "<AML>" + pi_AML + "</AML>";
            }

            Item l_returnItem = mc_innovator.applyAML(pi_AML);

            SettingProcess(100, 60);

            if (l_returnItem.isError())
            {
                txt_RunAMLLog.ForeColor = Color.Red;
                l_returnFlag = false;
            }
            else
            {
                txt_RunAMLLog.ForeColor = Color.Black;
            }

            SettingProcess(100, 100);

            txt_RunAMLLog.AppendText(pi_AML + "\r\n");
            txt_RunAMLLog.AppendText(pi_AML + "");

            return l_returnFlag;
        }

        private string GetDeleteRelationshipNodeAML(string pi_id, OperationType pi_type)
        {
            string l_returnAML = "";

            SettingProcess(100, 10);

            if (string.IsNullOrEmpty(pi_id))
            {
                return null;
            }

            switch (pi_type)
            {
                case OperationType.GarmentSizeRange:
                    l_returnAML = string.Format(txt_AML_SizeRange.Text.Trim(), pi_id);
                    break;
                case OperationType.GarmentSizeRange_D1:
                    l_returnAML = string.Format(txt_AML_SizeRange_D1.Text.Trim(), pi_id);
                    break;
                case OperationType.GarmentSizeRange_D1_D2:
                    l_returnAML = string.Format(txt_AML_SizeRange_D1_D2.Text.Trim(), pi_id);
                    break;
                default:
                    break;
            }

            SettingProcess(100, 20);

            return l_returnAML;
        }        

        //--------------------------------------------------------------------------------------------

        private void btn_ConnectionAras_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_serverurl.Text.Trim()))
                {
                    throw new Exception("Server Url Is Null Or Empty !");
                }

                if (string.IsNullOrEmpty(txt_DB.Text.Trim()))
                {
                    throw new Exception("DB Name Is Null Or Empty !");
                }

                if (string.IsNullOrEmpty(txt_username.Text.Trim()))
                {
                    throw new Exception("User Name Is Null Or Empty !");
                }

                if (string.IsNullOrEmpty(txt_password.Text.Trim()))
                {
                    throw new Exception("Password Is Null Or Empty !");
                }

                GetConnection(txt_serverurl.Text, txt_DB.Text, txt_username.Text, txt_password.Text);
                GetInnovator();

                Item login_result = mc_conn.Login();
                if (login_result.isError()) throw new Exception("Login failed, please check connection infomation.");

                SettingConnectionButton(true);
            }
            catch (Exception ex)
            {
                ShowError("Connection Aras Error:" + ex.Message);
            }
        }

        private void btn_disconnection_Click(object sender, EventArgs e)
        {
            mc_conn = null;
            mc_innovator = null;
            SettingConnectionButton(false);
            SettingCheckItemButton(false);
        }

        //--------------------------------------------------------------------------------------------

        private void AddGarmentStyleNode(TreeNode Node)
        {
            this.Invoke(new Action<TreeNode>((rootNode) =>
            {
                this.tre_Item.Nodes.Add(rootNode);
                this.tre_Item.Nodes[0].ExpandAll();


            }), Node);
        }
        //--------------------------------------------------------------------------------------------

        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                if (mc_innovator == null)
                {
                    throw new Exception("Please Connection To Aras First.");
                }

                if (string.IsNullOrEmpty(txt_SearchAML.Text.Trim()))
                {
                    throw new Exception("Please Enter Search AML .");
                }


                mc_thread = new Thread(() =>
                {
                    string l_AML = "<AML>" + txt_SearchAML.Text.Trim() + "</AML>";

                    Item l_GetItem = mc_innovator.applyAML(l_AML);

                    if (l_GetItem.isError())
                    {
                        throw new Exception("AML Run Have Error[" + l_GetItem.getErrorCode() + "]" + l_GetItem.getErrorDetail());
                    }

                    if (l_GetItem.getItemCount() == 0)
                    {
                        throw new Exception("AML Return Item Zero Error[" + l_GetItem.getErrorCode() + "]" + l_GetItem.getErrorDetail());
                    }

                    ClearCheckInfomation();

                    if (l_GetItem.getItemCount() > 0)
                    {
                        //node
                        TreeNode l_root = new TreeNode("Garment Style", 0, 0);

                        for (int garmentIDX = 0; garmentIDX < l_GetItem.getItemCount(); garmentIDX++)
                        {
                            Item l_garmentStyle_Item = l_GetItem.getItemByIndex(garmentIDX);

                            Item l_getGarmentSizeRange_Relationships = l_garmentStyle_Item.getRelationships("Garment Size Range");

                            //node
                            TreeNode l_garmentStyle_Item_node = new TreeNode(l_garmentStyle_Item.getProperty("item_number", "-"), 0, 0);
                            l_garmentStyle_Item_node.Tag = l_garmentStyle_Item;
                            l_garmentStyle_Item_node.ToolTipText = "GarmentStyle:" + l_garmentStyle_Item.getProperty("id");

                            #region garment style size
                            for (int garmentSizeRangeIDX = 0; garmentSizeRangeIDX < l_getGarmentSizeRange_Relationships.getItemCount(); garmentSizeRangeIDX++)
                            {
                                Item l_getGarmentSizeRange_Item = l_getGarmentSizeRange_Relationships.getItemByIndex(garmentSizeRangeIDX);

                                Item l_getGarmentSizeRange_D1_Relationships = l_getGarmentSizeRange_Item.getRelationships("Garment Size Range_D1");

                                //node
                                TreeNode l_getGarmentSizeRange_Item_node = new TreeNode(l_getGarmentSizeRange_Item.getProperty("cn_size", "-"), 0, 0);
                                l_getGarmentSizeRange_Item_node.Tag = l_getGarmentSizeRange_Item;
                                l_getGarmentSizeRange_Item_node.ToolTipText = "GarmentStyle SizeRange:" + l_getGarmentSizeRange_Item.getProperty("id");

                                #region size1
                                for (int garmentSizeRange_D1_IDX = 0; garmentSizeRange_D1_IDX < l_getGarmentSizeRange_D1_Relationships.getItemCount(); garmentSizeRange_D1_IDX++)
                                {
                                    Item l_getGarmentSizeRange_D1_Item = l_getGarmentSizeRange_D1_Relationships.getItemByIndex(garmentSizeRange_D1_IDX);

                                    Item l_getGarmentSizeRange_D1_D2_Item_Relationships = l_getGarmentSizeRange_D1_Item.getRelationships("Garment Size Range_D1_D2");
                                    //node
                                    TreeNode l_getGarmentSizeRange_D1_Item_node = new TreeNode(l_getGarmentSizeRange_D1_Item.getProperty("cn_size", "-"), 0, 0);
                                    l_getGarmentSizeRange_D1_Item_node.Tag = l_getGarmentSizeRange_D1_Item;
                                    l_getGarmentSizeRange_D1_Item_node.ToolTipText = "GarmentStyle SizeRange D1:" + l_getGarmentSizeRange_D1_Item.getProperty("id");

                                    #region size2
                                    for (int garmentSizeRange_D1_D2_IDX = 0; garmentSizeRange_D1_D2_IDX < l_getGarmentSizeRange_D1_D2_Item_Relationships.getItemCount(); garmentSizeRange_D1_D2_IDX++)
                                    {

                                        Item l_getGarmentSizeRange_D1_D2_Item = l_getGarmentSizeRange_D1_D2_Item_Relationships.getItemByIndex(garmentSizeRange_D1_D2_IDX);
                                        TreeNode l_getGarmentSizeRange_D1_D2_Item_node = new TreeNode(l_getGarmentSizeRange_D1_D2_Item.getProperty("cn_size2", "-"), 0, 0);
                                        l_getGarmentSizeRange_D1_D2_Item_node.ToolTipText = "GarmentStyle SizeRange D1-D2:" + l_getGarmentSizeRange_D1_D2_Item.getProperty("id");

                                        l_getGarmentSizeRange_D1_Item_node.Nodes.Add(l_getGarmentSizeRange_D1_D2_Item_node);
                                    }
                                    #endregion

                                    l_getGarmentSizeRange_Item_node.Nodes.Add(l_getGarmentSizeRange_D1_Item_node);
                                }
                                #endregion

                                l_garmentStyle_Item_node.Nodes.Add(l_getGarmentSizeRange_Item_node);
                            }
                            #endregion

                            l_root.Nodes.Add(l_garmentStyle_Item_node);
                        }

                        AddGarmentStyleNode(l_root);

                        //tre_Item.Nodes.Add(l_root);
                        //tre_Item.Nodes[0].Expand();
                    }

                    SettingCheckItemButton(true);

                });

            }
            catch (Exception ex)
            {
                ShowError("Check Size Range Error:" + ex.Message);
            }
        }

        private void btn_StartDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (tre_Item.Nodes == null) 
                {
                    throw new Exception("Nothing Can Delete.");
                }

                if (tre_Item.Nodes.Count == 0)
                {
                    throw new Exception("Nothing Can Delete.");
                }

                
                foreach (TreeNode rootNode in tre_Item.Nodes)
                {
                    if ((!chk_GarmentSizeRange.Checked) && (!chk_SizeRange_D1.Checked) && (!chk_SizeRange_D1_D2.Checked)) { break; }
                    rootNode.ImageIndex = 1;
                    rootNode.SelectedImageIndex = 1;
                    tre_Item.Refresh();

                    #region garment
                    foreach (TreeNode garmentNode in rootNode.Nodes)
                    {
                        if (chk_GarmentSizeRange.Checked == false) { break; }

                        garmentNode.ImageIndex = 1;
                        garmentNode.SelectedImageIndex = 1;
                        tre_Item.Refresh();

                        #region sizerange
                        foreach (TreeNode garmentSizeRangeNode in garmentNode.Nodes)
                        {
                            if (chk_SizeRange_D1.Checked == false) { break; }

                            garmentSizeRangeNode.ImageIndex = 1;
                            garmentSizeRangeNode.SelectedImageIndex = 1;
                            tre_Item.Refresh();

                            #region size1
                            foreach (TreeNode sizeRangeD1 in garmentSizeRangeNode.Nodes)
                            {
                                if (chk_SizeRange_D1_D2.Checked == false) { break; }

                                sizeRangeD1.ImageIndex = 1;
                                sizeRangeD1.SelectedImageIndex = 1;
                                tre_Item.Refresh();

                                #region Size 2
                                foreach (TreeNode sizeRangeD1_D2 in sizeRangeD1.Nodes)
                                {
                                    sizeRangeD1_D2.ImageIndex = 1;
                                    sizeRangeD1_D2.SelectedImageIndex = 1;
                                    tre_Item.Refresh();
                                }
                                #endregion

                                Item l_getSizeRange_D1=(Item)sizeRangeD1.Tag;

                                bool l_sizeRangeD1_Flag = RunAMLDeleteItem(GetDeleteRelationshipNodeAML(l_getSizeRange_D1.getProperty("id").ToString(), OperationType.GarmentSizeRange_D1_D2));
                                sizeRangeD1.ImageIndex = l_sizeRangeD1_Flag ? 3 : 2;
                                tre_Item.Refresh();

                                if(l_sizeRangeD1_Flag)
                                {
                                    foreach (TreeNode sizeRangeD1_D2 in sizeRangeD1.Nodes)
                                    {                                        
                                        sizeRangeD1_D2.ImageIndex = 3;
                                        sizeRangeD1_D2.SelectedImageIndex = 3;
                                        tre_Item.Refresh();
                                    }
                                }
                            }
                            #endregion

                            Item l_getGarmentStyleSizeRange=(Item)garmentSizeRangeNode.Tag;

                            bool l_sizeRange_Flag = RunAMLDeleteItem(GetDeleteRelationshipNodeAML(l_getGarmentStyleSizeRange.getProperty("id").ToString(), OperationType.GarmentSizeRange_D1));
                            garmentSizeRangeNode.ImageIndex = l_sizeRange_Flag ? 3 : 2;
                            tre_Item.Refresh();
                        }
                        #endregion

                        Item l_getGarmentStyle = (Item)garmentNode.Tag;
                        string pi_searchAML = string.Format(txt_searchSizeRangeTemplate.Text.Trim(), txt_newSizeRangeName.Text.Trim(), l_getGarmentStyle.getProperty("cn_cust_code"));
                        Item l_sizeRangeTemplate = mc_innovator.applyAML("<AML>" + pi_searchAML + "</AML>");

                        bool l_GarmentsizeRange_Flag = RunAMLDeleteItem(GetDeleteRelationshipNodeAML(l_getGarmentStyle.getProperty("id").ToString(), OperationType.GarmentSizeRange));
                        garmentNode.ImageIndex = l_GarmentsizeRange_Flag ? 3 : 2;
                        tre_Item.Refresh();

                        if (!string.IsNullOrEmpty(txt_newSizeRangeName.Text.Trim()))
                        {
                            StringBuilder l_sizeAML = new StringBuilder();

                            #region size1
                            Item l_getGarmentSizeRange_template_d1 = l_sizeRangeTemplate.getRelationships("Size Range_D1");
                            if (l_getGarmentSizeRange_template_d1.getItemCount() > 0)
                            {
                                l_sizeAML.Append("<Relationships>");

                                for (int Size1IDX = 0; Size1IDX < l_getGarmentSizeRange_template_d1.getItemCount(); Size1IDX++)
                                {
                                    Item l_getGarmentSizeRange_template_d1_Item = l_getGarmentSizeRange_template_d1.getItemByIndex(Size1IDX);

                                    l_sizeAML.Append("<Item type=\"Garment Size Range_D1\" action=\"add\">");
                                    l_sizeAML.Append("<cn_size>" + l_getGarmentSizeRange_template_d1_Item.getProperty("cn_size", "") + "</cn_size>");

                                    #region size2
                                    Item l_getGarmentSizeRange_template_d2 = l_getGarmentSizeRange_template_d1_Item.getRelationships("Size Range_D1_D2");
                                    if (l_getGarmentSizeRange_template_d2.getItemCount()>0)
                                    {
                                        l_sizeAML.Append("<Relationships>");

                                        for (int Size2IDX = 0; Size2IDX < l_getGarmentSizeRange_template_d2.getItemCount(); Size2IDX++)
                                        {
                                            Item l_getGarmentSizeRange_template_d2_Item = l_getGarmentSizeRange_template_d2.getItemByIndex(Size2IDX);

                                            l_sizeAML.Append("<Item type=\"Garment Size Range_D1_D2\" action=\"add\">");
                                            l_sizeAML.Append("<cn_size2>" + l_getGarmentSizeRange_template_d2_Item.getProperty("cn_size2", "") + "</cn_size2>");
                                            l_sizeAML.Append("</Item>");
                                        }

                                        l_sizeAML.Append("</Relationships>");
                                    }
                                    #endregion

                                    l_sizeAML.Append("</Item>");
                                }

                                l_sizeAML.Append("</Relationships>");
                            }
                            #endregion

                            bool l_GarmentsizeRange_Add_Flag = RunAMLDeleteItem(string.Format(txt_addSizeRange.Text.Trim(), 
                                l_getGarmentStyle.getProperty("item_number"), 
                                txt_newSizeRangeName.Text.Trim(), 
                                l_sizeRangeTemplate.getProperty("cn_size_category"), 
                                txt_newSizeRangeName.Text.Trim(), 
                                l_getGarmentStyle.getProperty("cn_cust_code"), 
                                l_sizeAML.ToString()));

                            garmentNode.ImageIndex = l_GarmentsizeRange_Flag ? 3 : 2;
                            garmentNode.Collapse();
                            tre_Item.Refresh();
                        }

                    }
                    #endregion
                }

                tre_Item.Refresh();
                btn_Start.Enabled = true;
                btn_StartDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                ShowError("Delete Size Range Error:" + ex.Message);
            }
        }
    }
}

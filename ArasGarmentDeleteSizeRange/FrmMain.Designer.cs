namespace ArasGarmentDeleteSizeRange
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_password = new System.Windows.Forms.Label();
            this.lab_DB = new System.Windows.Forms.Label();
            this.lab_username = new System.Windows.Forms.Label();
            this.lab_serverurl = new System.Windows.Forms.Label();
            this.btn_disconnection = new System.Windows.Forms.Button();
            this.btn_ConnectionAras = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_DB = new System.Windows.Forms.TextBox();
            this.txt_serverurl = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_searchSizeRangeTemplate = new System.Windows.Forms.TextBox();
            this.txt_newSizeRangeName = new System.Windows.Forms.TextBox();
            this.txt_addSizeRange = new System.Windows.Forms.TextBox();
            this.tre_Item = new System.Windows.Forms.TreeView();
            this.imageLiarbry = new System.Windows.Forms.ImageList(this.components);
            this.txt_RunAMLLog = new System.Windows.Forms.RichTextBox();
            this.btn_StartDelete = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.txt_SearchAML = new System.Windows.Forms.TextBox();
            this.pro_CheckItem = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chk_SizeRange_D1_D2 = new System.Windows.Forms.CheckBox();
            this.chk_SizeRange_D1 = new System.Windows.Forms.CheckBox();
            this.chk_GarmentSizeRange = new System.Windows.Forms.CheckBox();
            this.txt_AML_SizeRange_D1_D2 = new System.Windows.Forms.TextBox();
            this.txt_AML_SizeRange_D1 = new System.Windows.Forms.TextBox();
            this.txt_AML_SizeRange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lab_password);
            this.panel1.Controls.Add(this.lab_DB);
            this.panel1.Controls.Add(this.lab_username);
            this.panel1.Controls.Add(this.lab_serverurl);
            this.panel1.Controls.Add(this.btn_disconnection);
            this.panel1.Controls.Add(this.btn_ConnectionAras);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_DB);
            this.panel1.Controls.Add(this.txt_serverurl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 74);
            this.panel1.TabIndex = 1;
            // 
            // lab_password
            // 
            this.lab_password.AutoSize = true;
            this.lab_password.Location = new System.Drawing.Point(364, 44);
            this.lab_password.Name = "lab_password";
            this.lab_password.Size = new System.Drawing.Size(53, 12);
            this.lab_password.TabIndex = 2;
            this.lab_password.Text = "PassWord";
            // 
            // lab_DB
            // 
            this.lab_DB.AutoSize = true;
            this.lab_DB.Location = new System.Drawing.Point(364, 17);
            this.lab_DB.Name = "lab_DB";
            this.lab_DB.Size = new System.Drawing.Size(41, 12);
            this.lab_DB.TabIndex = 2;
            this.lab_DB.Text = "DBName";
            // 
            // lab_username
            // 
            this.lab_username.AutoSize = true;
            this.lab_username.Location = new System.Drawing.Point(17, 44);
            this.lab_username.Name = "lab_username";
            this.lab_username.Size = new System.Drawing.Size(53, 12);
            this.lab_username.TabIndex = 2;
            this.lab_username.Text = "UserName";
            // 
            // lab_serverurl
            // 
            this.lab_serverurl.AutoSize = true;
            this.lab_serverurl.Location = new System.Drawing.Point(17, 17);
            this.lab_serverurl.Name = "lab_serverurl";
            this.lab_serverurl.Size = new System.Drawing.Size(59, 12);
            this.lab_serverurl.TabIndex = 2;
            this.lab_serverurl.Text = "ServerUrl";
            // 
            // btn_disconnection
            // 
            this.btn_disconnection.Location = new System.Drawing.Point(715, 39);
            this.btn_disconnection.Name = "btn_disconnection";
            this.btn_disconnection.Size = new System.Drawing.Size(87, 23);
            this.btn_disconnection.TabIndex = 1;
            this.btn_disconnection.Text = "Disconnection";
            this.btn_disconnection.UseVisualStyleBackColor = true;
            this.btn_disconnection.Click += new System.EventHandler(this.btn_disconnection_Click);
            // 
            // btn_ConnectionAras
            // 
            this.btn_ConnectionAras.Location = new System.Drawing.Point(715, 12);
            this.btn_ConnectionAras.Name = "btn_ConnectionAras";
            this.btn_ConnectionAras.Size = new System.Drawing.Size(87, 23);
            this.btn_ConnectionAras.TabIndex = 1;
            this.btn_ConnectionAras.Text = "Connection";
            this.btn_ConnectionAras.UseVisualStyleBackColor = true;
            this.btn_ConnectionAras.Click += new System.EventHandler(this.btn_ConnectionAras_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(82, 41);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(254, 21);
            this.txt_username.TabIndex = 0;
            this.txt_username.Text = "admin";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(423, 41);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(254, 21);
            this.txt_password.TabIndex = 0;
            this.txt_password.Text = "innovator";
            // 
            // txt_DB
            // 
            this.txt_DB.Location = new System.Drawing.Point(423, 14);
            this.txt_DB.Name = "txt_DB";
            this.txt_DB.Size = new System.Drawing.Size(254, 21);
            this.txt_DB.TabIndex = 0;
            this.txt_DB.Text = "Esquel_PLM_SIT";
            // 
            // txt_serverurl
            // 
            this.txt_serverurl.Location = new System.Drawing.Point(82, 14);
            this.txt_serverurl.Name = "txt_serverurl";
            this.txt_serverurl.Size = new System.Drawing.Size(254, 21);
            this.txt_serverurl.TabIndex = 0;
            this.txt_serverurl.Text = "http://10.20.2.30/InnovatorServer/";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_searchSizeRangeTemplate);
            this.panel2.Controls.Add(this.txt_newSizeRangeName);
            this.panel2.Controls.Add(this.txt_addSizeRange);
            this.panel2.Controls.Add(this.tre_Item);
            this.panel2.Controls.Add(this.txt_RunAMLLog);
            this.panel2.Controls.Add(this.btn_StartDelete);
            this.panel2.Controls.Add(this.btn_Start);
            this.panel2.Controls.Add(this.txt_SearchAML);
            this.panel2.Location = new System.Drawing.Point(12, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 513);
            this.panel2.TabIndex = 2;
            // 
            // txt_searchSizeRangeTemplate
            // 
            this.txt_searchSizeRangeTemplate.Location = new System.Drawing.Point(4, 90);
            this.txt_searchSizeRangeTemplate.Multiline = true;
            this.txt_searchSizeRangeTemplate.Name = "txt_searchSizeRangeTemplate";
            this.txt_searchSizeRangeTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_searchSizeRangeTemplate.Size = new System.Drawing.Size(274, 58);
            this.txt_searchSizeRangeTemplate.TabIndex = 9;
            this.txt_searchSizeRangeTemplate.Text = resources.GetString("txt_searchSizeRangeTemplate.Text");
            // 
            // txt_newSizeRangeName
            // 
            this.txt_newSizeRangeName.Location = new System.Drawing.Point(569, 18);
            this.txt_newSizeRangeName.Name = "txt_newSizeRangeName";
            this.txt_newSizeRangeName.Size = new System.Drawing.Size(248, 21);
            this.txt_newSizeRangeName.TabIndex = 8;
            this.txt_newSizeRangeName.Text = "MDS Long Sleeve Size (INCH)";
            // 
            // txt_addSizeRange
            // 
            this.txt_addSizeRange.Location = new System.Drawing.Point(284, 18);
            this.txt_addSizeRange.Multiline = true;
            this.txt_addSizeRange.Name = "txt_addSizeRange";
            this.txt_addSizeRange.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_addSizeRange.Size = new System.Drawing.Size(279, 51);
            this.txt_addSizeRange.TabIndex = 7;
            this.txt_addSizeRange.Text = resources.GetString("txt_addSizeRange.Text");
            // 
            // tre_Item
            // 
            this.tre_Item.ImageIndex = 0;
            this.tre_Item.ImageList = this.imageLiarbry;
            this.tre_Item.Location = new System.Drawing.Point(3, 154);
            this.tre_Item.Name = "tre_Item";
            this.tre_Item.SelectedImageIndex = 0;
            this.tre_Item.Size = new System.Drawing.Size(402, 350);
            this.tre_Item.TabIndex = 6;
            // 
            // imageLiarbry
            // 
            this.imageLiarbry.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageLiarbry.ImageStream")));
            this.imageLiarbry.TransparentColor = System.Drawing.Color.Transparent;
            this.imageLiarbry.Images.SetKeyName(0, "wait.png");
            this.imageLiarbry.Images.SetKeyName(1, "start.png");
            this.imageLiarbry.Images.SetKeyName(2, "stop.png");
            this.imageLiarbry.Images.SetKeyName(3, "complete.png");
            // 
            // txt_RunAMLLog
            // 
            this.txt_RunAMLLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RunAMLLog.Location = new System.Drawing.Point(411, 154);
            this.txt_RunAMLLog.Name = "txt_RunAMLLog";
            this.txt_RunAMLLog.Size = new System.Drawing.Size(406, 350);
            this.txt_RunAMLLog.TabIndex = 4;
            this.txt_RunAMLLog.Text = "";
            // 
            // btn_StartDelete
            // 
            this.btn_StartDelete.Location = new System.Drawing.Point(696, 50);
            this.btn_StartDelete.Name = "btn_StartDelete";
            this.btn_StartDelete.Size = new System.Drawing.Size(121, 19);
            this.btn_StartDelete.TabIndex = 3;
            this.btn_StartDelete.Text = "Start Delete";
            this.btn_StartDelete.UseVisualStyleBackColor = true;
            this.btn_StartDelete.Click += new System.EventHandler(this.btn_StartDelete_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(569, 50);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(121, 19);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "Start Check";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // txt_SearchAML
            // 
            this.txt_SearchAML.Location = new System.Drawing.Point(3, 18);
            this.txt_SearchAML.Multiline = true;
            this.txt_SearchAML.Name = "txt_SearchAML";
            this.txt_SearchAML.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_SearchAML.Size = new System.Drawing.Size(275, 51);
            this.txt_SearchAML.TabIndex = 2;
            this.txt_SearchAML.Text = resources.GetString("txt_SearchAML.Text");
            // 
            // pro_CheckItem
            // 
            this.pro_CheckItem.Location = new System.Drawing.Point(12, 174);
            this.pro_CheckItem.Name = "pro_CheckItem";
            this.pro_CheckItem.Size = new System.Drawing.Size(823, 16);
            this.pro_CheckItem.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.chk_SizeRange_D1_D2);
            this.panel3.Controls.Add(this.chk_SizeRange_D1);
            this.panel3.Controls.Add(this.chk_GarmentSizeRange);
            this.panel3.Controls.Add(this.txt_AML_SizeRange_D1_D2);
            this.panel3.Controls.Add(this.txt_AML_SizeRange_D1);
            this.panel3.Controls.Add(this.txt_AML_SizeRange);
            this.panel3.Location = new System.Drawing.Point(12, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(824, 79);
            this.panel3.TabIndex = 4;
            // 
            // chk_SizeRange_D1_D2
            // 
            this.chk_SizeRange_D1_D2.AutoSize = true;
            this.chk_SizeRange_D1_D2.Location = new System.Drawing.Point(4, 56);
            this.chk_SizeRange_D1_D2.Name = "chk_SizeRange_D1_D2";
            this.chk_SizeRange_D1_D2.Size = new System.Drawing.Size(126, 16);
            this.chk_SizeRange_D1_D2.TabIndex = 9;
            this.chk_SizeRange_D1_D2.Text = "G_SizeRange_D1_D2";
            this.chk_SizeRange_D1_D2.UseVisualStyleBackColor = true;
            // 
            // chk_SizeRange_D1
            // 
            this.chk_SizeRange_D1.AutoSize = true;
            this.chk_SizeRange_D1.Location = new System.Drawing.Point(4, 30);
            this.chk_SizeRange_D1.Name = "chk_SizeRange_D1";
            this.chk_SizeRange_D1.Size = new System.Drawing.Size(108, 16);
            this.chk_SizeRange_D1.TabIndex = 9;
            this.chk_SizeRange_D1.Text = "G_SizeRange_D1";
            this.chk_SizeRange_D1.UseVisualStyleBackColor = true;
            // 
            // chk_GarmentSizeRange
            // 
            this.chk_GarmentSizeRange.AutoSize = true;
            this.chk_GarmentSizeRange.Location = new System.Drawing.Point(4, 5);
            this.chk_GarmentSizeRange.Name = "chk_GarmentSizeRange";
            this.chk_GarmentSizeRange.Size = new System.Drawing.Size(120, 16);
            this.chk_GarmentSizeRange.TabIndex = 9;
            this.chk_GarmentSizeRange.Text = "GarmentSizeRange";
            this.chk_GarmentSizeRange.UseVisualStyleBackColor = true;
            // 
            // txt_AML_SizeRange_D1_D2
            // 
            this.txt_AML_SizeRange_D1_D2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_AML_SizeRange_D1_D2.Location = new System.Drawing.Point(130, 54);
            this.txt_AML_SizeRange_D1_D2.Multiline = true;
            this.txt_AML_SizeRange_D1_D2.Name = "txt_AML_SizeRange_D1_D2";
            this.txt_AML_SizeRange_D1_D2.Size = new System.Drawing.Size(687, 21);
            this.txt_AML_SizeRange_D1_D2.TabIndex = 6;
            this.txt_AML_SizeRange_D1_D2.Text = "<Item type=\"Garment Size Range_D1_D2\" where=\"source_id=\'{0}\'\" action=\"delete\"><so" +
    "urce_id>{0}</source_id></Item>";
            // 
            // txt_AML_SizeRange_D1
            // 
            this.txt_AML_SizeRange_D1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_AML_SizeRange_D1.Location = new System.Drawing.Point(130, 28);
            this.txt_AML_SizeRange_D1.Multiline = true;
            this.txt_AML_SizeRange_D1.Name = "txt_AML_SizeRange_D1";
            this.txt_AML_SizeRange_D1.Size = new System.Drawing.Size(687, 21);
            this.txt_AML_SizeRange_D1.TabIndex = 7;
            this.txt_AML_SizeRange_D1.Text = "<Item type=\"Garment Size Range_D1\" where=\"source_id=\'{0}\'\" action=\"delete\"><sourc" +
    "e_id>{0}</source_id></Item>";
            // 
            // txt_AML_SizeRange
            // 
            this.txt_AML_SizeRange.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_AML_SizeRange.Location = new System.Drawing.Point(130, 3);
            this.txt_AML_SizeRange.Multiline = true;
            this.txt_AML_SizeRange.Name = "txt_AML_SizeRange";
            this.txt_AML_SizeRange.Size = new System.Drawing.Size(687, 21);
            this.txt_AML_SizeRange.TabIndex = 8;
            this.txt_AML_SizeRange.Text = "<Item type=\"Garment Size Range\" where=\"source_id=\'{0}\'\" action=\"delete\"><source_i" +
    "d>{0}</source_id></Item>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "search style AML";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "get size range AML";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "update size range AML";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "new size range name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "if newSizeRangeName is not empty , will add new sizeRange";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 719);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pro_CheckItem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Aras Garment Style Delete Size Range(for Esquel)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_password;
        private System.Windows.Forms.Label lab_DB;
        private System.Windows.Forms.Label lab_username;
        private System.Windows.Forms.Label lab_serverurl;
        private System.Windows.Forms.Button btn_disconnection;
        private System.Windows.Forms.Button btn_ConnectionAras;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_DB;
        private System.Windows.Forms.TextBox txt_serverurl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_SearchAML;
        private System.Windows.Forms.ProgressBar pro_CheckItem;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.RichTextBox txt_RunAMLLog;
        private System.Windows.Forms.TreeView tre_Item;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_AML_SizeRange_D1_D2;
        private System.Windows.Forms.TextBox txt_AML_SizeRange_D1;
        private System.Windows.Forms.TextBox txt_AML_SizeRange;
        private System.Windows.Forms.Button btn_StartDelete;
        private System.Windows.Forms.ImageList imageLiarbry;
        private System.Windows.Forms.CheckBox chk_SizeRange_D1_D2;
        private System.Windows.Forms.CheckBox chk_SizeRange_D1;
        private System.Windows.Forms.CheckBox chk_GarmentSizeRange;
        private System.Windows.Forms.TextBox txt_addSizeRange;
        private System.Windows.Forms.TextBox txt_newSizeRangeName;
        private System.Windows.Forms.TextBox txt_searchSizeRangeTemplate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


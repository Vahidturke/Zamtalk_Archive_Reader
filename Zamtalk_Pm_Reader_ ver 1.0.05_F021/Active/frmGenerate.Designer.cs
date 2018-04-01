namespace Zamtalk_Pm_Reader__ver_1._0._05_F021
{
    partial class FrmGenerate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerate));
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLicenseType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExperiences = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            resources.ApplyResources(this.BtnGenerate, "BtnGenerate");
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtProductID
            // 
            resources.ApplyResources(this.txtProductID, "txtProductID");
            this.txtProductID.Name = "txtProductID";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cboLicenseType
            // 
            this.cboLicenseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLicenseType.FormattingEnabled = true;
            this.cboLicenseType.Items.AddRange(new object[] {
            resources.GetString("cboLicenseType.Items"),
            resources.GetString("cboLicenseType.Items1")});
            resources.ApplyResources(this.cboLicenseType, "cboLicenseType");
            this.cboLicenseType.Name = "cboLicenseType";
            this.cboLicenseType.SelectedIndexChanged += new System.EventHandler(this.cboLicenseType_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtExperiences
            // 
            resources.ApplyResources(this.txtExperiences, "txtExperiences");
            this.txtExperiences.Name = "txtExperiences";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtProductKey
            // 
            resources.ApplyResources(this.txtProductKey, "txtProductKey");
            this.txtProductKey.Name = "txtProductKey";
            this.txtProductKey.ReadOnly = true;
            // 
            // FrmGenerate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtExperiences);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboLicenseType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductKey);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmGenerate";
            this.Load += new System.EventHandler(this.FrmGenerate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLicenseType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExperiences;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductKey;
    }
}
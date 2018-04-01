namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    partial class FRM_ZamtalkPasswordFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ZamtalkPasswordFinder));
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_SavePw = new System.Windows.Forms.Button();
            this.BTN_FindPw = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.TXT_PW = new System.Windows.Forms.TextBox();
            this.LBL_ID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_ExitPwFrm = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Name = "panel1";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.BTN_ExitPwFrm);
            this.panel3.Name = "panel3";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.BTN_SavePw);
            this.groupBox1.Controls.Add(this.BTN_FindPw);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // BTN_SavePw
            // 
            resources.ApplyResources(this.BTN_SavePw, "BTN_SavePw");
            this.BTN_SavePw.Name = "BTN_SavePw";
            this.BTN_SavePw.UseVisualStyleBackColor = true;
            this.BTN_SavePw.Click += new System.EventHandler(this.BTN_SavePw_Click);
            // 
            // BTN_FindPw
            // 
            resources.ApplyResources(this.BTN_FindPw, "BTN_FindPw");
            this.BTN_FindPw.Name = "BTN_FindPw";
            this.BTN_FindPw.UseVisualStyleBackColor = true;
            this.BTN_FindPw.Click += new System.EventHandler(this.BTN_FindPw_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.maskedTextBox1);
            this.panel2.Controls.Add(this.TXT_PW);
            this.panel2.Controls.Add(this.LBL_ID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Name = "panel2";
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // maskedTextBox1
            // 
            resources.ApplyResources(this.maskedTextBox1, "maskedTextBox1");
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.UseSystemPasswordChar = true;
            // 
            // TXT_PW
            // 
            resources.ApplyResources(this.TXT_PW, "TXT_PW");
            this.TXT_PW.Name = "TXT_PW";
            this.TXT_PW.ReadOnly = true;
            // 
            // LBL_ID
            // 
            resources.ApplyResources(this.LBL_ID, "LBL_ID");
            this.LBL_ID.Name = "LBL_ID";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // BTN_ExitPwFrm
            // 
            resources.ApplyResources(this.BTN_ExitPwFrm, "BTN_ExitPwFrm");
            this.BTN_ExitPwFrm.Name = "BTN_ExitPwFrm";
            this.BTN_ExitPwFrm.UseVisualStyleBackColor = true;
            this.BTN_ExitPwFrm.Click += new System.EventHandler(this.BTN_ExitPwFrm_Click);
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // FRM_ZamtalkPasswordFinder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FRM_ZamtalkPasswordFinder";
            this.Load += new System.EventHandler(this.FRM_ZamtalkPasswordFinder_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_SavePw;
        private System.Windows.Forms.Button BTN_FindPw;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox TXT_PW;
        private System.Windows.Forms.Label LBL_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_ExitPwFrm;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
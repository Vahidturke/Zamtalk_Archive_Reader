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
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(352, 202);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 202);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.BTN_ExitPwFrm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(352, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 202);
            this.panel3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_SavePw);
            this.groupBox1.Controls.Add(this.BTN_FindPw);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zamtalk Password Finder";
            // 
            // BTN_SavePw
            // 
            this.BTN_SavePw.Location = new System.Drawing.Point(23, 19);
            this.BTN_SavePw.Name = "BTN_SavePw";
            this.BTN_SavePw.Size = new System.Drawing.Size(100, 23);
            this.BTN_SavePw.TabIndex = 2;
            this.BTN_SavePw.Text = "Save To File";
            this.BTN_SavePw.UseVisualStyleBackColor = true;
            this.BTN_SavePw.Click += new System.EventHandler(this.BTN_SavePw_Click);
            // 
            // BTN_FindPw
            // 
            this.BTN_FindPw.Location = new System.Drawing.Point(161, 19);
            this.BTN_FindPw.Name = "BTN_FindPw";
            this.BTN_FindPw.Size = new System.Drawing.Size(87, 23);
            this.BTN_FindPw.TabIndex = 1;
            this.BTN_FindPw.Text = "Find Password";
            this.BTN_FindPw.UseVisualStyleBackColor = true;
            this.BTN_FindPw.Click += new System.EventHandler(this.BTN_FindPw_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.maskedTextBox1);
            this.panel2.Controls.Add(this.TXT_PW);
            this.panel2.Controls.Add(this.LBL_ID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(6, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 86);
            this.panel2.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(3, 52);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(174, 20);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.UseSystemPasswordChar = true;
            // 
            // TXT_PW
            // 
            this.TXT_PW.Location = new System.Drawing.Point(3, 52);
            this.TXT_PW.Multiline = true;
            this.TXT_PW.Name = "TXT_PW";
            this.TXT_PW.ReadOnly = true;
            this.TXT_PW.Size = new System.Drawing.Size(174, 20);
            this.TXT_PW.TabIndex = 7;
            this.TXT_PW.Visible = false;
            // 
            // LBL_ID
            // 
            this.LBL_ID.AutoSize = true;
            this.LBL_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LBL_ID.Location = new System.Drawing.Point(20, 25);
            this.LBL_ID.Name = "LBL_ID";
            this.LBL_ID.Size = new System.Drawing.Size(20, 13);
            this.LBL_ID.TabIndex = 3;
            this.LBL_ID.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "UserName";
            // 
            // BTN_ExitPwFrm
            // 
            this.BTN_ExitPwFrm.Location = new System.Drawing.Point(137, 171);
            this.BTN_ExitPwFrm.Name = "BTN_ExitPwFrm";
            this.BTN_ExitPwFrm.Size = new System.Drawing.Size(123, 23);
            this.BTN_ExitPwFrm.TabIndex = 0;
            this.BTN_ExitPwFrm.Text = "Back";
            this.BTN_ExitPwFrm.UseVisualStyleBackColor = true;
            this.BTN_ExitPwFrm.Click += new System.EventHandler(this.BTN_ExitPwFrm_Click);
            // 
            // FRM_ZamtalkPasswordFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 202);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FRM_ZamtalkPasswordFinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ZamtalkPasswordFinder";
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
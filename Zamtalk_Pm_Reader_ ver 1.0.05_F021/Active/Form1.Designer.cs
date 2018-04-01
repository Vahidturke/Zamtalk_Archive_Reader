namespace Zamtalk_Pm_Reader__ver_1._0._05_F021
{
    partial class Form1
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.BtnRegistration = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 20);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // BtnRegistration
            // 
            this.BtnRegistration.Location = new System.Drawing.Point(119, 20);
            this.BtnRegistration.Name = "BtnRegistration";
            this.BtnRegistration.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistration.TabIndex = 1;
            this.BtnRegistration.Text = "Registration";
            this.BtnRegistration.UseVisualStyleBackColor = true;
            this.BtnRegistration.Click += new System.EventHandler(this.BtnRegistration_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.Location = new System.Drawing.Point(226, 20);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(75, 23);
            this.BtnAbout.TabIndex = 2;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 54);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.BtnRegistration);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(350, 93);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keygan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button BtnRegistration;
        private System.Windows.Forms.Button BtnAbout;
    }
}
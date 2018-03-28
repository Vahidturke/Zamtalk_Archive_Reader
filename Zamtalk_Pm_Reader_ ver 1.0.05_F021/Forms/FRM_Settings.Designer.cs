namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    partial class FRM_Settings
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Back = new System.Windows.Forms.Button();
            this.BTN_ClearTemp = new System.Windows.Forms.Button();
            this.BTN_Load = new System.Windows.Forms.Button();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_Remove = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 217);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Paths";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(412, 198);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_Back);
            this.groupBox1.Controls.Add(this.BTN_ClearTemp);
            this.groupBox1.Controls.Add(this.BTN_Load);
            this.groupBox1.Controls.Add(this.BTN_Clear);
            this.groupBox1.Controls.Add(this.BTN_Save);
            this.groupBox1.Controls.Add(this.BTN_Remove);
            this.groupBox1.Controls.Add(this.BTN_Add);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(418, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 229);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controler";
            // 
            // BTN_Back
            // 
            this.BTN_Back.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_Back.Location = new System.Drawing.Point(6, 187);
            this.BTN_Back.Name = "BTN_Back";
            this.BTN_Back.Size = new System.Drawing.Size(75, 23);
            this.BTN_Back.TabIndex = 6;
            this.BTN_Back.Text = "Back";
            this.BTN_Back.UseVisualStyleBackColor = true;
            this.BTN_Back.Click += new System.EventHandler(this.BTN_Back_Click);
            // 
            // BTN_ClearTemp
            // 
            this.BTN_ClearTemp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_ClearTemp.Location = new System.Drawing.Point(6, 161);
            this.BTN_ClearTemp.Name = "BTN_ClearTemp";
            this.BTN_ClearTemp.Size = new System.Drawing.Size(75, 23);
            this.BTN_ClearTemp.TabIndex = 5;
            this.BTN_ClearTemp.Text = "DeleteTemp";
            this.BTN_ClearTemp.UseVisualStyleBackColor = true;
            this.BTN_ClearTemp.Click += new System.EventHandler(this.BTN_ClearTemp_Click);
            // 
            // BTN_Load
            // 
            this.BTN_Load.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_Load.Location = new System.Drawing.Point(6, 132);
            this.BTN_Load.Name = "BTN_Load";
            this.BTN_Load.Size = new System.Drawing.Size(75, 23);
            this.BTN_Load.TabIndex = 4;
            this.BTN_Load.Text = "Recover";
            this.BTN_Load.UseVisualStyleBackColor = true;
            this.BTN_Load.Click += new System.EventHandler(this.BTN_Load_Click);
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_Clear.Location = new System.Drawing.Point(6, 74);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(75, 23);
            this.BTN_Clear.TabIndex = 3;
            this.BTN_Clear.Text = "Delete All ";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // BTN_Save
            // 
            this.BTN_Save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_Save.Location = new System.Drawing.Point(6, 103);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(75, 23);
            this.BTN_Save.TabIndex = 2;
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // BTN_Remove
            // 
            this.BTN_Remove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_Remove.Location = new System.Drawing.Point(6, 48);
            this.BTN_Remove.Name = "BTN_Remove";
            this.BTN_Remove.Size = new System.Drawing.Size(75, 23);
            this.BTN_Remove.TabIndex = 1;
            this.BTN_Remove.Text = "Delete";
            this.BTN_Remove.UseVisualStyleBackColor = true;
            this.BTN_Remove.Click += new System.EventHandler(this.BTN_Remove_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_Add.Location = new System.Drawing.Point(6, 19);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(75, 23);
            this.BTN_Add.TabIndex = 0;
            this.BTN_Add.Text = "Add";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // FRM_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 229);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Settings";
            this.Load += new System.EventHandler(this.FRM_Settings_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_Back;
        private System.Windows.Forms.Button BTN_ClearTemp;
        public System.Windows.Forms.Button BTN_Load;
        public System.Windows.Forms.Button BTN_Clear;
        public System.Windows.Forms.Button BTN_Save;
        public System.Windows.Forms.Button BTN_Remove;
        public System.Windows.Forms.Button BTN_Add;
    }
}
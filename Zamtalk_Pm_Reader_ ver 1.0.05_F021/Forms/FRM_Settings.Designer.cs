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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Settings));
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
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
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
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // BTN_Back
            // 
            resources.ApplyResources(this.BTN_Back, "BTN_Back");
            this.BTN_Back.Name = "BTN_Back";
            this.BTN_Back.UseVisualStyleBackColor = true;
            this.BTN_Back.Click += new System.EventHandler(this.BTN_Back_Click);
            // 
            // BTN_ClearTemp
            // 
            resources.ApplyResources(this.BTN_ClearTemp, "BTN_ClearTemp");
            this.BTN_ClearTemp.Name = "BTN_ClearTemp";
            this.BTN_ClearTemp.UseVisualStyleBackColor = true;
            this.BTN_ClearTemp.Click += new System.EventHandler(this.BTN_ClearTemp_Click);
            // 
            // BTN_Load
            // 
            resources.ApplyResources(this.BTN_Load, "BTN_Load");
            this.BTN_Load.Name = "BTN_Load";
            this.BTN_Load.UseVisualStyleBackColor = true;
            this.BTN_Load.Click += new System.EventHandler(this.BTN_Load_Click);
            // 
            // BTN_Clear
            // 
            resources.ApplyResources(this.BTN_Clear, "BTN_Clear");
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // BTN_Save
            // 
            resources.ApplyResources(this.BTN_Save, "BTN_Save");
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // BTN_Remove
            // 
            resources.ApplyResources(this.BTN_Remove, "BTN_Remove");
            this.BTN_Remove.Name = "BTN_Remove";
            this.BTN_Remove.UseVisualStyleBackColor = true;
            this.BTN_Remove.Click += new System.EventHandler(this.BTN_Remove_Click);
            // 
            // BTN_Add
            // 
            resources.ApplyResources(this.BTN_Add, "BTN_Add");
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // FRM_Settings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Settings";
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
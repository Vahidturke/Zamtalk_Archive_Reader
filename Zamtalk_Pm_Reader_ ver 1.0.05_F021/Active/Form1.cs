using System;
using System.Windows.Forms;
using FoxLearn;
using Zamtalk_Pm_Reader__ver_1._0._05_F021.Active;

namespace Zamtalk_Pm_Reader__ver_1._0._05_F021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnGenerate_Click(object sender, EventArgs e)
        {
            using (FrmGenerate frm = new FrmGenerate())
            { frm.ShowDialog(); }
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            using (frmRegistration frm = new frmRegistration())
            { frm.ShowDialog(); }

        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            using (frmAboutLice frm = new frmAboutLice())
            { frm.ShowDialog(); }
        }
    }
}

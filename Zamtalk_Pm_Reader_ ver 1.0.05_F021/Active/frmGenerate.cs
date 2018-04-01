using FoxLearn.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zamtalk_Pm_Reader__ver_1._0._05_F021
{
    public partial class FrmGenerate : Form
    {
        public FrmGenerate()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            KeyManager km = new KeyManager(txtProductID.Text);
            KeyValuesClass kv;
            string ProductKey = string.Empty;
            if (cboLicenseType.SelectedIndex == 0)
            {
                kv = new KeyValuesClass()
                {
                    Type = LicenseType.FULL,
                    Header = Convert.ToByte(9),
                    Footer = Convert.ToByte(6),
                    ProductCode = (byte)ProductCode,
                    Edition = Edition.ENTERPRISE,
                    Version = 1,

                };
                if (!km.GenerateKey(kv, ref ProductKey))
                    txtProductKey.Text = "Error";
            }
            else
            {
                kv = new KeyValuesClass()
                {
                    Type = LicenseType.TRIAL,
                    Header = Convert.ToByte(9),
                    Footer = Convert.ToByte(6),
                    ProductCode = (byte)ProductCode,
                    Edition = Edition.ENTERPRISE,
                    Version = 1,
                    Expiration = DateTime.Now.Date.AddDays(Convert.ToInt32(txtExperiences.Text))

                };
                if (!km.GenerateKey(kv, ref ProductKey))
                    txtProductKey.Text = "Error";
            }
            txtProductKey.Text = ProductKey;
        }
        const int ProductCode = 1;

        private void FrmGenerate_Load(object sender, EventArgs e)
        {
            cboLicenseType.SelectedIndex = 0;
            txtProductID.Text = ComputerInfo.GetComputerId();

        }

        private void cboLicenseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLicenseType.SelectedIndex == 1)
            {
                txtExperiences.Visible = true;
                label3.Visible = true;
                //if (txtExperiences.Text == string.Empty)
                //{
                //    MessageBox.Show("Please Insert Day Experiences.");
                //}
            }
            else
            {

                txtExperiences.Visible = false;
                label3.Visible = false;
            }
       
        }
    }
}

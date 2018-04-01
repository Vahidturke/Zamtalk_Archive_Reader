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

namespace Zamtalk_Pm_Reader__ver_1._0._05_F021.Active
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            KeyManager km = new KeyManager(txtProductID.Text);
            string productKey = txtProductKey.Text;
            if (km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (km.DisassembleKey(productKey, ref kv))
                {
                    LicenseInfo lic = new LicenseInfo();
                    lic.ProductKey = productKey;
                    lic.FullName = "VahidTurke";
                    if (kv.Type == LicenseType.TRIAL)
                    {
                        lic.Day = kv.Expiration.Day;
                        lic.Month = kv.Expiration.Month;
                        lic.Year = kv.Expiration.Year;
                    }
                    km.SaveSuretyFile(string.Format(@"{0}\key.lic", Application.StartupPath), lic);
                    MessageBox.Show("You have been Successfully registered. ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Your Product Key is Invalid.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        const int ProductCode = 1;

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            txtProductID.Text = ComputerInfo.GetComputerId();

        }
    }
}

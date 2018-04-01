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
    public partial class frmAboutLice : Form
    {
        public frmAboutLice()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        const int ProductCode = 1;

        private void frmAboutLice_Load(object sender, EventArgs e)
        {
            lblProductID.Text = ComputerInfo.GetComputerId();
            KeyManager km = new KeyManager(lblProductID.Text);
            LicenseInfo lic = new LicenseInfo();
            int value = km.LoadSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), ref lic);
            string ProductKey = lic.ProductKey;


            if (km.ValidKey(ref ProductKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (km.DisassembleKey(ProductKey, ref kv))
                {
                    lblProductName.Text = "VahidTurke";
                    lblProductKey.Text = ProductKey;
                    if (kv.Type == LicenseType.TRIAL)
                    {
                        lblLicenseType.Text = string.Format("{0} days", (kv.Expiration - DateTime.Now.Date).Days);
                    }
                    else
                    {
                        lblLicenseType.Text = "Full";
                    }
                }
            }

        }
    }
}



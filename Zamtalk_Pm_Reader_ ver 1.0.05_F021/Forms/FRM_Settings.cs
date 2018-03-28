using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    public partial class FRM_Settings : Form
    {
        public FRM_Settings()
        {
            InitializeComponent();
        }

        private SaveAndLoad oSaveAndLoad = new SaveAndLoad();
        private TempMakers oTempMakers = new TempMakers();

        private PmExplorer opmexplorer = new PmExplorer();
        public static string filename = "copyarchive.txt";
        public static string foldername = "copyarchive";

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            opmexplorer.AddItem(listBox1);
        }

        private void BTN_Load_Click(object sender, EventArgs e)
        {
            oSaveAndLoad.LoadData(listBox1, oTempMakers.AppDataFile(filename));

        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            opmexplorer.ListboxClearAll(listBox1);

        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            oSaveAndLoad.SaveData(listBox1, oTempMakers.AppDataFile(filename));

        }

        private void BTN_Remove_Click(object sender, EventArgs e)
        {
            opmexplorer.DeletedSelectedItems(listBox1);

        }
        private void BTN_ClearTemp_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(oTempMakers.AppdataFolder(foldername)))
            {
                Directory.Delete(oTempMakers.AppdataFolder(foldername), true);
                MessageBox.Show("Cleared Archive!");
            }
        }

        private void BTN_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Settings_Load(object sender, EventArgs e)
        {
            oSaveAndLoad.LoadData_BedoneMsg(listBox1, oTempMakers.AppDataFile(filename));

        }
    }

}


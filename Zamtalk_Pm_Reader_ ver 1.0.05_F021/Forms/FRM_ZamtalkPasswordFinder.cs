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
    public partial class FRM_ZamtalkPasswordFinder : Form
    {
        public FRM_ZamtalkPasswordFinder()
        {
            InitializeComponent();
        }

        Password p = new Password();
        private void BTN_FindPw_Click(object sender, EventArgs e)
        {
            p.ShowAllIDZamtalk(listView1);
        }

        private void Addvalue(string name, string pw)
        {
            string[] row = new string[] { "name", "pw" };

            ListViewItem item = new ListViewItem(row);

            listView1.Items.Add(item);

        }



        private void BTN_SavePw_Click(object sender, EventArgs e)
        {




            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //saveFileDialog1.ShowDialog();
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)

            //{

            //    PwPath = saveFileDialog1.FileName;

            //}
            //StreamWriter sw = new StreamWriter(PwPath);
            //for (int i = 0; i < listView1.Items.Count; i++)
            //{
            //    foreach (var item in listView1.Items[i].SubItems)
            //    {
            //        // p.HexAsciiConvert(item.ToString());
            //        sw.WriteLine(item);
            //    }
            //}
            //sw.Close();
        }

        private void BTN_ExitPwFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_ZamtalkPasswordFinder_Load(object sender, EventArgs e)
        {
            if (listView1.Columns.Count <= 0)
            {
                p.AddColumns(listView1);

            }
        }


        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.ShowPassword(listView1, LBL_ID, TXT_PW);
            maskedTextBox1.Text = TXT_PW.Text;

            p.Pwshowmask(checkBox1, maskedTextBox1, TXT_PW);

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            p.Pwshowmask(checkBox1, maskedTextBox1, TXT_PW);
        }
    }

}

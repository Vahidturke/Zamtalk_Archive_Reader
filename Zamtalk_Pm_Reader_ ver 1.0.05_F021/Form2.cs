using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zamtalk_Pm_Reader__ver_1._0._05_F021.Properties;
using Zamtalk_Pm_Reader__vr_1._0._0._0;

namespace Zamtalk_Pm_Reader__ver_1._0._05_F021
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Emoji o = new Emoji();
            o.FillListView(listView1);
        }


 

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.SelectedIndices.Add(0);
        }
    }
}

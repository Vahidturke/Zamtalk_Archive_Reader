using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    public interface IPassword
    {
        List<string> ListPassword { get; set; }
        List<string> Listusername { get; set; }
        ListViewItem LsVItem { get; set; }
        RegistryKey ZamReg { get; set; }
        RegistryKey ZamReg2 { get; set; }
        void AddColumns(ListView listView1);
        string HexAsciiConvert(string hex);
        void ShowAllIDZamtalk(ListView listView1);
        void ShowPassword(ListView listView1, Label lblid, TextBox lblpw);
        void Pwshowmask(CheckBox checkBox1, MaskedTextBox maskedTextBox1, TextBox TXT_PW);
    }
}

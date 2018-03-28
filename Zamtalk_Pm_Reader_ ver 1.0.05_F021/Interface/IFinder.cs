using System.Windows.Forms;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    public interface IFinder
    {
        string EditID(string mytext);
        string Editpm(string mytext);
        string FColorEnd(string AllPm);
        string FColorstart(string AllPm);
        string Finish(ListBox alls, TextBox tb);
        string FixID(string all);
        void NewlineAndAddToListBox(RichTextBox richTextBox3, ListBox.ObjectCollection items);
        string PM(string listBox1);
        string PmRemoveTag(TextBox tb3);
        string UserName(string listBox1);
    }
}
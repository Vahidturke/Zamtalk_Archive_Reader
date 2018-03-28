using System.Windows.Forms;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    public interface ISaveAndLoad
    {
        void LoadData(ListBox listBox, string pathtxtfile);
        void LoadDataAfter(ListBox listBox, string pathtxtfile);
        void RemoveDublicValueListbox(ListBox listBox);
        void SaveData(ListBox listBox, string filed);
    }
}
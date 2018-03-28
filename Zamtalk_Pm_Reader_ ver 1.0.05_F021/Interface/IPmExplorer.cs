using System.Windows.Forms;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    public interface IPmExplorer
    {
        /// <summary>
        /// اضافه کردن ایتم های انتخاب شده به  لیست باکس .داری یک ورودی .و برای خواندن مسیر های آرشیو به کار خواهد رفت
        /// </summary>
        /// <param name="mylb">ورودی لیست باکس</param>
        void AddItem(ListBox listbox);

        /// <summary>
        /// حذف ایتم یا مورد انتخاب شده از لیست باکس 
        /// </summary>
        /// <param name="listbox">لیست باکسی که عمل روی آن اجرا خواهد شد</param>
        void DeletedSelectedItems(ListBox listbox);

        /// <summary>
        /// پاک کردن تمام موارد داخل لیست باکس
        /// </summary>
        /// <param name="listbox"></param>
        void ListboxClearAll(ListBox listbox);

        /// <summary>
        /// آیتم هایی که به لیست باکس وارده شده را در تری ویو اضافه کن و نمایش بده
        /// </summary>
        /// <param name="treeView">یک کنترل تری ویو </param>
        /// <param name="listBox">یک کنترلر لیست باکس</param>
        void ListBoxMoveToTreeView(TreeView treeView, ListBox listBox);

        /// <summary>
        /// متدی دارای 2 ورودی برای نمایش آرشیو در تری ویو
        /// </summary>
        /// <param name="treeView1">تری ویو </param>
        /// <param name="path">مسیر پوشه هایی در تری ویو نمایش داده خواهند شد</param>
        void TreeViewexplorer(TreeView treeView1, string path);

    }
}

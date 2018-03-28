using System.Drawing;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    interface ICustomRichTextBox
    {
        bool Highlight(string findWhat, Color highlightColor, bool ismatchCase, bool ismatchWholeWord);
    }
}
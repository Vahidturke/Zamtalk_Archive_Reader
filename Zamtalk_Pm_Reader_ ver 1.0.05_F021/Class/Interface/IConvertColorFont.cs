using System.Drawing;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    public interface IConvertColorFont
    {
        string ConvertZamtalkColorToRTFColor(string ZamtalkColorCode);
        string ExtractHexDigits(string input);
        Color HexStringToColor(string hexColor);
    }
}
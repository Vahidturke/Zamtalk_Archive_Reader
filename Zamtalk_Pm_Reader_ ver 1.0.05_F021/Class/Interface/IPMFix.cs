namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    public interface IPMFix
    {
        string Patern_Enter { get; }
        string Patern_I { get; }
        string Patren_AfterTime2 { get; }
        string Patren_Font_Size { get; }

        string GetPM_Fixed();
        void SetPM_Fixed(string value);
    }
}
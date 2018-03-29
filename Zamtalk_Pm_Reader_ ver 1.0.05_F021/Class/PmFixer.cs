using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    public struct PmFixer
    {
        public Dictionary<string, string> dic;

        /// <summary>
        /// متد ریگولار اکسپریشن برای ریپلیس کردن
        /// </summary>
        /// <param name="BasePm">ورودی متن پی ام </param>
        /// <param name="dic">یک دیکشنری که داری دو سترینگ باشد</param>
        /// <param name="args">یک آرایه از نوع استرینگ</param>
        /// <returns></returns>
        public string M_Fix(string BasePm, Dictionary<string, string> dic, params string[] args)
        {
            args = new string[10];
            dic.Add("\",\"", Environment.NewLine);
            try
            {
                foreach (var item in dic)
                {
                    args[0] = Fixer(Pattern: item.Key, Replacement: item.Value, Input: BasePm);
                }
            }
            catch { }

            dic.Add("\\[[b]]", "\\b ");
            try
            {
                foreach (var item in dic)
                {
                    args[1] = Fixer(Pattern: item.Key, Replacement: item.Value, Input: args[0]);
                }
            }
            catch { }

            dic.Add("\\[i\\]", "\\i ");
            try
            {
                foreach (var item in dic)
                {
                    args[2] = Fixer(Pattern: item.Key, Replacement: item.Value, Input: args[1]);
                }
            }
            catch { }

            dic.Add("\\[s08\\]", "\\fs08 ");
            try
            {
                foreach (var item in dic)
                {
                    args[3] = Fixer(Pattern: item.Key, Replacement: item.Value, Input: args[2]);
                }
            }
            catch { }

            dic.Add("(\\[ul\\])", "\\ul ");
            try
            {
                foreach (var item in dic)
                {
                    args[4] = Fixer(Pattern: item.Key, Replacement: item.Value, Input: args[3]);
                }
            }
            catch { }

            dic.Add("\\[(f\"\"Tahoma\"\")\\]", " \\f0 ");
            try
            {
                foreach (var item in dic)
                {
                    args[5] = Fixer(Pattern: item.Key, Replacement: item.Value, Input: args[4]);
                }
            }
            catch { }

            dic.Add("\\[(f\"\"Microsoft Sans Serif\"\")\\]", " \\f1 ");
            try
            {
                foreach (var item in dic)
                {
                    args[6] = Fixer(Pattern: item.Key, Replacement: item.Value, Input: args[5]);
                }
            }
            catch { }
            return args[6].ToString();
        }

        private string Fixer(string Pattern, string Replacement, string Input)
        {
            string pattern = Pattern;
            string replacement = Replacement;
            string input = Input;

            RegexOptions options = RegexOptions.IgnoreCase;
            Regex regex = new Regex(Pattern, options, TimeSpan.FromMilliseconds(1000));

            return regex.Replace(Input, Replacement);
        }


    }

}

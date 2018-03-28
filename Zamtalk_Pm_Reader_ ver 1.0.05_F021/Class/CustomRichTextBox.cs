/****************************** Module Header ******************************\
* Module Name:      CustomRichTextBox.cs
* Project:                   CSWinFormSearchAndHighlightText
* Copyright(c)          Microsoft Corporation.
* 
* Theclass is used to create custom RichTextBox
* The custom RichTextBox add custom Highlight and ClearHighlight method
*
* This source is subject to the Microsoft Public License.
* See http://www.microsoft.com/en-us/openness/licenses.aspx.
* All other rights reserved.
* 
* THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
* EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
* WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

/*


/* ****************************** هدر ماژول ***************** *************
* نام ماژول: Custom Rich Text Box.cs
* پروژه: CSWin فرم جستجو و متن برجسته
* کپی رایت (c) شرکت مایکروسافت.
*
* Theclass برای ایجاد سفارشی متن Rich Text استفاده می شود
* جعبه غنی متن سفارشی روش سفارشی Highlight و Clear Highlight را اضافه می کند
*
* این منبع تحت مجوز مایکروسافت عمومی است.
* به http://www.microsoft.com/en-us/openness/licenses.aspx مراجعه کنید.
* همه حقوق دیگر محفوظ است.
*
* این کد و اطلاعات ارائه شده \"همانطور که است\" بدون ضمانت هر نوع
* اظهارنظر یا تصریح شده، از جمله اما نه محدود به تصدیق شده
* ضمانت فروش و / یا لوازم مورد نیاز برای یک هدف خاص.
************************************************** ************************ 

*/

using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    /// <summary>
    /// کنترل جعبه سفارشی Rich Text Box
    /// </summary>
    public partial class CustomRichTextBox : RichTextBox
    {
        public CustomRichTextBox() : base()
        {
            InitializeComponent();
        }

        /// <summary>
        /// جستجو و برجسته کردن تمام متن در کنترل متن غنی
        /// </summary>
        /// <param name="findWhat">چه چیز را پیدا کنم</param>
        /// <param name="highlightColor">رنگ برجسته</param>
        /// <param name="ismatchCase">مورد مسابقه است</param>
        /// <param name="ismatchWholeWord">آیا کل کلمه را دنبال می کند</param>
        /// <returns></returns>
        public bool Highlight(string findWhat, Color highlightColor, bool ismatchCase, bool ismatchWholeWord)
        {
            // قبل از جستجوی متن، تمام نکات برجسته را پاک کنید
            ClearHighlight();

            int startSearch = 0;
            //int searchLength = findWhat.Length;
            RichTextBoxFinds findoptions = default(RichTextBoxFinds);

            // راه اندازی گزینه های جستجو
            if (ismatchCase && ismatchWholeWord)
            {
                findoptions = RichTextBoxFinds.MatchCase | RichTextBoxFinds.WholeWord;
            }
            else if (ismatchCase)
            {
                findoptions = RichTextBoxFinds.MatchCase;
            }
            else if (ismatchWholeWord)
            {
                findoptions = RichTextBoxFinds.WholeWord;
            }
            else
            {
                findoptions = RichTextBoxFinds.None;
            }

            // تشخیص اینکه آیا متن جستجو در richtextbox وجود دارد
            bool isfind = false;
            int index = -1;

            // متن جستجو را در کادر متن غنی و رنگ آنها را برجسته کنید.
            while ((index = this.Find(findWhat, startSearch, findoptions)) > -1)
            {
                isfind = true;

                this.SelectionBackColor = highlightColor;

                // بعد از آنکه ما جستجو کردیم، ادامه دهید
                startSearch = index + 1;
            }

            // اگر متن در کادر Rich Text Box وجود داشته باشد، سپس درست را بازگردانید، در غیر اینصورت، بازگشتی اشتباه است
            return isfind;
        }

        /// <summary>
        /// پاک کردن تمام نکات برجسته
        /// </summary>
        private void ClearHighlight()
        {
            this.SelectAll();
            this.SelectionBackColor = Color.White;
        }
    }
}

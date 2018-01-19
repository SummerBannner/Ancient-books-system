using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 古籍管理系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        internal static bool match(string p, string pat1)
        {
            string text = p;
            string pattern = pat1;
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            Match m = r.Match(text);
            if (m.Success)
                return true;
            else
                return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JangSwitch
{
    static class Program
    {
        /// <summary>
        /// 장보고 스위치조립체 프로그램 시작
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Fire(args));
        }
    }
}

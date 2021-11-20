using System;
using System.Windows.Forms;

namespace VK_AI_Bot
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Bot.ConsoleLoggerForm());
        }
    }
}

using System;
using System.Reflection;
using System.Windows.Forms;

namespace Bot
{
    class ConsoleLogger
    {
        public static void Input(Label consoleOutput, string command)
        {
            command = command.Replace(" ", "").ToLower();
            Debug.Log(MethodBase.GetCurrentMethod(), 0, false, command);
            if (command.StartsWith("users"))
            {
                Console.WriteLine(command);
                char[] a = { '+' };
                command = command.Split(a)[1];
                BotStats.BotStatsForm.usersPerMinute += int.Parse(command);
            }
        }
    }
}

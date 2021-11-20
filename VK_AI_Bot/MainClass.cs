using System.Reflection;
using System.Threading;

namespace Bot
{
    class MainClass
    {
        public void init()
        {
            VK.Start();
            Stats();
        }
        
        public static void Stats()
        {
            Thread updateInfoPerDay = new Thread(() => {
                while (true)
                {
                    BotStats.BotStatsForm.messagesPerDay = 0;
                    BotStats.BotStatsForm.usersPerDay = 0;

                    Thread.Sleep(86400 * 1000);
                }
            });
            updateInfoPerDay.Start();
            Debug.Log(MethodBase.GetCurrentMethod(), 2, true, "Thread_updateInfoPerDay");

            Thread updateInfoPerMinute = new Thread(() => {
                while (true)
                {
                    Debug.Log(MethodBase.GetCurrentMethod(), 1, true, "Thread_updateInfoPerMinute");

                    BotStats.BotStatsForm.messagesCount.Add(BotStats.BotStatsForm.messagePerMinute);
                    BotStats.BotStatsForm.usersCount.Add(BotStats.BotStatsForm.usersPerMinute);

                    BotStats.BotStatsForm.messagePerMinute = 0;
                    BotStats.BotStatsForm.usersPerMinute = 0;

                    Thread.Sleep(60000);
                }
            });
            updateInfoPerMinute.Start();
            Debug.Log(MethodBase.GetCurrentMethod(), 2, true, "Thread_updateInfoPerMinute");
        }
    }
}

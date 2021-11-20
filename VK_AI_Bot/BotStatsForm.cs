using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System;
using System.Drawing;

namespace BotStats
{
    public partial class BotStatsForm : Form
    {
        public static int messagesPerDay = 0;
        public static int usersPerDay = 0;
        public static int messagePerMinute = 0;
        public static int usersPerMinute = 0;
        public static List<int> messagesCount = new List<int>();
        public static List<int> usersCount = new List<int>();
        public BotStatsForm()
        {
            InitializeComponent();
        }
    }
}

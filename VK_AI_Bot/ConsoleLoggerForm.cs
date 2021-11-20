using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Bot
{
    public partial class ConsoleLoggerForm : Form
    {
        public ConsoleLoggerForm()
        {
            InitializeComponent();
        }

        private void StatsSelector_Click(object sender, EventArgs e)
        {
            Hide();
            new BotStats.BotStatsForm().Show();
        }

        public int ind = 0;

        public int index(string key) {
            string txt = InputTextArea.Text;
            if (key == "Up") {
                if (txt.Length == 0) {
                    ind = Debug.inputs.Count - 1;
                } else {
                    if (ind != 0) {
                        ind--;
                    } else {
                        ind = Debug.inputs.Count - 1;
                    }
                }
            }
            InputTextArea.Select(InputTextArea.Text.Length, 0);
            return ind;
        }

        private void ConsoleLoggerForm_Load(object sender, EventArgs e)
        {
            new MainClass().init();
            Thread debugUpdate = new Thread(() => {
                while (true)
                {
                    OutputText.Invoke((MethodInvoker)delegate {
                        OutputText.Text = Debug.debugString;
                    });
                }
            });
            debugUpdate.Start();
        }

        private void InputTextArea_KeyDown(object sender, KeyEventArgs e)
        {
            string key = e.KeyCode.ToString();
            if (key == "Up" || key == "Down")
            {
                int i = index(key);
                InputTextArea.Text = Debug.inputs[i];
            }

            if (key == "Return")
            {
                string cmd = InputTextArea.Text;
                InputTextArea.Text = string.Empty;
                ConsoleLogger.Input(OutputText, cmd);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string cmd = InputTextArea.Text;
            InputTextArea.Text = string.Empty;
            ConsoleLogger.Input(OutputText, cmd);
        }
    }
}

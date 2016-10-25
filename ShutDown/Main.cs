using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutDown
{
    public partial class Main : Form
    {
        string cmd;
        decimal timeLeft;
        Timer MyTimer = new Timer();
        public Main()
        {
            InitializeComponent();

            hoursTextBox.Text = "00";
            minutesTextBox.Text = "00";
            secondsTextBox.Text = "00";

            MyTimer.Enabled = false;
            MyTimer.Interval = (1000);
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
        }


        private void doActionButton_Click(object sender, EventArgs e)
        {
            SetupTimer();
            MyTimer.Enabled = true;
            MyTimer.Start();
        }

        private void SetupTimer()
        {
            SetTimer();

        }

        private void SetTimer()
        {
            var hours = GetIntFromTextBox(hoursTextBox) * 60 * 60;
            var minutes = GetIntFromTextBox(minutesTextBox) * 60;
            var seconds = GetIntFromTextBox(secondsTextBox);

            timeLeft = hours + minutes + seconds;
        }

        private int GetIntFromTextBox(TextBox textBox)
        {
            short result;
            if (!Int16.TryParse(textBox.Text, out result))
            {
                textBox.Text = "00";
                result = 0;
            }
            return result;
        }

        private void RunCmdProgram(string cmd)
        {
            var commandPromptProcess = new ProcessStartInfo();
            commandPromptProcess.UseShellExecute = true;

            commandPromptProcess.WorkingDirectory = @"C:\Windows\System32";
            commandPromptProcess.Verb = "runas";
            commandPromptProcess.FileName = @"C:\Windows\System32\cmd.exe";
            commandPromptProcess.Arguments = "/c" + cmd;
            commandPromptProcess.WindowStyle = ProcessWindowStyle.Normal;
            Process.Start(commandPromptProcess);
        }

        private string AddActionToCmd()
        {
            var result = " ";
            if (shutdown.Checked)
                result += "-s -f";
            if (shutdownWithQuickStartup.Checked)
                result += "-hybrid";
            if (restart.Checked)
                result += "-r";
            if (restartAndBoot.Checked)
                result += "-g";
            if (logOff.Checked)
                result += "-l";
            if (hibernate.Checked)
                result += "-h";
            return result;
        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            var time = ConvertMsToReadableTime();
            statusBar.Text = $"Time left: {time}";
            timeLeft--;
            if (timeLeft < 0)
            {
                ExecuteAction();
            }
            var attribute = AddActionToCmd();
            if (attribute == " ")
                errorMessage.Text = "Select an action!";
            else
                errorMessage.Text = string.Empty;
        }

        private void ExecuteAction()
        {
            cmd = "shutdown";
            var attribute = AddActionToCmd();

            if (attribute == " ")
                errorMessage.Text = "Select an action!";
            else
                RunCmdProgram(cmd + attribute);
        }

        private string ConvertMsToReadableTime()
        {
            var timeValue = timeLeft;

            var hours = Math.Floor((decimal)timeValue / 3600);
            timeValue = timeValue - 3600 * hours;

            var minutes = Math.Floor((decimal)timeValue / 60);
            var seconds = timeValue - 60 * minutes;

            string hourText = hours < 10 ? $"0{hours}" : hours.ToString();
            string minText = minutes < 10 ? $"0{minutes}" : minutes.ToString();
            string secText = seconds < 10 ? $"0{seconds}" : seconds.ToString();
            return $"{hourText}:{minText}:{secText}";
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            MyTimer.Enabled = false;
            MyTimer.Stop();
        }
    }
}

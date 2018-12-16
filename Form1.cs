using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace CPU_Memory_Monitor_WinForms
{

    /*
        CPU-Memory Monitor with speech warnings
        WinForms and Metro FrameWork
        Made by: Hodaifa98
        12/16/2018
    */

    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //Boolean that indicates if we warned a user (so we can only warn every 60 minutes)
        private bool cpuWarned = false;
        private bool memoryWarned = false;
        private static float minutesSinceLastWarning = 0;

        //Form Constructor
        public Form1()
        {
            InitializeComponent();
        }

        //Timer Tick
        private void TimerMain_Tick(object sender, EventArgs e)
        {
            //Getting the values of the performance counters
            float cpuUsage = perfCountCpu.NextValue();
            float memoryUsage = perfCountMemoryUsage.NextValue();
            float availableMemory = perfCountAvailableMemory.NextValue();

            //Setting values for the ProgressBars
            progressCPU.Value = (int)cpuUsage;
            progressMemory.Value = (int)memoryUsage;

            //Changing the text of the usage labels
            lblCpu.Text = String.Format("{0:0.00}", cpuUsage);
            lblMemory.Text = String.Format("{0:0}", availableMemory);

            //Updating the cpu and memory chart
            chartMonitor.Series["CPU"].Points.AddY(cpuUsage);
            chartMonitor.Series["Memory"].Points.AddY(memoryUsage);

            //Updating the Uptime
            UpdateUpTime();

            //In case the cpu reached a critical state
            if (cpuUsage >= 100 && cpuWarned == false)
                SpeakWarning("Warning! CPU usage has reached 100 percent!", 1);
            else
                if (cpuUsage >= 80 && cpuWarned == false)
                    SpeakWarning(String.Format("CPU usage has reached {0:0.00} percent", cpuUsage), 1);

            //In case the memory reached a critical state (less than 128 MB)
            if (availableMemory <= 128 && memoryWarned == false)
                SpeakWarning(String.Format("You have {0:0} mega bytes of available memory", availableMemory), 2);

            //Only warn the user ever 30 minutes
            minutesSinceLastWarning += 0.016666667f;
            if (minutesSinceLastWarning >= 30)
            {
                cpuWarned = false;
                memoryWarned = false;
            }
        }

        //Form Load Event
        private void Form1_Load(object sender, EventArgs e)
        {
            //Starting the timer and initalising the tick event for the first time
            TimerMain.Start();
            TimerMain_Tick(null, null);
            UpdateUpTime();
        }

        //Update UpTime
        private void UpdateUpTime()
        {
            //Getting the uptime from the performance counter and updating the corresponding label
            float upTimeValue = perfCountUpTime.NextValue();
            TimeSpan upTimeSpan = TimeSpan.FromSeconds(upTimeValue);
            string upTimeText = String.Format("{0} days {1} hours {2} minutes {3} secondes", (int)upTimeSpan.TotalDays, (int)upTimeSpan.Hours, (int)upTimeSpan.Minutes, (int)upTimeSpan.Seconds);
            lblUpTime.Text = upTimeText;
        }

        //Speak a warning to the user
        private void SpeakWarning(string warningMessage, short warningType)
        {
            //We've now warned the user
            cpuWarned = (warningType == 1) ? true : (memoryWarned = true);
            minutesSinceLastWarning = 0;

            //Speaking the warning
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SelectVoiceByHints(VoiceGender.Neutral);
            synth.SpeakAsync(warningMessage);
        }
    }
}

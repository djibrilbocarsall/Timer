using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class lbTimerChornologie : Form
    {
        public lbTimerChornologie()
        {
            InitializeComponent();
        }
        int S, M, H = 0;
        bool EnterInTime = true;

      
          


      

        private void timer3_Tick(object sender, EventArgs e)
        {
           
            S--;
            Update();
            GetTimeINString();
           

        }
        void GetTimeINString()
        {
            lbTimerChorno.Text = H.ToString("D2") + ":" + M.ToString("D2") + ":" + S.ToString("D2");
        }
        void StartTime()
        {
            H = int.Parse(numericUpDownHours.Value.ToString());
            M = int.Parse(numericUpDownMinutes.Value.ToString());
            S = int.Parse(numericUpDownSeconds.Value.ToString());
        }
        void Update()
        {
           
            if (S == 0 && M != 0)
            {
                M--;
                
                S = 60;
            }
            if (M == 0 && H != 0)
            {
                H--;
                M = 59;
            }if(S == 0 && M == 0 && H == 0)
            {
              //  GetTimeINString();
              timer3.Enabled= false;
              RestartTimerChrono();
                
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartTimerChrono();
        }
        void RestartTimerChrono()
        {
            H = 0;
            M = 0;
            S = 0;
            EnterInTime = true;
            timer3.Enabled = false;
            numericUpDownHours.Value = 0;
            numericUpDownMinutes.Value = 0;
            numericUpDownSeconds.Value = 0;
            GetTimeINString();
            btnStart.Text = "Start";
        }

      

        void StopedAndStartedTimeAndNotify()
        {
            if (btnStart.Text == "Start")
            {
                timer3.Enabled = true;
                NotificationInOnClick("Timer Started");
                btnStart.Text = "Stop";
            }

            else
            {

                timer3.Enabled = false;
                NotificationInOnClick("Timer Stoped");
                btnStart.Text = "Start";
            }

        }
        void NotificationInOnClick(string TextNotification)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Timer";
            notifyIcon1.BalloonTipText = TextNotification;
            notifyIcon1.ShowBalloonTip(1000);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
           if(EnterInTime == true)
            {
                StartTime();
                EnterInTime = false;
            }
          StopedAndStartedTimeAndNotify();
            

        }
    }
}

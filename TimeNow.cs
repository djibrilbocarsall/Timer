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
    public partial class TimeNow : Form
    {
        public TimeNow()
        {
            InitializeComponent();
        }
        int H = DateTime.Now.Hour;
        int M = DateTime.Now.Minute;
        int S = DateTime.Now.Second;

        private void lbChronologie_Click(object sender, EventArgs e)
        {
            
        }
        void Update()
        {
            if (S == 59)
            {
                S = 0;
                M++;
            }
            if (M == 59)
            {
                M = 0;
                H++;
            }
        }
        private void TimeNow_Load(object sender, EventArgs e)
        {
        
            timer2.Enabled =  Enabled = true;
            lbTimeNow.Text = H.ToString("D2") + ":" + M.ToString("D2") + ":" + S.ToString("D2");

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            S++;
            Update();
            lbTimeNow.Text = H.ToString("D2") + ":" + M.ToString("D2") + ":" + S.ToString("D2");




        }
    }
}

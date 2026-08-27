using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Timer
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            // Assurez-vous que la form est en mode MDI
            this.IsMdiContainer = true;

            // Change la couleur de la surface MDI (sans toucher this.BackColor)
            SetMdiClientBackColor(SystemColors.ActiveCaption); // remplacez Color.White par la couleur désirée

           // Image deleteIcon = Image.FromFile(@"C:\Users\PC\Downloads\delete.png");
        }
        int s, m, h = 0;
        int Counter = 0;
        void Update()
        {
            if (s == 59)
            {
                s = 0;
                m++;
            }
            if (m == 59)
            {
                m = 0;
                h++;
            }
        }
        void Restart()
        {
            timer1.Enabled = false;
            listView1.Items.Clear();
            s = 0;
            m = 0;
            h = 0;
            lbChronologie.Text = h.ToString("D2") + ":" + m.ToString("D2") + ":" + s.ToString("D2");
            btnStart.Text = "Start";
        }
        private void SetMdiClientBackColor(Color color)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient mdiClient)
                {
                    mdiClient.BackColor = color;
                    // si vous voulez aussi forcer la redessine :
                    mdiClient.Invalidate();
                    break;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            
            StopedAndStartedTime();




        }
        void StopedAndStartedTime()
        {
            if (btnStart.Text == "Start")
            {
                timer1.Enabled = true;
                btnStart.Text = "Stop";
            }

            else
            {

                timer1.Enabled = false;
                btnStart.Text = "Start";
            }

        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            Update();
            lbChronologie.Text = h.ToString("D2") + ":" + m.ToString("D2") + ":" + s.ToString("D2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddList();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void timerNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeNow timeNow = new TimeNow();
            timeNow.Show();
        }

        private void timerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbTimerChornologie TimerChrono = new lbTimerChornologie();
            TimerChrono.Show();
        }

        private void stopWatchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        void AddList()
        {
            Counter++;
          


            if (string.IsNullOrEmpty(lbChronologie.Text))
            {
                return;
            }
           
            ListViewItem item = new ListViewItem(Counter.ToString());

           
            item.SubItems.Add(DateTime.Now.ToString("T"));
            item.SubItems.Add(lbChronologie.Text);
            item.ImageIndex = 0;
            listView1.Items.Add(item);

            

        }

        private void listView1_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Delete Item","Delete",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (listView1.Items.Count > 0)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
            else
            {
                return;
            }
            
          
        }
       
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        }
    
}

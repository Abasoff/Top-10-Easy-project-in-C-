using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Project_v05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = "Running";
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Stop";
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dte = DateTime.Now;
            DateTime alarmTime = dateTimePicker1.Value;

            if(dte.Hour==alarmTime.Hour && dte.Minute == alarmTime.Minute && dte.Second == alarmTime.Second)
            {
                timer1.Stop();
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation=@;
            }
        }
    }
}

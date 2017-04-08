using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HittingGame
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int rand_x, rand_y;
        int score = 0;
        int totall_shoots = 0;
        int missed_shoots = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rand_x = rand.Next(12,590);
            rand_y = rand.Next(288,490);
            pictureBox1.Location = new Point(rand_x, rand_y);

            if (missed_shoots >= 10)
            {
                timer1.Stop();
                label4.Text = "Game Over";
                //labscore.Text = "";
                //score = Convert.ToInt32("");
            }

        }

        void gun_shoot_voice()
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\Windows\Media\gun-gunshot-01.wav");
            sp.Play();
        }

        void fun_shoots()
        {
            gun_shoot_voice();
            score++;
            totall_shoots++;
            labscore.Text = Convert.ToString(score);
            labtotaltarget.Text = Convert.ToString(totall_shoots);
        }

        void fun_missed_shoots()
        {
            gun_shoot_voice();
            missed_shoots++;
            totall_shoots++;
            labtotaltarget.Text = Convert.ToString(totall_shoots);
            labmissedtarget.Text = Convert.ToString(missed_shoots);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fun_shoots();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            fun_missed_shoots();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label4.Text = "";
            score = 0;
            missed_shoots =0;
            totall_shoots =0;
            labscore.Text = Convert.ToString(score);
            labtotaltarget.Text = Convert.ToString(totall_shoots);
            labmissedtarget.Text = Convert.ToString(missed_shoots);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labmissedtarget_Click(object sender, EventArgs e)
        {

        }
    }
}

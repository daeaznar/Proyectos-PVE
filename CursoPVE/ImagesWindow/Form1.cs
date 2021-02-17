using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagesWindow
{
    public partial class Form1 : Form
    {
        private int tickCount;
        public Form1()
        {
            tickCount = 0;
            InitializeComponent();
        }

        private void tmrSequence_Tick(object sender, EventArgs e)
        {
            ++tickCount;
            if (tickCount > 3)
            {
                tickCount = 1;
            }

            switch (tickCount)
            {
                case 1:
                    pctFirst.Image = Properties.Resources.Mario;
                    pctSecond.Image = Properties.Resources.Luigi;
                    pctThird.Image = Properties.Resources.Yoshi;
                    pctQuestion.Tag = 1;
                    break;

                case 2:
                    pctFirst.Image = Properties.Resources.Luigi;
                    pctSecond.Image = Properties.Resources.Yoshi;
                    pctThird.Image = Properties.Resources.Mario;
                    pctQuestion.Tag = 2;
                    break;

                case 3:
                    pctFirst.Image = Properties.Resources.Yoshi;
                    pctSecond.Image = Properties.Resources.Mario;
                    pctThird.Image = Properties.Resources.Luigi;
                    pctQuestion.Tag = 3;
                    break;
            }
        }

        private void pctPlay_Click(object sender, EventArgs e)
        {
            tmrSequence.Start();
        }

        private void pctPause_Click(object sender, EventArgs e)
        {
            tmrSequence.Stop();
        }

        private void pctSchedule_Click(object sender, EventArgs e)
        {
            tmrSequence.Stop();
            Schedule window = new Schedule();
            DialogResult response = window.ShowDialog();
            if (response == DialogResult.Cancel)
            {
                tmrSequence.Start();
            }
        }

        private void pctNewWindow_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void pctQuestion_Click(object sender, EventArgs e)
        {
            tmrSequence.Stop();
            switch (pctQuestion.Tag)
            {
                case 1:
                    pctQuestion.Image = Properties.Resources.Mario;
                    Thread.Sleep(500);
                    break;

                case 2:
                    pctQuestion.Image = Properties.Resources.Luigi;
                    Thread.Sleep(500);
                    break;

                case 3:
                    pctQuestion.Image = Properties.Resources.Yoshi;
                    Thread.Sleep(500);
                    break;
            }
            if (Convert.ToInt32(pctFirst.Tag) == Convert.ToInt32(pctQuestion.Tag)) //Convert object to int
            {
                MessageBox.Show("Match!");
            }

            Thread.Sleep(500);
            pctQuestion.Image = Properties.Resources.question;
            tmrSequence.Start();
        }
    }
}

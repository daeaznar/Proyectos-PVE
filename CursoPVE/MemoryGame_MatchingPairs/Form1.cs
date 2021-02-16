using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame_MatchingPairs
{
    public partial class Form1 : Form
    {
        private int tickCountSec;
        private int tickCountMin;
        public Form1()
        {
            tickCountSec = 0;
            tickCountMin = 0;
            InitializeComponent();
        }

        private void tmrSeconds_Tick(object sender, EventArgs e)
        {
            ++tickCountSec;
            if (tickCountSec == 60)
            {
                tickCountSec = 0;
                ++tickCountMin;
            }

            if (tickCountMin < 10)
            {
                if (tickCountSec < 10)
                {
                    lblTimer.Text = $"Timer: 0{tickCountMin}:0{tickCountSec}";
                }
                else
                {
                    lblTimer.Text = $"Timer: 0{tickCountMin}:{tickCountSec}";
                }

            }
            else
            {
                if (tickCountSec < 10)
                {
                    lblTimer.Text = $"Timer: {tickCountMin}:0{tickCountSec}";
                }
                else
                {
                    lblTimer.Text = $"Timer: {tickCountMin}:{tickCountSec}";
                }

            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSeconds.Start();
        }
    }
}

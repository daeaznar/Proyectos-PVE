using System;
using System.Windows.Forms;

namespace MemoryGame_MatchingPairs
{
    public partial class Form1 : Form
    {
        private int tickCountSec; //Counts seconds
        private int tickCountMin;   // Counts minutes
        int matches = 0;
        int moves = 0;
        PictureBox img1, img2;  // stores first & second selected images to compare
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

        private void tmrShow_Tick(object sender, EventArgs e)
        {
            tmrShow.Stop();
            img1.Image = Properties.Resources.Logo;
            img2.Image = Properties.Resources.Logo;
            img1 = null;
            img2 = null;
        }

        #region Cards
        private void pctOne_Click(object sender, EventArgs e)
        {
            pctOne.Image = Properties.Resources.Aliens;
            if (img1 == null)
            {
                img1 = pctOne;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctOne;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctOne.Enabled = false;
                    pctEleven.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }

        private void pctTwo_Click(object sender, EventArgs e)
        {
            pctTwo.Image = Properties.Resources.Bullseye;
            if (img1 == null)
            {
                img1 = pctTwo;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctTwo;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctTwo.Enabled = false;
                    pctTwelve.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }

        private void pctThree_Click(object sender, EventArgs e)
        {
            pctThree.Image = Properties.Resources.Buzz_Lightyear;
            if (img1 == null)
            {
                img1 = pctThree;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctThree;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctThree.Enabled = false;
                    pctThirteen.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }

        private void pctFour_Click(object sender, EventArgs e)
        {
            pctFour.Image = Properties.Resources.Hamm;
            if (img1 == null)
            {
                img1 = pctFour;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctFour;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctFour.Enabled = false;
                    pctFourteen.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }

        private void pctFive_Click(object sender, EventArgs e)
        {
            pctFive.Image = Properties.Resources.Jessie;
            if (img1 == null)
            {
                img1 = pctFive;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctFive;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctFive.Enabled = false;
                    pctFifteen.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }

        private void pctSix_Click(object sender, EventArgs e)
        {
            pctSix.Image = Properties.Resources.Potato;
            if (img1 == null)
            {
                img1 = pctSix;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctSix;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctSix.Enabled = false;
                    pctSixteen.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }

        private void pctSeven_Click(object sender, EventArgs e)
        {
            pctSeven.Image = Properties.Resources.Rex;
            if (img1 == null)
            {
                img1 = pctSeven;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctSeven;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctSeven.Enabled = false;
                    pctSeventeen.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }

        private void pctEight_Click(object sender, EventArgs e)
        {
            pctEight.Image = Properties.Resources.Slinky;
            if (img1 == null)
            {
                img1 = pctEight;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctEight;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctEight.Enabled = false;
                    pctEighteen.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }

        private void pctNine_Click(object sender, EventArgs e)
        {
            pctNine.Image = Properties.Resources.Woody;
            if (img1 == null)
            {
                img1 = pctNine;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctNine;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctNine.Enabled = false;
                    pctNineteen.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }

        private void pctTen_Click(object sender, EventArgs e)
        {
            pctTen.Image = Properties.Resources.Zurg;
            if (img1 == null)
            {
                img1 = pctTen;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctTen;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctTen.Enabled = false;
                    pctTwenty.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }

        private void pctEleven_Click(object sender, EventArgs e)
        {
            pctEleven.Image = Properties.Resources.Aliens;
            if (img1 == null)
            {
                img1 = pctEleven;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctEleven;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctOne.Enabled = false;
                    pctEleven.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }

        private void pctTwelve_Click(object sender, EventArgs e)
        {
            pctTwelve.Image = Properties.Resources.Bullseye;
            if (img1 == null)
            {
                img1 = pctTwelve;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctTwelve;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctTwo.Enabled = false;
                    pctTwelve.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }

        private void pctThirteen_Click(object sender, EventArgs e)
        {
            pctThirteen.Image = Properties.Resources.Buzz_Lightyear;
            if (img1 == null)
            {
                img1 = pctThirteen;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctThirteen;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctThree.Enabled = false;
                    pctThirteen.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }

        private void pctFourteen_Click(object sender, EventArgs e)
        {
            pctFourteen.Image = Properties.Resources.Hamm;
            if (img1 == null)
            {
                img1 = pctFourteen;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctFourteen;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctFour.Enabled = false;
                    pctFourteen.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }

        private void pctFifteen_Click(object sender, EventArgs e)
        {
            pctFifteen.Image = Properties.Resources.Jessie;
            if (img1 == null)
            {
                img1 = pctFifteen;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctFifteen;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctFive.Enabled = false;
                    pctFifteen.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }

        private void pctSixteen_Click(object sender, EventArgs e)
        {
            pctSixteen.Image = Properties.Resources.Potato;
            if (img1 == null)
            {
                img1 = pctSixteen;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctSixteen;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctSix.Enabled = false;
                    pctSixteen.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }

        private void pctSeventeen_Click(object sender, EventArgs e)
        {
            pctSeventeen.Image = Properties.Resources.Rex;
            if (img1 == null)
            {
                img1 = pctSeventeen;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctSeventeen;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctSeven.Enabled = false;
                    pctSeventeen.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }

        private void pctEighteen_Click(object sender, EventArgs e)
        {
            pctEighteen.Image = Properties.Resources.Slinky;
            if (img1 == null)
            {
                img1 = pctEighteen;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctEighteen;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctEight.Enabled = false;
                    pctEighteen.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }

        private void pctNineteen_Click(object sender, EventArgs e)
        {
            pctNineteen.Image = Properties.Resources.Woody;
            if (img1 == null)
            {
                img1 = pctNineteen;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctNineteen;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctNine.Enabled = false;
                    pctNineteen.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }

        private void pctTwenty_Click(object sender, EventArgs e)
        {
            pctTwenty.Image = Properties.Resources.Zurg;
            if (img1 == null)
            {
                img1 = pctTwenty;
            }
            else
            {
                if (img2 == null)
                {
                    img2 = pctTwenty;
                }
            }
            if (img1 != null && img2 != null)
            {
                if (img1.Tag == img2.Tag)
                {
                    img1 = null;
                    img2 = null;
                    pctTen.Enabled = false;
                    pctTwenty.Enabled = false;
                    ++matches;
                    ++moves;
                    lblMatch.Text = $"Matches: {matches}";
                    lblMoves.Text = $"Moves: {moves}";
                }
                else
                {
                    ++moves;
                    lblMoves.Text = $"Moves: {moves}";
                    tmrShow.Start();
                }
            }
        }
        #endregion

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSeconds.Start();
        }
    }
}

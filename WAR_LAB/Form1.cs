using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAR_LAB
{
    public partial class Form1 : Form
    {
        readonly Random random = new Random();
        int _roundCounter = 0;
        int _playerScore = 0;
        int _opponentScore = 0;
        int _maxRounds = 0;
        
        bool _playerWon = false;

        private void GameSetupBox()
        {
            var setupBox = new Form2();
            string PlayerName ="";
            string OpponentName = "";
            int rounds = 0;
            DialogResult dr = setupBox.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
            PlayerName = setupBox.getPlayerName();
            OpponentName = setupBox.getOpponentName();
            if (PlayerName == "" || OpponentName == "")
                {
                    MessageBox.Show("Fill all fields");
                    GameSetupBox();
                }
                try
                { 
                    rounds = int.Parse(setupBox.getRounds());
                }
                catch(FormatException)
                {
                    MessageBox.Show("Fill up all fields");
                    GameSetupBox();
                }
            }
            else
            {
                setupBox.Close();
            }
            FirstGame(PlayerName, OpponentName, rounds);
            setupBox.Dispose();

        }

        public Form1()
        {
            InitializeComponent();
            GameSetupBox();
        }
        private void FirstGame(string _PlayerName, string _OppName, int Rounds)
        {
            PlayerNameLabel.Text = _PlayerName;
            OpponentName.Text = _OppName;
            PlayerButton.Text = _PlayerName + " cards";
            OponnentButton.Text = _OppName + " cards";
            PlayerScoreTag.Text = _PlayerName + " points ";
            OpponentScoreTag.Text = _OppName + " points ";
            _maxRounds = Rounds;
            _roundCounter = 0;
            _playerScore = 0;
            _opponentScore = 0;
            PlayerScoreButton.Text = "0";
            PlayerScoreLabel.Text = "0";
            OponnentScoreButton.Text = "0";
            OponnentScoreLabel.Text = "0";
            RoundCounter.Text = "Round " + _roundCounter +" of " + _maxRounds;
            PlayerScoreButton.BackColor = System.Drawing.Color.Empty;
            OponnentScoreButton.BackColor = System.Drawing.Color.Empty;
        }

        private void NewGame()
        {
            _roundCounter = 0;
            _playerScore = 0;
            _opponentScore = 0;
            PlayerScoreButton.Text = "0";
            PlayerScoreLabel.Text = "0";
            OponnentScoreButton.Text = "0";
            OponnentScoreLabel.Text = "0";
            RoundCounter.Text = "Round " + _roundCounter + " of " + _maxRounds;
            PlayerScoreButton.BackColor = System.Drawing.Color.Empty;
            OponnentScoreButton.BackColor = System.Drawing.Color.Empty;
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string message = "War v.1.0";
            string caption = "About";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(this, message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                return;
            }
        }

        private void PlayerWonRound(int playerScore,int _cpuScore)
        {
            PlayerScoreButton.Text = playerScore.ToString();
            OponnentScoreButton.Text = _cpuScore.ToString();
            _roundCounter += 1;
            _playerScore += 1;
            PlayerScoreButton.BackColor = System.Drawing.Color.Green;
            OponnentScoreButton.BackColor = System.Drawing.Color.Red;
        }

        private void CpuWonRound(int playerScore, int _cpuScore)
        {
            PlayerScoreButton.Text = playerScore.ToString();
            OponnentScoreButton.Text = _cpuScore.ToString();
            _roundCounter += 1;
            _opponentScore += 1;
            PlayerScoreButton.BackColor = System.Drawing.Color.Red;
            OponnentScoreButton.BackColor = System.Drawing.Color.Green;
        }

        private void Tie(int playerScore, int _cpuScore)
        {
            PlayerScoreButton.Text = playerScore.ToString();
            OponnentScoreButton.Text = _cpuScore.ToString();
            _roundCounter += 1;
            PlayerScoreButton.BackColor = System.Drawing.Color.Orange;
            OponnentScoreButton.BackColor = System.Drawing.Color.Orange;
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameSetupBox();
        }

        private void GameEngine(int PlayerScoreValue, int OponnentScoreValue)
        {
            //player has bigger number
            if (PlayerScoreValue > OponnentScoreValue)
            {
                PlayerWonRound(PlayerScoreValue, OponnentScoreValue);
            }
            //Opp has bigger number
            else if (PlayerScoreValue < OponnentScoreValue)
            {
                CpuWonRound(PlayerScoreValue, OponnentScoreValue);
            }
            //Tie
            else
            {
                Tie(PlayerScoreValue, OponnentScoreValue);
            }
            if (_roundCounter > _maxRounds)
            {
                if (_playerScore > _opponentScore)
                {
                    _playerWon = true;
                }
                string message = null;

                if (_playerWon)
                {
                    message = "You won! Wanna play again ?";
                }
                else
                {
                    message = "You lost! Wanna play again?";
                }
                string caption = "The end";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(this, message, caption, buttons);


                if (result == DialogResult.Yes)
                {
                    NewGame();
                }
                else
                {
                    DialogResult result2;
                    string message2 = "Do you wanna close?";
                    // Displays the MessageBox.

                    result2 = MessageBox.Show(this, message2, caption, buttons);

                    if (result2 == DialogResult.Yes)
                    {
                        Close();
                    }
                }
            }
            
            RoundCounter.Text = "Round " + _roundCounter + " of " + _maxRounds;
            PlayerScoreLabel.Text = _playerScore.ToString();
            OponnentScoreLabel.Text = _opponentScore.ToString();

        }

        private void PlayerController_Click(object sender, EventArgs e)
        {
            //Choosing a random number for player and cpu
            var PlayerScoreValue = random.Next(1, 11);
            var OponnentScoreValue = random.Next(1, 11);
            GameEngine(PlayerScoreValue, OponnentScoreValue);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }
    }
}

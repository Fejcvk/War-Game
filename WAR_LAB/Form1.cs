using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WAR_LAB;

namespace WAR_LAB
{
    public partial class Form1 : Form
    {
        readonly Random random = new Random();
        int _roundCounter = 0;
        int _playerScore = 10;
        int _opponentScore = 10;
        int _maxRounds = 0;
        bool _playerWon = true;
        bool _firstLaunch = true;
        private bool _autoPlayOn = false;
        bool _warIsOver = false;
        int _setAmount = 2;
        private int _cardAmount = 0;
        private Queue<int> PlayerSet = new Queue<int>();
        private Queue<int> OpponentSet = new Queue<int>();
        public void GameSetupBox()
        {
            var setupBox = new Form2();
            string PlayerName = "";
            string OpponentName = "";
            int rounds = 0;
            DialogResult dr = setupBox.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                PlayerName = setupBox.getPlayerName();
                OpponentName = setupBox.getOpponentName();
                _setAmount = setupBox.getSets();
                if (PlayerName == "" || OpponentName == "")
                {
                    MessageBox.Show("Fill all fields");
                    GameSetupBox();
                }
                try
                {
                    rounds = int.Parse(setupBox.getRounds());
                }
                catch (FormatException)
                {
                    MessageBox.Show("Fill up all fields");
                    GameSetupBox();
                }
            }
            else
            {
                setupBox.Dispose();
            }
            FirstGame(PlayerName, OpponentName, rounds);
            setupBox.Dispose();
        }

        public Form1()
        {
            InitializeComponent();
            GameSetupBox();
        }

        public void FillDecksWithCards(Queue<int> queue, Queue<int> queue2)
        {
            for (int i = 0; i < _cardAmount / 2 ; i++)
            {
                queue.Enqueue(random.Next(1, 11));
                queue2.Enqueue(random.Next(1, 11));
            }
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
            _playerScore = 10;
            _opponentScore = 10;
            _cardAmount = 10 * _setAmount;
            PlayerScoreButton.Text = "";
            PlayerScoreLabel.Text = "10";
            OponnentScoreButton.Text = "";
            OponnentScoreLabel.Text = "10";
            RoundCounter.Text = "Round " + _roundCounter + " of " + _maxRounds;
            PlayerScoreButton.BackColor = System.Drawing.Color.Empty;
            OponnentScoreButton.BackColor = System.Drawing.Color.Empty;
            FillDecksWithCards(PlayerSet, OpponentSet);
        }

        private void NewGame()
        {
            _roundCounter = 0;
            _playerScore = 10;
            _opponentScore = 10;
            _cardAmount = 10 * _setAmount;
            PlayerScoreButton.Text = "";
            PlayerScoreLabel.Text = "10";
            OponnentScoreButton.Text = "";
            OponnentScoreLabel.Text = "10";
            RoundCounter.Text = "Round " + _roundCounter + " of " + _maxRounds;
            PlayerScoreButton.BackColor = System.Drawing.Color.Empty;
            OponnentScoreButton.BackColor = System.Drawing.Color.Empty;
            FillDecksWithCards(PlayerSet, OpponentSet);
        }

        public string getLastRound()
        {
            return LastRoundTextbox.Text;
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

        private void PlayerWonRound(int playerScore, int _cpuScore)
        {
            PlayerScoreButton.Text = playerScore.ToString();
            OponnentScoreButton.Text = _cpuScore.ToString();
            _roundCounter += 1;
            _playerScore += 1;
            _opponentScore -= 1;
            PlayerScoreButton.BackColor = System.Drawing.Color.Green;
            OponnentScoreButton.BackColor = System.Drawing.Color.Red;
            PlayerSet.Enqueue(playerScore);
            PlayerSet.Enqueue(_cpuScore);
        }

        private void CpuWonRound(int playerScore, int _cpuScore)
        {
            PlayerScoreButton.Text = playerScore.ToString();
            OponnentScoreButton.Text = _cpuScore.ToString();
            _roundCounter += 1;
            _opponentScore += 1;
            _playerScore -= 1;
            PlayerScoreButton.BackColor = System.Drawing.Color.Red;
            OponnentScoreButton.BackColor = System.Drawing.Color.Green;
            OpponentSet.Enqueue(playerScore);
            OpponentSet.Enqueue(_cpuScore);
        }

        private void RestoreButtonViewAfterWar()
        {
            //PlayerScoreButton.BackgroundImage = nowy numerek
            //OponnentScoreButton.BackgroundImage = nowy numerek
        }
        private void Tie()
        {
            PlayerSet.Dequeue();
            OpponentSet.Dequeue();
            War();
            if (_warIsOver == true)
            {
                RestoreButtonViewAfterWar();
            }
            _warIsOver = false;
        }

        private void War()
        {
            PlayerScoreButton.BackgroundImage = PlayerButton.BackgroundImage;
            OponnentScoreButton.BackgroundImage = PlayerButton.BackgroundImage;
            int _pScore = PlayerSet.Dequeue();
            int _oScore = OpponentSet.Dequeue();
            if (_pScore > _oScore)
            {
                PlayerWonRound(_playerScore, _oScore);
                _warIsOver = true;
            }
            else if (_pScore < _oScore)
            {
                CpuWonRound(_pScore, _oScore);
                _warIsOver = true;
            }
            else
            {
                Tie();
            }
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameSetupBox();
        }

        private void GameEngine(Queue<int> PlayerDeck, Queue<int>CpuDeck)
        {
            int PlayerScoreValue = PlayerDeck.Dequeue();
            int OponnentScoreValue = CpuDeck.Dequeue();
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
            else if(PlayerScoreValue == OponnentScoreValue)
            {
                Tie();
            }
            //Game finished by number of Rounds
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
            }
            //Game fibished with one of players run out of cards
            else if (PlayerSet.Count == 0 || OpponentSet.Count == 0)
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
            }

            RoundCounter.Text = "Round " + _roundCounter + " of " + _maxRounds;
            PlayerScoreLabel.Text = _playerScore.ToString();
            OponnentScoreLabel.Text = _opponentScore.ToString();
        }

        private void PlayerController_Click(object sender, EventArgs e)
        {
           GameEngine(PlayerSet, OpponentSet);
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
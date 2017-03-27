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
        //some global variables
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
        private List<int> GameDeck = new List<int>();


        //whole behaviour of setup box
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
        //function fill main deck and then divide cards into players queues
        public void FillDecksWithCards(Queue<int> queue, Queue<int> queue2)
        {
            //fill list main deck with cards 1-10 * number of sets
            for (int i = 0; i < _setAmount ; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    GameDeck.Add(j);
                }
            }
            //while list containing all set of cards is non empty pick two random indices
            //and enqueue them into the players queue's
            while (GameDeck.Count != 0)
            {
                int randomixd1 = random.Next(0, GameDeck.Count);
                int randomixd2 = random.Next(0, GameDeck.Count-1);
                queue.Enqueue(GameDeck.ElementAt(randomixd1));
                GameDeck.RemoveAt(randomixd1);
                queue2.Enqueue(GameDeck.ElementAt(randomixd2));
                GameDeck.RemoveAt(randomixd2);
            }
        }
        //setup first game
        private void FirstGame(string _PlayerName, string _OppName, int Rounds)
        {
            PlayerNameLabel.Text = _PlayerName;
            OpponentName.Text = _OppName;
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
            PlayerScoreButton.BackgroundImage = OponnentScoreButton.BackgroundImage = null;

        }
        //setup newgame
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
            PlayerScoreButton.BackgroundImage = OponnentScoreButton.BackgroundImage = null;

        }
        //setup new _maxRound baased on input
        public string getLastRound()
        {
            return LastRoundTextbox.Text;
        }
        //function is called while Start button is pushed
        private void setRoundForAutoplay()
        {
            int newMaxRound = int.Parse(getLastRound());
            _maxRounds = newMaxRound;
        }
        //dropdown menu
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
        //player won round
        private void PlayerWonRound(int playerScore, int _cpuScore)
        {
            _roundCounter += 1;
            _playerScore += 1;
            _opponentScore -= 1;
            PlayerScoreButton.BackColor = System.Drawing.Color.Green;
            OponnentScoreButton.BackColor = System.Drawing.Color.Red;
            PlayerSet.Enqueue(playerScore);
            PlayerSet.Enqueue(_cpuScore);
        }
        //cpu won round
        private void CpuWonRound(int playerScore, int _cpuScore)
        {
            _roundCounter += 1;
            _opponentScore += 1;
            _playerScore -= 1;
            PlayerScoreButton.BackColor = System.Drawing.Color.Red;
            OponnentScoreButton.BackColor = System.Drawing.Color.Green;
            OpponentSet.Enqueue(playerScore);
            OpponentSet.Enqueue(_cpuScore);
        }
        //tie situation solution
        private void Tie()
        {
            PlayerSet.Dequeue();
            OpponentSet.Dequeue();
            War();
        }
        //war situation solution
        private void War()
        {
            PlayerScoreButton.BackgroundImage = PlayerButton.BackgroundImage;
            OponnentScoreButton.BackgroundImage = PlayerButton.BackgroundImage;
            int _pScore = PlayerSet.Dequeue();
            int _oScore = OpponentSet.Dequeue();
        }
        //set right png to given value
        private void SetNumberPicture(Button button, int index)
        {
            Rectangle section = new Rectangle(100 * (index - 1), 0, 100, 147);

            Bitmap src = Properties.Resources.numerki1;
            Bitmap target = new Bitmap(section.Width, section.Height);

            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height), section, GraphicsUnit.Pixel);
            }

            button.BackgroundImage = target;
            button.BackgroundImageLayout = ImageLayout.Stretch;
        }
        //dropdown menu
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameSetupBox();
        }
        //game logic
        private void GameEngine(Queue<int> playerDeck, Queue<int>cpuDeck)
        {
            //get player number out of queue
            int PlayerScoreValue = playerDeck.Dequeue();
            //set right png
            SetNumberPicture(PlayerScoreButton, PlayerScoreValue);
            //get cpu number out of queue
            int OponnentScoreValue = cpuDeck.Dequeue();
            //set right png
            SetNumberPicture(OponnentScoreButton, OponnentScoreValue);
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
        //player button behaviour
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
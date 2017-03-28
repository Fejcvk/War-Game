using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using WAR_LAB.Properties;

/*
 * TODO : 
 * 1. Zamykac sie za pierwszym razem odpalania setupboxa
 * 3. Zapisywanie do statystyk
 * 4. Autoplay speed can be changed during the game
 * 5. Trzeba zamknac postgame stats zeby wrocic do gry
 * 6. Cale wyswietlanie HS -> pojebane gówno
*/

namespace WAR_LAB
{
    public partial class Form1 : Form
    {
        //some global variables
        bool _stopAutoplay = true;
        private static Timer myTimer = new Timer();
        readonly Random random = new Random();
        int _roundCounter = 1;
        int _playerScore = 10;
        int _opponentScore = 10;
        int _maxRounds;
        bool _playerWon;
        private bool _autoPlayOn = false;
        int _setAmount = 2;
        private int _cardAmount;
        private Queue<int> PlayerSet = new Queue<int>();
        private Queue<int> OpponentSet = new Queue<int>();
        private List<int> GameDeck = new List<int>();
        public Dictionary<double, double> PlayerRoundDictionary = new Dictionary<double, double>();
        public Dictionary<double, double> CPURoundDictionary = new Dictionary<double, double>();
        public GameState CurrentGameState;
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
            FormClosing += OnClosing;
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
                CurrentGameState.Deck = GameDeck;
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
            CurrentGameState.PlayerDeck = queue;
            CurrentGameState.OppDeck = queue2;
        }
        //setup first game
        private void FirstGame(string _PlayerName, string _OppName, int Rounds)
        {
            CurrentGameState = new GameState();
            CurrentGameState.PlayerName=PlayerNameLabel.Text = _PlayerName;
            CurrentGameState.OppName=OpponentName.Text = _OppName;
            PlayerScoreTag.Text = _PlayerName + " points ";
            OpponentScoreTag.Text = _OppName + " points ";
            CurrentGameState.roundNumber = _roundCounter;
            CurrentGameState.maxRounds =_maxRounds = Rounds;
            CurrentGameState.playerScore =_playerScore = 10;
            CurrentGameState.oppScore =_opponentScore = 10;
            _cardAmount = 10 * _setAmount;
            CurrentGameState.Deck = GameDeck;
            PlayerScoreLabel.Text = "10";
            OponnentScoreLabel.Text = "10";
            RoundCounter.Text = "Round " + _roundCounter + " of " + _maxRounds;
            PlayerScoreButton.BackColor = Color.Empty;
            OponnentScoreButton.BackColor = Color.Empty;
            FillDecksWithCards(PlayerSet, OpponentSet);
            CurrentGameState.OppDeck = OpponentSet;
            CurrentGameState.PlayerDeck = PlayerSet;
            CurrentGameState.PlayerDic = PlayerRoundDictionary;
            CurrentGameState.OppDic = CPURoundDictionary;
            PlayerScoreButton.BackgroundImage = OponnentScoreButton.BackgroundImage = null;

        }
        //setup newgame
        public void NewGame()
        {
            
            CurrentGameState.roundNumber = _roundCounter = 0;
            CurrentGameState.playerScore = _playerScore = 10;
            CurrentGameState.oppScore = _opponentScore = 10;
            _cardAmount = 10 * _setAmount;
            PlayerScoreLabel.Text = "10";
            OponnentScoreLabel.Text = "10";
            RoundCounter.Text = "Round " + _roundCounter + " of " + _maxRounds;
            PlayerScoreButton.BackColor = Color.Empty;
            OponnentScoreButton.BackColor = Color.Empty;
            FillDecksWithCards(PlayerSet, OpponentSet);
            PlayerScoreButton.BackgroundImage = OponnentScoreButton.BackgroundImage = null;
            myTimer.Stop();
            StartAutoplayButton.Text = "Start";
            PlayerRoundDictionary.Clear();
            CPURoundDictionary.Clear();
            CurrentGameState.OppDeck = OpponentSet;
            CurrentGameState.PlayerDeck = PlayerSet;
            CurrentGameState.PlayerDic = PlayerRoundDictionary;
            CurrentGameState.OppDic = CPURoundDictionary;
        }
        //setup loadgame
        public void LoadGame(string playerName, string oppName, 
            int playerScore, int oppScore,int roundCounter, int maxRound, 
            Queue<int> playerSet, Queue<int> oppSet, List<int> deck, 
            Dictionary<double, double> playerDic, Dictionary<double, double> oppDic)
        {
            PlayerNameLabel.Text = playerName;
            OpponentName.Text = oppName;
            _playerScore = playerScore;
            _opponentScore = oppScore;
            _roundCounter = roundCounter;
            _maxRounds = maxRound;
            PlayerSet = playerSet;
            OpponentSet = oppSet;
            GameDeck = deck;
            PlayerRoundDictionary.Clear();
            CPURoundDictionary.Clear();
            PlayerRoundDictionary = playerDic;
            CPURoundDictionary = oppDic;

            PlayerScoreButton.BackgroundImage = OponnentScoreButton.BackgroundImage = null;
            PlayerScoreButton.BackColor = Color.Empty;
            OponnentScoreButton.BackColor = Color.Empty;
            PlayerScoreLabel.Text = playerScore.ToString();
            OponnentScoreLabel.Text = oppScore.ToString();
            RoundCounter.Text = "Round " + roundCounter + " of " + maxRound;
        }
        //menaging Autoplay
        private void Autoplay()
        {
            StartAutoplay();

            if (_roundCounter > _maxRounds)
            {
                myTimer.Stop();
            }
            //Game fibished with one of players run out of cards
            else if (PlayerSet.Count == 0 || OpponentSet.Count == 0)
            {
                myTimer.Stop();
            }
        }
        //when function is called, starting autoplay
        private void StartAutoplay()
        {
            myTimer.Tick += TimerEventProcessor;

            //min walrtosc trackbara 1 max 100, ja na max chce miec 10 na min 100 
            myTimer.Interval = (trackBar1.Maximum - trackBar1.Value )* 10 + 1;
            myTimer.Start();
        }

        private void TimerEventProcessor(Object o, EventArgs e)
        {
            if (_roundCounter > _maxRounds || PlayerSet.Count == 0 || OpponentSet.Count == 0 || _stopAutoplay)
                return;
            PlayerButton.PerformClick();
        }
        //setup new _maxRound based on input
        public int setLastRound()
        {
            if(LastRoundTextbox.Text != "")
                return _maxRounds = int.Parse(LastRoundTextbox.Text);
            return _maxRounds;
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
            }
        }
        //player won round
        private void PlayerWonRound(int playerScore, int _cpuScore)
        {
            CurrentGameState.playerScore = _playerScore += 1;
            CurrentGameState.oppScore = _opponentScore -= 1;
            PlayerScoreButton.BackColor = Color.Green;
            OponnentScoreButton.BackColor = Color.Red;
            PlayerSet.Enqueue(playerScore);
            PlayerSet.Enqueue(_cpuScore);
            CurrentGameState.PlayerDeck.Enqueue(playerScore);
            CurrentGameState.PlayerDeck.Enqueue(_cpuScore);
        }
        //cpu won round
        private void CpuWonRound(int playerScore, int _cpuScore)
        {
            CurrentGameState.oppScore = _opponentScore += 1;
            CurrentGameState.playerScore = _playerScore -= 1;
            PlayerScoreButton.BackColor = Color.Red;
            OponnentScoreButton.BackColor = Color.Green;
            OpponentSet.Enqueue(playerScore);
            OpponentSet.Enqueue(_cpuScore);
            CurrentGameState.OppDeck.Enqueue(playerScore);
            CurrentGameState.OppDeck.Enqueue(_cpuScore);
        }
        //tie situation solution
        private void Tie()
        {
            CurrentGameState.roundNumber = _roundCounter -= 1;
            PlayerSet.Dequeue();
            CurrentGameState.PlayerDeck.Dequeue();
            OpponentSet.Dequeue();
            CurrentGameState.OppDeck.Dequeue();
            PlayerScoreButton.BackgroundImage = PlayerButton.BackgroundImage;
            OponnentScoreButton.BackgroundImage = PlayerButton.BackgroundImage;
        }
        //set right png to given value
        private void SetNumberPicture(Button button, int index)
        {
            Rectangle section = new Rectangle(100 * (index - 1), 0, 100, 147);

            Bitmap src = Resources.numerki1;
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
            NewGame();
        }
        //game logic
        public void GameEngine(Queue<int> playerDeck, Queue<int>cpuDeck)
        {
            //get player number out of queue
            int playerScoreValue = playerDeck.Dequeue();
            //set right png
            SetNumberPicture(PlayerScoreButton, playerScoreValue);
            //place round and score in player dictionary
            PlayerRoundDictionary.Add(_roundCounter,_playerScore);
            //get cpu number out of queue
            int OponnentScoreValue = cpuDeck.Dequeue();
            //set right png
            SetNumberPicture(OponnentScoreButton, OponnentScoreValue);
            //to samo co wyzej ze slownikiem
            CPURoundDictionary.Add(_roundCounter, _opponentScore);
            //player has bigger number
            if (playerScoreValue > OponnentScoreValue)
            {
                PlayerWonRound(playerScoreValue, OponnentScoreValue);
            }
            //Opp has bigger number
            else if (playerScoreValue < OponnentScoreValue)
            {
                CpuWonRound(playerScoreValue, OponnentScoreValue);
            }
            //Tie
            else if(playerScoreValue == OponnentScoreValue)
            {
                Tie();
            }
            //Game finished by number of Rounds or one of player run out of cards
            if (_roundCounter == _maxRounds|| PlayerSet.Count == 0 || OpponentSet.Count == 0)
            {
                PlayerScoreButton.BackgroundImage = OponnentScoreButton.BackgroundImage = null;
                PlayerScoreButton.BackColor = OponnentScoreButton.BackColor = Color.Empty;
                bool isTie = false;
                if (_playerScore > _opponentScore)
                {
                    _playerWon = true;
                }
                if (_playerScore == _opponentScore)
                {
                    isTie = true;
                }

                string message = null;
                if (isTie)
                {
                    message = "It's a tie! Wanna see postgame statistic ?";
                }
                if (_playerWon)
                {
                    message = "You won! see postgame statistic ?";
                }
                else
                {
                    message = "You lost! see postgame statistic ?";
                }
                string caption = "The end";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(this, message, caption, buttons);


                if (result == DialogResult.Yes)
                {
                    var chart = new Form4(this);
                    chart.Show();
                }
                else
                {
                    DialogResult res = MessageBox.Show(this, "Wanna start a new game", "Restart?", buttons);

                    if (res == DialogResult.Yes)
                    {
                        NewGame();
                    }
                    else
                    {
                        var dialogResult = showCloseDialog();
                        if (dialogResult == DialogResult.OK)
                        {
                            myTimer.Tick -= TimerEventProcessor;
                            Application.Exit();
                        }
                    }
                }
            }
            CurrentGameState.roundNumber = _roundCounter += 1;
            RoundCounter.Text = "Round " + _roundCounter + " of " + _maxRounds;
            PlayerScoreLabel.Text = _playerScore.ToString();
            OponnentScoreLabel.Text = _opponentScore.ToString();
        }
        //player button behaviour
        private void PlayerController_Click(object sender, EventArgs e)
        {
            GameEngine(PlayerSet, OpponentSet);
        }
        private DialogResult showCloseDialog()
        {
            return MessageBox.Show("Close app?", "Closing", MessageBoxButtons.YesNo);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void OnClosing(Object sender, FormClosingEventArgs args)
        {
            var dialogResult = showCloseDialog();
            if (dialogResult == DialogResult.Yes)
            {
                myTimer.Tick -= TimerEventProcessor;
            }
            else
            {
                args.Cancel = true;
            }

        }
        //changing text of StartAutoplayButton on mouse click
        private void StartAutoplayButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (StartAutoplayButton.Text == "Start")
            {
                StartAutoplayButton.Text = "Stop";
                _stopAutoplay = false;
            }
            else
            {
                StartAutoplayButton.Text = "Start";
                _stopAutoplay = true;
            }
            DialogResult dr = StartAutoplayButton.DialogResult;
            if (dr == DialogResult.OK)
            {
                setLastRound();
                Autoplay();
            }
        }

        private void HighscoreButton_Click(object sender, EventArgs e)
        {
            Form3 highscores = new Form3();
            highscores.Show();
        }

        public class GameState
        {
            public int maxRounds;
            public int roundNumber;
            public int playerScore;
            public int oppScore;
            public string PlayerName;
            public string OppName;
            public Queue<int> PlayerDeck;
            public Queue<int> OppDeck;
            public List<int> Deck;
            public Dictionary<double, double> PlayerDic;
            public Dictionary<double, double> OppDic;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string gameStateJson = JsonConvert.SerializeObject(CurrentGameState);
            File.WriteAllText(Environment.CurrentDirectory + @"\gamestate.gs", gameStateJson);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string gameStateJson = File.ReadAllText(Environment.CurrentDirectory + @"\gamestate.gs");
            GameState loadedGameState = JsonConvert.DeserializeObject<GameState>(gameStateJson);
            LoadGameFromSave(loadedGameState);
        }
        private void LoadGameFromSave(GameState gameState)
        {
            LoadGame(gameState.PlayerName, gameState.OppName, gameState.playerScore, gameState.oppScore,
                gameState.roundNumber, gameState.maxRounds, gameState.PlayerDeck, gameState.OppDeck, gameState.Deck,
                gameState.PlayerDic, gameState.OppDic);
        }
    }
} 
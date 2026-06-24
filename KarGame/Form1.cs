using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using System.Windows.Forms;
using WMPLib;


namespace KarGame
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        private int MoveStep = 5;
        private Timer movementTimer = new Timer();
        private Keys currentKey;

        private int baseSpeed = 5;            // starting speed
        private int speedIncreases = 0;       // how many times speed was increased
        private int score = 0;                // player's score


        private int leftBoundary = 190;
        private int rightBoundary = 400;
        private int topBoundary = -5;
        private int bottomBoundary = 460;

        private int[] laneX = { 205, 255, 260, 300, 305, 310, 350, 355, 360 };
        private Random rnd = new Random();
        private List<int> activeLanes = new List<int>();

        private Panel splashPanel;
        private bool gameStarted = false; // Add this field

        public Form1()
        {
            InitializeComponent();
            
            player.URL = "meow.wav";
            this.KeyPreview = true;
            this.ActiveControl = null;
            pictureBox1.TabStop = false;

            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;

            movementTimer.Interval = 20;
            movementTimer.Tick += MovementTimer_Tick;

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
            player.settings.setMode("loop", true);
            // Create splash panel
            splashPanel = new Panel();
            splashPanel.Size = this.ClientSize;
            splashPanel.Location = new Point(0, 0);
            splashPanel.BackColor = Color.Black; // or whatever background you want
                                                 // Add splash controls to splash panel
            splashPanel.Controls.Add(startbuttonplay);
            splashPanel.Controls.Add(pictureBox5);
            
            // Add splash panel to form
            this.Controls.Add(splashPanel);
            splashPanel.BringToFront();
            // Show splash controls
            pictureBox5.Visible = true;
            startbuttonplay.Visible = true;
            // Hide game UI
            panel1.Visible = false;
            scoreLabel.Visible = false;
            timeScoreLabel.Visible = false;
            KarGame.Visible = false;
            // Hide cars until game starts
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!gameStarted) return; // Ignore key presses before start
            currentKey = e.KeyCode;
            movementTimer.Start();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!gameStarted) return;
            movementTimer.Stop();
        }

        private void MovementTimer_Tick(object sender, EventArgs e)
        {
            switch (currentKey)
            {
                case Keys.Left:
                    if (pictureBox1.Left - MoveStep >= leftBoundary)
                        pictureBox1.Left -= MoveStep;
                    break;

                case Keys.Right:
                    if (pictureBox1.Right + MoveStep <= rightBoundary)
                        pictureBox1.Left += MoveStep;
                    break;

                case Keys.Up:
                    if (pictureBox1.Top - MoveStep >= topBoundary)
                        pictureBox1.Top -= MoveStep;
                    break;

                case Keys.Down:
                    if (pictureBox1.Bottom + MoveStep <= bottomBoundary)
                        pictureBox1.Top += MoveStep;
                    break;
            }
        }

        private double elapsedTime = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!gameStarted) return; // Skip enemy movement before start

            elapsedTime += timer1.Interval / 1000.0;

            // Speed increase logic
            if (speedIncreases < 3 && elapsedTime >= (speedIncreases + 1) * 10)
            {
                baseSpeed += 5;
                speedIncreases++;
            }

            score = (int)elapsedTime;
            scoreLabel.Text = $"Score: {score}";
            timeScoreLabel.Text = $"Time: {elapsedTime:F1}s";

            activeLanes.Clear();
            MoveCar(pictureBox2);
            MoveCar(pictureBox3);
            MoveCar(pictureBox4);

            CheckCollision();
        }

        private void MoveCar(PictureBox car)
        {
            int speed = baseSpeed;

            car.Top += speed;

            // Respawn when off screen
            if (car.Top > this.ClientSize.Height)
            {
                // Only clear lanes when starting a new set
                if (activeLanes.Count >= 3) // number of enemy cars
                    activeLanes.Clear();

                car.Top = -car.Height;

                int lane;
                int attempts = 0;

                do
                {
                    lane = laneX[rnd.Next(laneX.Length)];
                    attempts++;
                }
                while (activeLanes.Contains(lane) && attempts < 10);

                activeLanes.Add(lane);
                car.Left = lane;
            }
        }

        //HAHAHAHAHAHAH I MADE THESE TEXTS HARSH, YOU CAN ALWAYS REPLACE THESE TEXTS HERE BELOW THO NGL FRFR

        private Random rand = new Random();
        private string[] gameOverTexts =
        {
            "Such Skill Issue",
            "How pitiful...\nTry again!",
            "HAHAHAAH",
            "WEAK!\nWomp Womp",
            "Give me my...\ndeath insurance",
            "Rest now player,\nyour time is over.",
            "Please get a...\nDriver's Lisence",
            "Running away from...\nJ*b Application?",
            "Haha you're noob",
            "The immeasurable\nskill of issue",
            "GEEEET OOUUUT!",
            "as expected,\na disgrace",
            "Full of disappointments",
            "Bro think he's\nWally West",
            "Give up, a mistake\nIS A MISTAKE!",
            "after crashing, you felt\nNo GUILTY?",
            "You caused the life of others\nhave some shame!",
            "You subtracted a number from\n world's population",
            "You think this kind of\nmistake is little?",
            "You are now verdicted\nvia death sentence",
            "You might've kill a happy family\nfrom that measly mistake",
            "The victim asks for\nyour entire life savings",
            "A literal failure",
            "THE IGNORANCE OF THE\nLAW EXCUSES NO ONE",
            "Bruh, really?\nonly that far?"
        };

        private void CheckCollision()
        {
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                timer1.Stop();
                movementTimer.Stop();
                player.controls.stop();

                this.KeyDown -= Form1_KeyDown;
                this.KeyUp -= Form1_KeyUp;

                // Random game over text
                string randomText = gameOverTexts[rand.Next(gameOverTexts.Length)];

                // Loss time
                string lossTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // Update existing label
                lblGameOver.Text = "Car Game";
                lblGameeOver.Text = "Game Over";
                lblMessageBox.Text = $"{randomText}";
                lblScore.Text = $"Your Score: {score}";
                lblDuration.Text = $"Duration: {elapsedTime:F1}s";
                lblTimeAndDate.Text = $"Lost at: {lossTime}";




                // Show retry panel

                lblGameOver.Visible = true;
                lblGameOver.BringToFront();

                lblGameeOver.Visible = true;
                lblGameeOver.BringToFront();

                lblScore.Visible = true;
                lblScore.BringToFront();

                lblDuration.Visible = true;
                lblDuration.BringToFront();

                lblTimeAndDate.Visible = true;
                lblTimeAndDate.BringToFront();

                lblMessageBox.Visible = true;
                lblMessageBox.BringToFront();



                btnRetry.Visible = true;
                btnRetry.BringToFront();

                retryPanel.Visible = true;
                retryPanel.BringToFront();
            }
        }

        // Designer retry button click event
        private void btnRetry_Click(object sender, EventArgs e)
        {
            retryPanel.Visible = false;
            player.controls.play();
            RestartGame();
        }

        private void RestartGame()
        {
            elapsedTime = 0;
            score = 0;
            baseSpeed = 5;
            speedIncreases = 0;
            timeScoreLabel.Text = "Time: 0s";
            scoreLabel.Text = "Score: 0";

            int startX = laneX[rnd.Next(laneX.Length)];
            SetPlayerCarPosition(startX, 380);
            ResetEnemiesOffScreen();

            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;

            timer1.Start();
            movementTimer.Stop();
        }

        private void ResetEnemyPositionsOffScreen()
        {
            // Push enemies off-screen at different heights
            pictureBox2.Top = -pictureBox2.Height - rnd.Next(100, 300);
            pictureBox3.Top = -pictureBox3.Height - rnd.Next(300, 500);
            pictureBox4.Top = -pictureBox4.Height - rnd.Next(500, 700);

            // Randomize their lanes so they don't stack
            PictureBox[] enemies = { pictureBox2, pictureBox3, pictureBox4 };
            activeLanes.Clear();
            foreach (var car in enemies)
            {
                int lane;
                int attempts = 0;
                do
                {
                    lane = laneX[rnd.Next(laneX.Length)];
                    attempts++;
                }
                while (activeLanes.Contains(lane) && attempts < 10);

                activeLanes.Add(lane);
                car.Left = lane;
            }
        }
        private void RandomizePlayerStart()
        {
             // Pick a random lane for the player
             int startX = laneX[rnd.Next(laneX.Length)];

             // Fixed Y position near the bottom of the screen
             pictureBox1.Location = new Point(startX, this.ClientSize.Height - pictureBox1.Height - 20);
        }

        private void ResetEnemiesOffScreen()
        {
            pictureBox2.Top = -pictureBox2.Height - 100;
            pictureBox3.Top = -pictureBox3.Height - 200;
            pictureBox4.Top = -pictureBox4.Height - 300;
        }

        private void SetPlayerCarPosition(int x, int y)
        {
            pictureBox1.Location = new Point(x, y);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (System.Drawing.Drawing2D.LinearGradientBrush brush =
                   new System.Drawing.Drawing2D.LinearGradientBrush(
                       panel1.ClientRectangle,
                       Color.LightPink,      // sa taas ni para di libog
                       Color.Honeydew,    // kani ubos
                       System.Drawing.Drawing2D.LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
            }

            // Shadow sa time
            e.Graphics.DrawString(timeScoreLabel.Text, timeScoreLabel.Font,
                Brushes.Black, new PointF(timeScoreLabel.Left + 1, timeScoreLabel.Top + 1));

            // Main text
            e.Graphics.DrawString(timeScoreLabel.Text, timeScoreLabel.Font,
                new SolidBrush(Color.FromArgb(102, 0, 51)),
                new PointF(timeScoreLabel.Left, timeScoreLabel.Top));

            // Shadow sa score
            e.Graphics.DrawString(scoreLabel.Text, scoreLabel.Font,
                Brushes.Black, new PointF(scoreLabel.Left + 1, scoreLabel.Top + 1));

            // Main text
            e.Graphics.DrawString(scoreLabel.Text, scoreLabel.Font,
                new SolidBrush(Color.FromArgb(102, 0, 51)),
                new PointF(scoreLabel.Left, scoreLabel.Top));

            // Shadow sa car game nga text
            e.Graphics.DrawString(KarGame.Text, KarGame.Font,
                Brushes.Black, new PointF(KarGame.Left + 1, KarGame.Top + 1));

            // Main text
            e.Graphics.DrawString(KarGame.Text, KarGame.Font,
                new SolidBrush(Color.FromArgb(102, 0, 51)),
                new PointF(KarGame.Left, KarGame.Top));
        }

        private void retryPanel_Paint(object sender, PaintEventArgs e)
        {
            using (System.Drawing.Drawing2D.LinearGradientBrush brush =
                   new System.Drawing.Drawing2D.LinearGradientBrush(
                       panel1.ClientRectangle,
                       Color.LavenderBlush,      // sa taas ni para di libog
                       Color.LightPink,    // kani ubos
                       System.Drawing.Drawing2D.LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
            }
        }

        private void startbuttonplay_Click(object sender, EventArgs e)
        {
            splashPanel.Visible = false;

            panel1.Visible = true;
            scoreLabel.Visible = true;
            timeScoreLabel.Visible = true;
            KarGame.Visible = true;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;

            FixZOrder();

            gameStarted = true;
            timer1.Start();
        }

        private void FixZOrder()
        {
            // Panel should be the road background
            panel1.BringToFront();

            // Then draw labels above panel
            scoreLabel.BringToFront();
            timeScoreLabel.BringToFront();
            KarGame.BringToFront();

            // Enemies BELOW panel and text
            pictureBox2.SendToBack();
            pictureBox3.SendToBack();
            pictureBox4.SendToBack();

            // Player above enemies but still below the UI
            pictureBox1.BringToFront();
        }
    }
}
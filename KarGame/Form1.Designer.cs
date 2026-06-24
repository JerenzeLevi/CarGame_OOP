namespace KarGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeScoreLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KarGame = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.retryPanel = new System.Windows.Forms.Panel();
            this.startbuttonplay = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblTimeAndDate = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.lblGameeOver = new System.Windows.Forms.Label();
            this.btnRetry = new System.Windows.Forms.Button();
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.retryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::KarGame.Properties.Resources.urkarr1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::KarGame.Properties.Resources.urkarr;
            this.pictureBox1.Location = new System.Drawing.Point(411, 468);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 76);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::KarGame.Properties.Resources.enemykarr1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(340, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 84);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::KarGame.Properties.Resources.enemykarr1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(273, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 84);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::KarGame.Properties.Resources.enemykarr1;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(477, 248);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 84);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeScoreLabel
            // 
            this.timeScoreLabel.AutoSize = true;
            this.timeScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeScoreLabel.Font = new System.Drawing.Font("Modern No. 20", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeScoreLabel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.timeScoreLabel.Location = new System.Drawing.Point(312, 34);
            this.timeScoreLabel.Name = "timeScoreLabel";
            this.timeScoreLabel.Size = new System.Drawing.Size(174, 45);
            this.timeScoreLabel.TabIndex = 4;
            this.timeScoreLabel.Text = "Time: 0s";
            this.timeScoreLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.KarGame);
            this.panel1.Controls.Add(this.scoreLabel);
            this.panel1.Controls.Add(this.timeScoreLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.panel1.Location = new System.Drawing.Point(0, 563);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 99);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // KarGame
            // 
            this.KarGame.AutoSize = true;
            this.KarGame.BackColor = System.Drawing.Color.Transparent;
            this.KarGame.Font = new System.Drawing.Font("Modern No. 20", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KarGame.ForeColor = System.Drawing.Color.Crimson;
            this.KarGame.Location = new System.Drawing.Point(12, 34);
            this.KarGame.Name = "KarGame";
            this.KarGame.Size = new System.Drawing.Size(199, 45);
            this.KarGame.TabIndex = 6;
            this.KarGame.Text = "Car Game";
            this.KarGame.Visible = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Modern No. 20", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.scoreLabel.Location = new System.Drawing.Point(593, 34);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(162, 45);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "Score: 0";
            this.scoreLabel.Visible = false;
            // 
            // retryPanel
            // 
            this.retryPanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.retryPanel.Controls.Add(this.startbuttonplay);
            this.retryPanel.Controls.Add(this.pictureBox5);
            this.retryPanel.Controls.Add(this.lblTimeAndDate);
            this.retryPanel.Controls.Add(this.lblScore);
            this.retryPanel.Controls.Add(this.lblDuration);
            this.retryPanel.Controls.Add(this.lblMessageBox);
            this.retryPanel.Controls.Add(this.lblGameeOver);
            this.retryPanel.Controls.Add(this.btnRetry);
            this.retryPanel.Controls.Add(this.lblGameOver);
            this.retryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.retryPanel.Location = new System.Drawing.Point(0, 0);
            this.retryPanel.Name = "retryPanel";
            this.retryPanel.Size = new System.Drawing.Size(782, 563);
            this.retryPanel.TabIndex = 6;
            this.retryPanel.Visible = false;
            this.retryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.retryPanel_Paint);
            // 
            // startbuttonplay
            // 
            this.startbuttonplay.BackColor = System.Drawing.Color.LightPink;
            this.startbuttonplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startbuttonplay.Font = new System.Drawing.Font("Sitka Banner", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbuttonplay.ForeColor = System.Drawing.Color.Black;
            this.startbuttonplay.Location = new System.Drawing.Point(145, 305);
            this.startbuttonplay.Name = "startbuttonplay";
            this.startbuttonplay.Size = new System.Drawing.Size(479, 157);
            this.startbuttonplay.TabIndex = 8;
            this.startbuttonplay.Text = "PLAY";
            this.startbuttonplay.UseVisualStyleBackColor = false;
            this.startbuttonplay.Click += new System.EventHandler(this.startbuttonplay_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.ErrorImage")));
            this.pictureBox5.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(806, 660);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // lblTimeAndDate
            // 
            this.lblTimeAndDate.AutoSize = true;
            this.lblTimeAndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeAndDate.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeAndDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTimeAndDate.Location = new System.Drawing.Point(199, 513);
            this.lblTimeAndDate.Name = "lblTimeAndDate";
            this.lblTimeAndDate.Size = new System.Drawing.Size(206, 31);
            this.lblTimeAndDate.TabIndex = 6;
            this.lblTimeAndDate.Text = "Time and Date";
            this.lblTimeAndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimeAndDate.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Modern No. 20", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblScore.Location = new System.Drawing.Point(170, 247);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(201, 40);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Your score:";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScore.Visible = false;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblDuration.Font = new System.Drawing.Font("Modern No. 20", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDuration.Location = new System.Drawing.Point(199, 194);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(187, 40);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Duration: ";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDuration.Visible = false;
            // 
            // lblMessageBox
            // 
            this.lblMessageBox.AutoSize = true;
            this.lblMessageBox.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageBox.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageBox.ForeColor = System.Drawing.Color.Crimson;
            this.lblMessageBox.Location = new System.Drawing.Point(257, 301);
            this.lblMessageBox.Name = "lblMessageBox";
            this.lblMessageBox.Size = new System.Drawing.Size(190, 31);
            this.lblMessageBox.TabIndex = 3;
            this.lblMessageBox.Text = "Message Here";
            this.lblMessageBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessageBox.Visible = false;
            // 
            // lblGameeOver
            // 
            this.lblGameeOver.AutoSize = true;
            this.lblGameeOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameeOver.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameeOver.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblGameeOver.Location = new System.Drawing.Point(289, 137);
            this.lblGameeOver.Name = "lblGameeOver";
            this.lblGameeOver.Size = new System.Drawing.Size(203, 41);
            this.lblGameeOver.TabIndex = 2;
            this.lblGameeOver.Text = "Game Over";
            this.lblGameeOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameeOver.Visible = false;
            // 
            // btnRetry
            // 
            this.btnRetry.BackColor = System.Drawing.Color.LightPink;
            this.btnRetry.Font = new System.Drawing.Font("Rockwell Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetry.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRetry.Location = new System.Drawing.Point(246, 376);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(312, 114);
            this.btnRetry.TabIndex = 1;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Visible = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Crimson;
            this.lblGameOver.Location = new System.Drawing.Point(216, 24);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(359, 83);
            this.lblGameOver.TabIndex = 0;
            this.lblGameOver.Text = "Car Game";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGameOver.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KarGame.Properties.Resources.sakura;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 662);
            this.Controls.Add(this.retryPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 709);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 709);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.retryPanel.ResumeLayout(false);
            this.retryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeScoreLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel retryPanel;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Label KarGame;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label lblGameeOver;
        private System.Windows.Forms.Label lblTimeAndDate;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblMessageBox;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button startbuttonplay;
    }
}


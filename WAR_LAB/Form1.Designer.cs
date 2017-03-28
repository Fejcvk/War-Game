namespace WAR_LAB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HighscoreButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.OponnentButton = new System.Windows.Forms.Button();
            this.PlayerButton = new System.Windows.Forms.Button();
            this.OponnentScoreButton = new System.Windows.Forms.Button();
            this.PlayerScoreButton = new System.Windows.Forms.Button();
            this.OpponentName = new System.Windows.Forms.Label();
            this.PlayerScoreTag = new System.Windows.Forms.Label();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.RoundCounter = new System.Windows.Forms.Label();
            this.OpponentScoreTag = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.AutoPlayLabel = new System.Windows.Forms.Label();
            this.LastRoundLabel = new System.Windows.Forms.Label();
            this.LastRoundTextbox = new System.Windows.Forms.TextBox();
            this.StartAutoplayButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PlayerScoreLabel = new System.Windows.Forms.Label();
            this.OponnentScoreLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.HighscoreButton,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(874, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(42, 22);
            this.toolStripDropDownButton1.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // HighscoreButton
            // 
            this.HighscoreButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HighscoreButton.Image = ((System.Drawing.Image)(resources.GetObject("HighscoreButton.Image")));
            this.HighscoreButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HighscoreButton.Name = "HighscoreButton";
            this.HighscoreButton.Size = new System.Drawing.Size(70, 22);
            this.HighscoreButton.Text = "Highscores";
            this.HighscoreButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HighscoreButton.Click += new System.EventHandler(this.HighscoreButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton1.Text = "About";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // OponnentButton
            // 
            this.OponnentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OponnentButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OponnentButton.BackgroundImage")));
            this.OponnentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OponnentButton.Location = new System.Drawing.Point(3, 3);
            this.OponnentButton.Name = "OponnentButton";
            this.OponnentButton.Size = new System.Drawing.Size(192, 138);
            this.OponnentButton.TabIndex = 1;
            this.OponnentButton.UseVisualStyleBackColor = true;
            // 
            // PlayerButton
            // 
            this.PlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayerButton.BackgroundImage")));
            this.PlayerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerButton.Location = new System.Drawing.Point(679, 261);
            this.PlayerButton.Name = "PlayerButton";
            this.PlayerButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlayerButton.Size = new System.Drawing.Size(192, 126);
            this.PlayerButton.TabIndex = 2;
            this.PlayerButton.UseVisualStyleBackColor = true;
            this.PlayerButton.Click += new System.EventHandler(this.PlayerController_Click);
            // 
            // OponnentScoreButton
            // 
            this.OponnentScoreButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OponnentScoreButton.Location = new System.Drawing.Point(326, 3);
            this.OponnentScoreButton.Name = "OponnentScoreButton";
            this.OponnentScoreButton.Size = new System.Drawing.Size(231, 138);
            this.OponnentScoreButton.TabIndex = 3;
            this.OponnentScoreButton.UseVisualStyleBackColor = true;
            // 
            // PlayerScoreButton
            // 
            this.PlayerScoreButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PlayerScoreButton.Location = new System.Drawing.Point(331, 261);
            this.PlayerScoreButton.Name = "PlayerScoreButton";
            this.PlayerScoreButton.Size = new System.Drawing.Size(221, 126);
            this.PlayerScoreButton.TabIndex = 4;
            this.PlayerScoreButton.UseVisualStyleBackColor = true;
            // 
            // OpponentName
            // 
            this.OpponentName.AutoSize = true;
            this.OpponentName.Location = new System.Drawing.Point(3, 144);
            this.OpponentName.Name = "OpponentName";
            this.OpponentName.Size = new System.Drawing.Size(29, 13);
            this.OpponentName.TabIndex = 5;
            this.OpponentName.Text = "CPU";
            // 
            // PlayerScoreTag
            // 
            this.PlayerScoreTag.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PlayerScoreTag.AutoSize = true;
            this.PlayerScoreTag.Location = new System.Drawing.Point(130, 317);
            this.PlayerScoreTag.Name = "PlayerScoreTag";
            this.PlayerScoreTag.Size = new System.Drawing.Size(65, 13);
            this.PlayerScoreTag.TabIndex = 7;
            this.PlayerScoreTag.Text = "Player score";
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Location = new System.Drawing.Point(835, 245);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(36, 13);
            this.PlayerNameLabel.TabIndex = 8;
            this.PlayerNameLabel.Text = "Player";
            // 
            // RoundCounter
            // 
            this.RoundCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoundCounter.AutoSize = true;
            this.RoundCounter.Location = new System.Drawing.Point(390, 194);
            this.RoundCounter.Name = "RoundCounter";
            this.RoundCounter.Size = new System.Drawing.Size(103, 13);
            this.RoundCounter.TabIndex = 9;
            this.RoundCounter.Text = "Number of rounds: 0";
            // 
            // OpponentScoreTag
            // 
            this.OpponentScoreTag.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OpponentScoreTag.AutoSize = true;
            this.OpponentScoreTag.Location = new System.Drawing.Point(615, 65);
            this.OpponentScoreTag.Name = "OpponentScoreTag";
            this.OpponentScoreTag.Size = new System.Drawing.Size(58, 13);
            this.OpponentScoreTag.TabIndex = 10;
            this.OpponentScoreTag.Text = "CPU score";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.Location = new System.Drawing.Point(-5, 14);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(871, 45);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Value = 1;
            // 
            // AutoPlayLabel
            // 
            this.AutoPlayLabel.AutoSize = true;
            this.AutoPlayLabel.Location = new System.Drawing.Point(66, 70);
            this.AutoPlayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AutoPlayLabel.Name = "AutoPlayLabel";
            this.AutoPlayLabel.Size = new System.Drawing.Size(89, 13);
            this.AutoPlayLabel.TabIndex = 13;
            this.AutoPlayLabel.Text = "Autoplay Settings";
            // 
            // LastRoundLabel
            // 
            this.LastRoundLabel.AutoSize = true;
            this.LastRoundLabel.Location = new System.Drawing.Point(308, 70);
            this.LastRoundLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastRoundLabel.Name = "LastRoundLabel";
            this.LastRoundLabel.Size = new System.Drawing.Size(62, 13);
            this.LastRoundLabel.TabIndex = 14;
            this.LastRoundLabel.Text = "Last Round";
            // 
            // LastRoundTextbox
            // 
            this.LastRoundTextbox.Location = new System.Drawing.Point(386, 63);
            this.LastRoundTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.LastRoundTextbox.Name = "LastRoundTextbox";
            this.LastRoundTextbox.Size = new System.Drawing.Size(121, 20);
            this.LastRoundTextbox.TabIndex = 15;
            // 
            // StartAutoplayButton
            // 
            this.StartAutoplayButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.StartAutoplayButton.Location = new System.Drawing.Point(735, 66);
            this.StartAutoplayButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartAutoplayButton.Name = "StartAutoplayButton";
            this.StartAutoplayButton.Size = new System.Drawing.Size(63, 21);
            this.StartAutoplayButton.TabIndex = 16;
            this.StartAutoplayButton.Text = "Start";
            this.StartAutoplayButton.UseVisualStyleBackColor = true;
            this.StartAutoplayButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartAutoplayButton_MouseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PlayerButton, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.RoundCounter, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.PlayerScoreTag, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.OponnentButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OpponentName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PlayerNameLabel, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.OpponentScoreTag, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.OponnentScoreLabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.PlayerScoreLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PlayerScoreButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.OponnentScoreButton, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(874, 390);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // PlayerScoreLabel
            // 
            this.PlayerScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PlayerScoreLabel.AutoSize = true;
            this.PlayerScoreLabel.Location = new System.Drawing.Point(201, 317);
            this.PlayerScoreLabel.Name = "PlayerScoreLabel";
            this.PlayerScoreLabel.Size = new System.Drawing.Size(13, 13);
            this.PlayerScoreLabel.TabIndex = 10;
            this.PlayerScoreLabel.Text = "0";
            // 
            // OponnentScoreLabel
            // 
            this.OponnentScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OponnentScoreLabel.AutoSize = true;
            this.OponnentScoreLabel.Location = new System.Drawing.Point(679, 65);
            this.OponnentScoreLabel.Name = "OponnentScoreLabel";
            this.OponnentScoreLabel.Size = new System.Drawing.Size(13, 13);
            this.OponnentScoreLabel.TabIndex = 11;
            this.OponnentScoreLabel.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.LastRoundLabel);
            this.panel1.Controls.Add(this.AutoPlayLabel);
            this.panel1.Controls.Add(this.StartAutoplayButton);
            this.panel1.Controls.Add(this.LastRoundTextbox);
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 111);
            this.panel1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(874, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimumSize = new System.Drawing.Size(805, 525);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button OponnentButton;
        private System.Windows.Forms.Button PlayerButton;
        private System.Windows.Forms.Button OponnentScoreButton;
        private System.Windows.Forms.Button PlayerScoreButton;
        private System.Windows.Forms.Label OpponentName;
        private System.Windows.Forms.Label PlayerScoreTag;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.Label RoundCounter;
        private System.Windows.Forms.Label OpponentScoreTag;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton HighscoreButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label AutoPlayLabel;
        private System.Windows.Forms.Label LastRoundLabel;
        private System.Windows.Forms.TextBox LastRoundTextbox;
        private System.Windows.Forms.Button StartAutoplayButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label OponnentScoreLabel;
        private System.Windows.Forms.Label PlayerScoreLabel;
        private System.Windows.Forms.Panel panel1;
    }
}


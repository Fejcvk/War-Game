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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.OponnentButton = new System.Windows.Forms.Button();
            this.PlayerButton = new System.Windows.Forms.Button();
            this.OponnentScoreButton = new System.Windows.Forms.Button();
            this.PlayerScoreButton = new System.Windows.Forms.Button();
            this.OpponentName = new System.Windows.Forms.Label();
            this.PlayerScoreLabel = new System.Windows.Forms.Label();
            this.PlayerScoreTag = new System.Windows.Forms.Label();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.RoundCounter = new System.Windows.Forms.Label();
            this.OpponentScoreTag = new System.Windows.Forms.Label();
            this.OponnentScoreLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1178, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 29);
            this.toolStripDropDownButton1.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(66, 29);
            this.toolStripButton1.Text = "About";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // OponnentButton
            // 
            this.OponnentButton.Location = new System.Drawing.Point(18, 134);
            this.OponnentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OponnentButton.Name = "OponnentButton";
            this.OponnentButton.Size = new System.Drawing.Size(288, 165);
            this.OponnentButton.TabIndex = 1;
            this.OponnentButton.Text = "button1";
            this.OponnentButton.UseVisualStyleBackColor = true;
            // 
            // PlayerButton
            // 
            this.PlayerButton.Location = new System.Drawing.Point(872, 451);
            this.PlayerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayerButton.Name = "PlayerButton";
            this.PlayerButton.Size = new System.Drawing.Size(288, 165);
            this.PlayerButton.TabIndex = 2;
            this.PlayerButton.Text = "button2";
            this.PlayerButton.UseVisualStyleBackColor = true;
            this.PlayerButton.Click += new System.EventHandler(this.PlayerController_Click);
            // 
            // OponnentScoreButton
            // 
            this.OponnentScoreButton.Location = new System.Drawing.Point(458, 134);
            this.OponnentScoreButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OponnentScoreButton.Name = "OponnentScoreButton";
            this.OponnentScoreButton.Size = new System.Drawing.Size(288, 165);
            this.OponnentScoreButton.TabIndex = 3;
            this.OponnentScoreButton.UseVisualStyleBackColor = true;
            // 
            // PlayerScoreButton
            // 
            this.PlayerScoreButton.Location = new System.Drawing.Point(458, 451);
            this.PlayerScoreButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayerScoreButton.Name = "PlayerScoreButton";
            this.PlayerScoreButton.Size = new System.Drawing.Size(288, 165);
            this.PlayerScoreButton.TabIndex = 4;
            this.PlayerScoreButton.UseVisualStyleBackColor = true;
            // 
            // OpponentName
            // 
            this.OpponentName.AutoSize = true;
            this.OpponentName.Location = new System.Drawing.Point(18, 91);
            this.OpponentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OpponentName.Name = "OpponentName";
            this.OpponentName.Size = new System.Drawing.Size(0, 20);
            this.OpponentName.TabIndex = 5;
            // 
            // PlayerScoreLabel
            // 
            this.PlayerScoreLabel.AutoSize = true;
            this.PlayerScoreLabel.Location = new System.Drawing.Point(117, 523);
            this.PlayerScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerScoreLabel.Name = "PlayerScoreLabel";
            this.PlayerScoreLabel.Size = new System.Drawing.Size(18, 20);
            this.PlayerScoreLabel.TabIndex = 6;
            this.PlayerScoreLabel.Text = "0";
            // 
            // PlayerScoreTag
            // 
            this.PlayerScoreTag.AutoSize = true;
            this.PlayerScoreTag.Location = new System.Drawing.Point(254, 523);
            this.PlayerScoreTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerScoreTag.Name = "PlayerScoreTag";
            this.PlayerScoreTag.Size = new System.Drawing.Size(0, 20);
            this.PlayerScoreTag.TabIndex = 7;
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Location = new System.Drawing.Point(1107, 669);
            this.PlayerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(0, 20);
            this.PlayerNameLabel.TabIndex = 8;
            // 
            // RoundCounter
            // 
            this.RoundCounter.AutoSize = true;
            this.RoundCounter.Location = new System.Drawing.Point(522, 375);
            this.RoundCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoundCounter.Name = "RoundCounter";
            this.RoundCounter.Size = new System.Drawing.Size(153, 20);
            this.RoundCounter.TabIndex = 9;
            this.RoundCounter.Text = "Number of rounds: 0";
            // 
            // OpponentScoreTag
            // 
            this.OpponentScoreTag.AutoSize = true;
            this.OpponentScoreTag.Location = new System.Drawing.Point(867, 206);
            this.OpponentScoreTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OpponentScoreTag.Name = "OpponentScoreTag";
            this.OpponentScoreTag.Size = new System.Drawing.Size(0, 20);
            this.OpponentScoreTag.TabIndex = 10;
            // 
            // OponnentScoreLabel
            // 
            this.OponnentScoreLabel.AutoSize = true;
            this.OponnentScoreLabel.Location = new System.Drawing.Point(988, 206);
            this.OponnentScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OponnentScoreLabel.Name = "OponnentScoreLabel";
            this.OponnentScoreLabel.Size = new System.Drawing.Size(18, 20);
            this.OponnentScoreLabel.TabIndex = 11;
            this.OponnentScoreLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 728);
            this.Controls.Add(this.OponnentScoreLabel);
            this.Controls.Add(this.OpponentScoreTag);
            this.Controls.Add(this.RoundCounter);
            this.Controls.Add(this.PlayerNameLabel);
            this.Controls.Add(this.PlayerScoreTag);
            this.Controls.Add(this.PlayerScoreLabel);
            this.Controls.Add(this.OpponentName);
            this.Controls.Add(this.PlayerScoreButton);
            this.Controls.Add(this.OponnentScoreButton);
            this.Controls.Add(this.PlayerButton);
            this.Controls.Add(this.OponnentButton);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Label PlayerScoreLabel;
        private System.Windows.Forms.Label PlayerScoreTag;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.Label RoundCounter;
        private System.Windows.Forms.Label OpponentScoreTag;
        private System.Windows.Forms.Label OponnentScoreLabel;
    }
}


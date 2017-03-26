using System.Windows.Forms;

namespace WAR_LAB
{
    partial class Form2
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
            this.PlayerNameTag = new System.Windows.Forms.Label();
            this.CpuNameTag = new System.Windows.Forms.Label();
            this.RoundTag = new System.Windows.Forms.Label();
            this.RoundBox = new System.Windows.Forms.TextBox();
            this.CpuBox = new System.Windows.Forms.TextBox();
            this.PlayerBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerNameTag
            // 
            this.PlayerNameTag.AutoSize = true;
            this.PlayerNameTag.Location = new System.Drawing.Point(32, 44);
            this.PlayerNameTag.Name = "PlayerNameTag";
            this.PlayerNameTag.Size = new System.Drawing.Size(98, 20);
            this.PlayerNameTag.TabIndex = 0;
            this.PlayerNameTag.Text = "Player Name";
            // 
            // CpuNameTag
            // 
            this.CpuNameTag.AutoSize = true;
            this.CpuNameTag.Location = new System.Drawing.Point(32, 87);
            this.CpuNameTag.Name = "CpuNameTag";
            this.CpuNameTag.Size = new System.Drawing.Size(88, 20);
            this.CpuNameTag.TabIndex = 1;
            this.CpuNameTag.Text = "CPU Name";
            // 
            // RoundTag
            // 
            this.RoundTag.AutoSize = true;
            this.RoundTag.Location = new System.Drawing.Point(32, 125);
            this.RoundTag.Name = "RoundTag";
            this.RoundTag.Size = new System.Drawing.Size(143, 20);
            this.RoundTag.TabIndex = 2;
            this.RoundTag.Text = "Number of Rounds";
            // 
            // RoundBox
            // 
            this.RoundBox.Location = new System.Drawing.Point(214, 119);
            this.RoundBox.Name = "RoundBox";
            this.RoundBox.Size = new System.Drawing.Size(288, 26);
            this.RoundBox.TabIndex = 3;
            // 
            // CpuBox
            // 
            this.CpuBox.Location = new System.Drawing.Point(214, 81);
            this.CpuBox.Name = "CpuBox";
            this.CpuBox.Size = new System.Drawing.Size(288, 26);
            this.CpuBox.TabIndex = 4;
            // 
            // PlayerBox
            // 
            this.PlayerBox.Location = new System.Drawing.Point(214, 38);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(288, 26);
            this.PlayerBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(414, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 229);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.CpuBox);
            this.Controls.Add(this.RoundBox);
            this.Controls.Add(this.RoundTag);
            this.Controls.Add(this.CpuNameTag);
            this.Controls.Add(this.PlayerNameTag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayerNameTag;
        private System.Windows.Forms.Label CpuNameTag;
        private System.Windows.Forms.Label RoundTag;
        private System.Windows.Forms.TextBox RoundBox;
        private System.Windows.Forms.TextBox CpuBox;
        private System.Windows.Forms.TextBox PlayerBox;
        public System.Windows.Forms.Button button1;
    }
}
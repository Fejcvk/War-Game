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
    public partial class Form2 : Form
    {
        bool _firstLaunch = true;
        public Form2()
        {
            InitializeComponent();
        }

        public string getPlayerName()
        {
            return PlayerBox.Text;
        }

        public string getOpponentName()
        {
            return CpuBox.Text;
        }

        public string getRounds()
        {
            return RoundBox.Text;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_firstLaunch)
            {
                base.OnFormClosing(e);

                if (e.CloseReason == CloseReason.WindowsShutDown) return;

                // Confirm user wants to close
                DialogResult result = MessageBox.Show(this, "Are you sure you want to close?", "Close", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.ExitThread();
                }

            }
            _firstLaunch = false;
        }
    }
}

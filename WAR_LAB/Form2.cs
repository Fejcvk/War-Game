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

        public Form2()
        {
            InitializeComponent();
            FormClosing += new FormClosingEventHandler(OnClosing);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private DialogResult showCloseDialog()
        {
            return MessageBox.Show("Close app?", "Closing", MessageBoxButtons.YesNo);
        }
        private void OnClosing(Object sender, FormClosingEventArgs args)
        {
            ;
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

        public int getSets()
        {
            return int.Parse(SetBox.Text);
        }
    }
}

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
    public partial class Form4 : Form
    {
        private Form context;
        public Form4(Form context)
        {
            this.context = context;
            this.Owner = context;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
            DrawChart();
            FormClosing += new FormClosingEventHandler(OnClosing);
        }
        private void OnClosing(Object sender, FormClosingEventArgs args)
        {
            var dialogResult = showPlayAgainDialog();
            if (dialogResult == DialogResult.Yes)
            {
                (context as Form1).NewGame();
            }
        }

        private void DrawChart()
        {
            foreach (KeyValuePair<double, double> kvp in (context as Form1).PlayerRoundDictionary)
            {
                chart1.Series["Player Score"].Points.AddXY(kvp.Key, kvp.Value);
            }
            foreach (KeyValuePair<double, double> kvp in (context as Form1).CPURoundDictionary)
            {
                chart1.Series["CPU Score"].Points.AddXY(kvp.Key, kvp.Value);
            }
        }

        private DialogResult showCloseDialog()
        {
            return MessageBox.Show("Close app?", "Closing", MessageBoxButtons.YesNo);
        }

        private DialogResult showPlayAgainDialog()
        {
            return MessageBox.Show("Play again?", "Again", MessageBoxButtons.YesNo);
        }
    }
}

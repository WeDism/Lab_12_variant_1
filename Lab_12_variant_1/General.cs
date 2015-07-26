//#define VAR
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_12_variant_1
{
    partial class General : PerentForm
    {
        public event FormClosingEventHandler EH;
        public General()
        {
            InitializeComponent();
            MessageBox.Show("This is program create for\n\tmedium - 125%\n\tsystem text", "Warning!");
            EH = new FormClosingEventHandler(General_FormClosing);
            this.FormClosing += EH;
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Input().ShowDialog();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Calc().ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if !VAR
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("\tPush: ok or cancel", "Exit", buttons);
            if (result == DialogResult.Yes)
            {
                this.FormClosing -= EH;
                Application.Exit();
            }
#endif
#if VAR
            Application.Exit();
#endif
        }

        private void General_FormClosing(object sender, FormClosingEventArgs e)
        {
#if !VAR
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("\tPush: Ok or Cancel", "Exit", buttons);
            if (result == DialogResult.No) e.Cancel = true;
#endif
        }
    }
}

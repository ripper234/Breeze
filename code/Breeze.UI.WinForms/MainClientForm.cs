using System;
using System.Windows.Forms;

namespace Breeze.UI.WinForms
{
    public partial class MainClientForm : Form
    {
        public MainClientForm()
        {
            InitializeComponent();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new ConnectControl());
        }

        private void connectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new ConnectedController());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfEmpires0
{
    public partial class EndingScreenForm : Form
    {
        public EndingScreenForm(string message)
        {
            
            InitializeComponent();
            messageLabel.Text = message;
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            Hide();
            new GameForm().ShowDialog();
            Close();
        }
    }
}

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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Włącza okno z grą
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            Hide();
            new GameForm().ShowDialog();
            Close();
        }
        /// <summary>
        /// Włącza okno z samouczkiem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManualButton_Click(object sender, EventArgs e)
        {
            new ManualForm().ShowDialog();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}

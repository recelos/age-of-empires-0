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
    public partial class ManualForm : Form
    {
        public ManualForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Zamyka okno z samouczkiem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

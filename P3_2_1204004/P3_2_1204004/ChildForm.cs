using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_2_1204004
{
    public partial class ChildForm : Form
    {

        private string outputText = DateTime.Now.ToString("d");

        public ChildForm()
        {
            InitializeComponent();
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimeOption_Click(object sender, EventArgs e)
        {
            outputText = DateTime.Now.ToString("t");
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = outputText;
        }

        private void DateOption_Click(object sender, EventArgs e)
        {
            outputText = DateTime.Now.ToString("d");
        }
    }
}

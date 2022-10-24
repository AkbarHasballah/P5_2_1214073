using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_2_1214073
{
    public partial class ChildForm : Form
    {
        public object OutputGroupBox { get; private set; }

        public ChildForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            DisplayButton.Text = OutputgroupBox.Text;
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OutputgroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void TimeOption_CheckedChanged(object sender, EventArgs e)
        {
            TimeOption.Text = DateTime.Now.ToString("t");
        }

        private void DateOption_CheckedChanged(object sender, EventArgs e)
        {
            DateOption.Text = DateTime.Now.ToString("d");
        }
    }
}

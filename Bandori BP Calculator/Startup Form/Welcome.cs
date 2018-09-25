using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bandori_EP_BP_Calculator
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Member1 member1 = new Member1();
            this.Hide();
            member1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EPCalculator ePCalculator = new EPCalculator();
            this.Hide();
            ePCalculator.Show();
        }
    }
}

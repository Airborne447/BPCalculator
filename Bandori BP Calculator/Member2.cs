using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bandori_BP_Calculator
{
    /*Done by Airborne447#9435 with help from Epicmouse#6870*/
    public partial class Member2 : Form
    {
        public static float BP2;
        public static string BND2, ATTR2;

        float bandPower2;
        string band2, attr2;

        private void backButton_Click(object sender, EventArgs e)
        {
            Member1 member1 = new Member1(); //Instantiate Member1 Form
            this.Hide(); //Hides Member1 Form
            member1.Show(); //Shows Member1 Form
        }

        public Member2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bandPower2 = 0.0f;
            BP2 = 0.0f;
            band2 = "";
            attr2 = "";
            BND2 = "";
            ATTR2 = "";

            if (mem2TextBox.Text == "")
            {
                MessageBox.Show("Please enter the Band Power of the character");
            }

            else
            {
                try
                {
                    bandPower2 = float.Parse(mem2TextBox.Text);
                }

                catch
                {
                    MessageBox.Show("You entered an invalid input. Please check your inputs and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (mem2Stars.SelectedIndex == 0)
                {
                    if (mem2Story1.Checked)
                        bandPower2 = bandPower2 + 750f;

                    if (mem2Story2.Checked)
                        bandPower2 = bandPower2 + 1800f;
                }

                else if (mem2Stars.SelectedIndex == 1)
                {
                    if (mem2Story1.Checked)
                        bandPower2 = bandPower2 + 600f;

                    if (mem2Story2.Checked)
                        bandPower2 = bandPower2 + 1500f;
                }

                else if (mem2Stars.SelectedIndex == 2)
                {

                    if (mem2Story1.Checked)
                        bandPower2 = bandPower2 + 450f;

                    if (mem2Story2.Checked)
                        bandPower2 = bandPower2 + 900f;
                }

                switch (mem2Attr.SelectedIndex)
                {
                    case 0:
                        attr2 = "Pure";
                        break;

                    case 1:
                        attr2 = "Power";
                        break;

                    case 2:
                        attr2 = "Happy";
                        break;

                    case 3:
                        attr2 = "Cool";
                        break;

                    default:
                        MessageBox.Show("Please enter an attribute.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                switch (mem2Band.SelectedIndex)
                {
                    case 0:
                        band2 = "Poppin' Party";
                        break;

                    case 1:
                        band2 = "Afterglow";
                        break;

                    case 2:
                        band2 = "Pastel*Palettes";
                        break;

                    case 3:
                        band2 = "Roselia";
                        break;

                    case 4:
                        band2 = "Hello, Happy World!";
                        break;

                    default:
                        MessageBox.Show("Please enter a band.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                BP2 = bandPower2;
                ATTR2 = attr2;
                BND2 = band2;

                Member3 member3 = new Member3();
                this.Hide();
                member3.Show();
            }
        }
    }
}

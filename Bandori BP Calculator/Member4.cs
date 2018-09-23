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
    public partial class Member4 : Form
    {
        public static float BP4;
        public static string BND4, ATTR4;
        float bandPower4;
        string attr4, band4;

        private void backButton_Click(object sender, EventArgs e)
        {
            Member3 member3 = new Member3(); //Instantianting Member3 Form.
            this.Hide(); //Hides Member4 Form.
            member3.Show(); //Shows Member3 Form.
        }

        public Member4()
        {
            InitializeComponent();
        }

        private void nextButton4_Click(object sender, EventArgs e)
        {
            bandPower4 = 0.0f;
            BP4 = 0.0f;
            attr4 = "";
            band4 = "";
            ATTR4 = "";
            BND4 = "";

            if (mem4TextBox.Text == "")
            {
                MessageBox.Show("Please enter the Band Power of the character");
            }

            else
            {
                try
                {
                    bandPower4 = float.Parse(mem4TextBox.Text);
                }

                catch
                {
                    MessageBox.Show("You entered an invalid input. Please check your inputs and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (mem4Stars.SelectedIndex == 0)
                {
                    if (mem4Story1.Checked)
                        bandPower4 = bandPower4 + 750f;

                    if (mem4Story2.Checked)
                        bandPower4 = bandPower4 + 1800f;
                }

                else if (mem4Stars.SelectedIndex == 1)
                {
                    if (mem4Story1.Checked)
                        bandPower4 = bandPower4 + 600f;

                    if (mem4Story2.Checked)
                        bandPower4 = bandPower4 + 1500f;
                }

                else if (mem4Stars.SelectedIndex == 2)
                {

                    if (mem4Story1.Checked)
                        bandPower4 = bandPower4 + 450f;

                    if (mem4Story2.Checked)
                        bandPower4 = bandPower4 + 900f;
                }

                switch (mem4Attr.SelectedIndex)
                {
                    case 0:
                        attr4 = "Pure";
                        break;

                    case 1:
                        attr4 = "Power";
                        break;

                    case 2:
                        attr4 = "Happy";
                        break;

                    case 3:
                        attr4 = "Cool";
                        break;

                    default:
                        MessageBox.Show("Please enter an attribute.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                switch (mem4Band.SelectedIndex)
                {
                    case 0:
                        band4 = "Poppin' Party";
                        break;

                    case 1:
                        band4 = "Afterglow";
                        break;

                    case 2:
                        band4 = "Pastel*Palettes";
                        break;

                    case 3:
                        band4 = "Roselia";
                        break;

                    case 4:
                        band4 = "Hello, Happy World!";
                        break;

                    default:
                        MessageBox.Show("Please enter a band.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                BP4 = bandPower4;
                ATTR4 = attr4;
                BND4 = band4;

                Member5 member5 = new Member5();
                this.Hide();
                member5.Show();
            }
        }
    }
}

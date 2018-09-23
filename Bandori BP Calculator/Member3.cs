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
    public partial class Member3 : Form
    {
        public static float BP3;
        public static string ATTR3, BND3;
        float bandPower3;
        string band3, attr3;

        private void backButton_Click(object sender, EventArgs e)
        {
            Member2 member2 = new Member2(); //Instantiating Member2 Form.
            this.Hide(); //Hides Member3 Form.
            member2.Show(); //Shows Member2 Form.
        }

        public Member3()
        {
            InitializeComponent();
        }

        private void nextButton3_Click_1(object sender, EventArgs e)
        {
            bandPower3 = 0.0f;
            BP3 = 0.0f;
            attr3 = "";
            band3 = "";
            ATTR3 = "";
            BND3 = "";

            if (mem4TextBox.Text == "")
            {
                MessageBox.Show("Please enter the Band Power of the character");
            }

            else
            {
                try
                {
                    bandPower3 = float.Parse(mem4TextBox.Text);
                }

                catch
                {
                    MessageBox.Show("You entered an invalid input. Please check your inputs and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (mem4Stars.SelectedIndex == 0)
                {
                    if (mem4Story1.Checked)
                        bandPower3 = bandPower3 + 750f;

                    if (mem4Story2.Checked)
                        bandPower3 = bandPower3 + 1800f;
                }

                else if (mem4Stars.SelectedIndex == 1)
                {
                    if (mem4Story1.Checked)
                        bandPower3 = bandPower3 + 600f;

                    if (mem4Story2.Checked)
                        bandPower3 = bandPower3 + 1500f;
                }

                else if (mem4Stars.SelectedIndex == 2)
                {

                    if (mem4Story1.Checked)
                        bandPower3 = bandPower3 + 450f;

                    if (mem4Story2.Checked)
                        bandPower3 = bandPower3 + 900f;
                }

                switch (mem4Attr.SelectedIndex)
                {
                    case 0:
                        attr3 = "Pure";
                        break;

                    case 1:
                        attr3 = "Power";
                        break;

                    case 2:
                        attr3 = "Happy";
                        break;

                    case 3:
                        attr3 = "Cool";
                        break;

                    default:
                        MessageBox.Show("Please enter an attribute.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                switch (mem4Band.SelectedIndex)
                {
                    case 0:
                        band3 = "Poppin' Party";
                        break;

                    case 1:
                        band3 = "Afterglow";
                        break;

                    case 2:
                        band3 = "Pastel*Palettes";
                        break;

                    case 3:
                        band3 = "Roselia";
                        break;

                    case 4:
                        band3 = "Hello, Happy World!";
                        break;

                    default:
                        MessageBox.Show("Please enter a band.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                BP3 = bandPower3;
                ATTR3 = attr3;
                BND3 = band3;

                Member4 member4 = new Member4();
                this.Hide();
                member4.Show();
            }
        }
    }
}

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
    public partial class Member5 : Form
    {
        public static float BP5;
        public static string BND5, ATTR5;
        float bandPower5;
        string attr5, band5;

        private void backButton_Click(object sender, EventArgs e)
        {
            Member4 member4 = new Member4(); //Instantiating the Member4 Form.
            this.Hide(); //Hides Member5 Form.
            member4.Show(); //Shows Member4 Form.
        }

        public Member5()
        {
            InitializeComponent();
        }

        private void nextButton5_Click(object sender, EventArgs e)
        {
            bandPower5 = 0.0f;
            BP5 = 0.0f;
            attr5 = "";
            band5 = "";
            ATTR5 = "";
            BND5 = "";

            if (mem5TextBox.Text == "")
            {
                MessageBox.Show("Please enter the Band Power of the character");
            }

            else
            {
                try
                {
                    bandPower5 = float.Parse(mem5TextBox.Text);
                }

                catch
                {
                    MessageBox.Show("You entered an invalid input. Please check your inputs and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (mem5Stars.SelectedIndex == 0)
                {
                    if (mem5Story1.Checked)
                        bandPower5 = bandPower5 + 750f;

                    if (mem5Story2.Checked)
                        bandPower5 = bandPower5 + 1800f;
                }

                else if (mem5Stars.SelectedIndex == 1)
                {
                    if (mem5Story1.Checked)
                        bandPower5 = bandPower5 + 600f;

                    if (mem5Story2.Checked)
                        bandPower5 = bandPower5 + 1500f;
                }

                else if (mem5Stars.SelectedIndex == 2)
                {

                    if (mem5Story1.Checked)
                        bandPower5 = bandPower5 + 450f;

                    if (mem5Story2.Checked)
                        bandPower5 = bandPower5 + 900f;
                }

                switch (mem5Attr.SelectedIndex)
                {
                    case 0:
                        attr5 = "Pure";
                        break;

                    case 1:
                        attr5 = "Power";
                        break;

                    case 2:
                        attr5 = "Happy";
                        break;

                    case 3:
                        attr5 = "Cool";
                        break;

                    default:
                        MessageBox.Show("Please enter an attribute.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                switch (mem5Band.SelectedIndex)
                {
                    case 0:
                        band5 = "Poppin' Party";
                        break;

                    case 1:
                        band5 = "Afterglow";
                        break;

                    case 2:
                        band5 = "Pastel*Palettes";
                        break;

                    case 3:
                        band5 = "Roselia";
                        break;

                    case 4:
                        band5 = "Hello, Happy World!";
                        break;

                    default:
                        MessageBox.Show("Please enter a band.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                BP5 = bandPower5;
                ATTR5 = attr5;
                BND5 = band5;

                AreaItems areaItems = new AreaItems();
                this.Hide();
                areaItems.Show();
            }
        }
    }
}

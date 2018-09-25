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
    public partial class Member1 : Form
    {
        public static float BP1;
        public static string BND1, ATTR1;
        float bandPower1;
        string band1, attr1;

        public Member1()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {   
            bandPower1 = 0.0f;
            BP1 = 0.0f;
            band1 = "";
            attr1 = "";
            BND1 = "";
            ATTR1 = "";

            if (mem1TextBox.Text == "")
            {
                MessageBox.Show("Please enter the Band Power of the character");
            }

            else
            {
                try
                {
                    bandPower1 = float.Parse(mem1TextBox.Text);
                }

                catch
                {
                    MessageBox.Show("You entered an invalid input. Please check your inputs and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (mem1Stars.SelectedIndex == 0)
                {
                    if (mem1Story1.Checked)
                        bandPower1 = bandPower1 + 750f;

                    if (mem1Story2.Checked)
                        bandPower1 = bandPower1 + 1800f;
                }

                else if (mem1Stars.SelectedIndex == 1)
                {
                    if (mem1Story1.Checked)
                        bandPower1 = bandPower1 + 600f;

                    if (mem1Story2.Checked)
                        bandPower1 = bandPower1 + 1500f;
                }

                else if (mem1Stars.SelectedIndex == 2)
                {

                    if (mem1Story1.Checked)
                        bandPower1 = bandPower1 + 450f;

                    if (mem1Story2.Checked)
                        bandPower1 = bandPower1 + 900f;
                }

                else
                {
                    MessageBox.Show("Please select the rarity of your character!","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                switch (mem1Attr.SelectedIndex)
                {
                    case 0:
                        attr1 = "Pure";
                        break;

                    case 1:
                        attr1 = "Power";
                        break;

                    case 2:
                        attr1 = "Happy";
                        break;

                    case 3:
                        attr1 = "Cool";
                        break;

                    default:
                        MessageBox.Show("Please enter an attribute.","",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                switch (mem1Band.SelectedIndex)
                {
                    case 0:
                        band1 = "Poppin' Party";
                        break;

                    case 1:
                        band1 = "Afterglow";
                        break;

                    case 2:
                        band1 = "Pastel*Palettes";
                        break;

                    case 3:
                        band1 = "Roselia";
                        break;

                    case 4:
                        band1 = "Hello, Happy World!";
                        break;

                    default:
                        MessageBox.Show("Please enter a band.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                BP1 = bandPower1; //Transferring the data to static variables to be used in AreaItem Form.
                ATTR1 = attr1;
                BND1 = band1;

                Member2 member2 = new Member2();
                this.Hide();
                member2.Show();
            }
        }
    }
}

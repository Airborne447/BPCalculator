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
    public partial class AreaItems : Form
    {
        /*Done by Airborne447#9435 with help from Epicmouse#6870*/

        Member1 mem1 = new Member1();
        Member2 mem2 = new Member2();
        Member3 mem3 = new Member3();
        Member4 mem4 = new Member4();
        Member5 mem5 = new Member5();

        public AreaItems()
        {
            InitializeComponent();
        }

        private void AreaItems_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float TotalBP = 0.0f; //Total BP
            float fltBand1, fltBand2, fltAttr; //Band1 = Instruments, Band2 = Flyers/Poster, Attr = Attribute
            string strBand1, strBand2, strAttr; 

            float Bonus1, Bonus2, Bonus3, Bonus4, Bonus5; //Boost percentage from various area Items. Bonus1 is for the 1st Member, Bonus2 for 2nd.. and so on.

            fltBand1 = fltBand2 = fltAttr = 0.0f; //Clears data of variables upon button press.
            strBand1 = strBand2 = strAttr = "";  //Ensures no data is left behind to affect the results.
            Bonus1 = Bonus2 = Bonus3 = Bonus4 = Bonus5 = 0.0f;

            if ((bandItemTextBox.Text == "") || (bandFlyerTextBox.Text == "") || (attrItemTextBox.Text == ""))
            {
                MessageBox.Show("Please enter values.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //Checks if Textboxes are empty. If empty, exit event handler and do not proceed.
            }

            if ((bandCheck1.SelectedIndex == -1) || (bandCheck2.SelectedIndex == -1) || (attrCheck.SelectedIndex == -1))
            {
                MessageBox.Show("Please enter the Band's Name or Type of Attribute Item.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //Checks if ComboBoxes are empty. If empty, exit event handler and do not proceed.
            }

            try
            {
                fltBand1 = float.Parse(bandItemTextBox.Text);
                fltBand2 = float.Parse(bandFlyerTextBox.Text);
                fltAttr = float.Parse(attrItemTextBox.Text);

                strBand1 = bandCheck1.SelectedItem.ToString();
                strBand2 = bandCheck2.SelectedItem.ToString();
                strAttr = attrCheck.SelectedItem.ToString();
            }

            catch
            {
                MessageBox.Show("Please enter appropriate values.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //If Value is unable to be parsed, or there is nothing selected,
                        //Exit the event handler.
            }

            if ((fltBand1 > 22.5) || (fltBand2 > 20) || (fltAttr > 20) || (fltBand1 < 0) || (fltBand2 < 0) || (fltAttr < 0))
            {
                MessageBox.Show("Please check your inputs. \nThe max value for Band Instruments is 22.5. \nThe max value for Band Items is 20.\nand the max value for Attribute Items is 20.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //Checks that the values of the area items are not above what is possible, and checks for stupid inputs. 
                        //If it does not pass this check, exit handler and ask them to reinput data.
            }

            if (Member1.BND1 == strBand1)   //First Member
            {                               //If First Member's Band = The Band of the Selected AreaItem
                Bonus1 = Bonus1 + fltBand1; //Apply the Band buff to the member.
            }

            if (Member1.BND1 == strBand2)
            {                               //If First Member's Band = The Band of the Selected AreaItem
                Bonus1 = Bonus1 + fltBand2; //Apply the Band buff to the member.
            }

            if (Member1.ATTR1 == strAttr)   //If First Member's Band = The Attribute of the Selected AreaItem
            {                               //Apply the Attribute buff to the member.
                Bonus1 = Bonus1 + fltAttr;
            }

            if (Member2.BND2 == strBand1)   //2nd Member, Repeat of the above line of code for 3 more times.
            {
                Bonus2 = Bonus2 + fltBand1;
            }

            if (Member2.BND2 == strBand2)
            {
                Bonus2 = Bonus2 + fltBand2;
            }

            if (Member2.ATTR2 == strAttr)
            {
                Bonus2 = Bonus2 + fltAttr;
            }

            if (Member3.BND3 == strBand1)   //3rd Member
            {
                Bonus3 = Bonus3 + fltBand1;
            }

            if (Member3.BND3 == strBand2)
            {
                Bonus3 = Bonus3 + fltBand2;
            }

            if (Member3.ATTR3 == strAttr)
            {
                Bonus3 = Bonus3 + fltAttr;
            }

            if (Member4.BND4 == strBand1)   //4th Member
            {
                Bonus4 = Bonus4 + fltBand1;
            }

            if (Member4.BND4 == strBand2)
            {
                Bonus4 = Bonus4 + fltBand2;
            }

            if (Member4.ATTR4 == strAttr)
            {
                Bonus4 = Bonus4 + fltAttr;
            }

            if (Member5.BND5 == strBand1)   //5th Member
            {
                Bonus5 = Bonus5 + fltBand1;
            }

            if (Member5.BND5 == strBand2)
            {
                Bonus5 = Bonus5 + fltBand2;
            }

            if (Member5.ATTR5 == strAttr)
            {
                Bonus5 = Bonus5 + fltAttr;
            }

            TotalBP = (Member1.BP1 * ((100 + Bonus1) / 100)) + (Member2.BP2 * ((100 + Bonus2) / 100)) + (Member3.BP3 * ((100 + Bonus3) / 100)) + (Member4.BP4 * ((100 + Bonus4) / 100)) + (Member5.BP5 * ((100 + Bonus5) / 100));

            outputLabel.Text = "The total BP of your five members is: " + TotalBP.ToString() +
                               "\n\nYour Inputs were: " +
                               ".\n " + Member1.BP1.ToString() + ", " + Member1.BND1.ToString() + ", " + Member1.ATTR1.ToString() +
                               ".\n " + Member2.BP2.ToString() + ", " + Member2.BND2.ToString() + ", " + Member2.ATTR2.ToString() +
                               ".\n " + Member3.BP3.ToString() + ", " + Member3.BND3.ToString() + ", " + Member3.ATTR3.ToString() +
                               ".\n " + Member4.BP4.ToString() + ", " + Member4.BND4.ToString() + ", " + Member4.ATTR4.ToString() +
                               ".\n " + Member5.BP5.ToString() + ", " + Member5.BND5.ToString() + ", " + Member5.ATTR5.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

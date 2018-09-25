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
    public partial class EPCalculator : Form
    {
        int selfScore, multiScore, numFlames, flameMultiplier, result1, posn;
        float boostPer, result;

        private void eventType_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (eventType.SelectedIndex == 2) //Band Battle
             {   
                roomScore.Visible = false; //Hides the "Room Score" Textbox
                label1.Visible = false;    //Hides the "Room Score" Label
                boost.Visible = false;     //Hides the "Boost Percentage" Textbox
                label3.Visible = false;    //Hides the "Boost Percentage" Label

                pos.Visible = true; //Shows the "Position in Room" TextBox
                label6.Visible = true;     //Shows the "Position in Room" Label
             }

             else
             {
                roomScore.Visible = true;  //Shows the "Room Score" TextBox
                label1.Visible = true;     //Shows the "Room Score" Label
                boost.Visible = true;     //Shows the "Boost Percentage" Textbox
                label3.Visible = true;    //Shows the "Boost Percentage" Label

                pos.Visible = false;//Hides the "Position in Room" Textbox
                label6.Visible = false;    //Hides the "Position in Room" Label
             }
        }

        public EPCalculator()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ownScore.Text = "";
            roomScore.Text = "";
            boost.Text = "";
            eventType.SelectedIndex = -1;
            outputLabel.Text = "";
            flames.Text = "";
            pos.Text = "";
            outputLabel.Visible = false;
        }

        private void calButton_Click(object sender, EventArgs e)
        {
            selfScore = 0;
            multiScore = 0;
            boostPer = 0;
            numFlames = 0;
            flameMultiplier = 0;
            posn = 0;

            if ((eventType.SelectedIndex == 0) || (eventType.SelectedIndex == 1)) //If Event = Normal or CL
            {
                if ((ownScore.Text == "") || (roomScore.Text == "") || (boost.Text == "") || (flames.Text == ""))
                {
                    MessageBox.Show("You have not entered values. \nPlease check your inputs and try again.", "", MessageBoxButtons.OK);
                    return; //Checks if inputs are empty.
                }

                try
                {
                    selfScore = int.Parse(ownScore.Text); //Tries to parse inputs. If there is error,
                    multiScore = int.Parse(roomScore.Text);//Catches them and return. Exits program handler.
                    boostPer = float.Parse(boost.Text);
                    numFlames = int.Parse(flames.Text);
                }

                catch
                {
                    MessageBox.Show("You have entered inappropriate values. \nPlease check your inputs and try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            else if (eventType.SelectedIndex == 2) //If event type = BB
            {
                if ((ownScore.Text == "") || (pos.Text == "") || (flames.Text == ""))
                {
                    MessageBox.Show("You have not entered values. \nPlease check your inputs and try again.", "", MessageBoxButtons.OK);
                    return; //Checks if inputs are empty.
                }
          
                try
                {
                    selfScore = int.Parse(ownScore.Text); //Tries to parse inputs. If there is error,
                    posn = int.Parse(pos.Text);           //Catches them and return. Exits program handler.
                    numFlames = int.Parse(flames.Text);   //Key difference is BB one checks pos Textbox.
                                                          //Original one checks multiScore Textbox.
                                                          //BB has no BoostPercentage.
                }

                catch
                {
                    MessageBox.Show("You have entered inappropriate values. \nPlease check your inputs and try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if ((posn <= 0)||(posn > 5))
                {
                    MessageBox.Show("You have entered a wrong position. \nPlease check your inputs and try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; //Position must be a valid number.
                }
            }

            switch (numFlames)
            {
                case 0: flameMultiplier = 1; 
                        break;               
                case 1: flameMultiplier = 5;
                        break;
                case 2: flameMultiplier = 10;
                        break;
                case 3: flameMultiplier = 15;
                        break;
                default: MessageBox.Show("You entered an invalid number of flames.Please check your inputs and try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         return;
            }

            if (eventType.SelectedIndex == 0) //Normal Event Type
            {
                if (selfScore >= 1500000) //Personal Score caps at 1.5M
                {
                    selfScore = 1500000;
                }

                if (multiScore >= 7500000) //Multi Score caps at 7.5M
                {
                    multiScore = 6000000;
                }

                if (boostPer >= 150) //Boost Percentage Caps at 150%
                {
                    boostPer = 150;
                }

                result = (50 + (selfScore / 10000) + (multiScore / 100000)) * (1 + boostPer / 100) * flameMultiplier;
                result1 = (int)Math.Floor(result); //Rounds down the value obtained.
                outputLabel.Visible = true; 
                outputLabel.Text = "Your maximum BP for Normal Events with the current settings is: " + result1.ToString() + "EP.";
            }

            else if (eventType.SelectedIndex == 1) //Challenge Live Type
            {
                if (selfScore >= 1500000) //Personal Score caps at 1.5M
                {
                    selfScore = 1500000;
                }

                if (multiScore >= 7500000) //Multi Score caps at 7.5M
                {
                    multiScore = 6000000;
                }

                if (boostPer >= 150) //Boost Percentage Caps at 150%
                {
                    boostPer = 150;
                }

                result = (20 + (selfScore / 25000) + (multiScore / 250000)) * (1 + boostPer / 100) * flameMultiplier;
                result1 = (int)Math.Floor(result); //Rounds down the value obtained.
                outputLabel.Visible = true;
                outputLabel.Text = "Your maximum BP for Challenge Live Events with the current settings is: " + result1.ToString() + "EP.";
            }

            else if (eventType.SelectedIndex == 2) //Band Battle
            {
                float BBScore = 0; //Variable used to calculate Score Bonus.
                int BBScore1 = 0;//Used for flooring.

                posn = posn - 1; //Arrays start at 0. Need to -1.
                int[] place = { 60, 52, 44, 37, 30 }; //Various values for the position in the room you are in.

                BBScore = selfScore / 5500; 
                BBScore1 = (int)Math.Floor(BBScore); //According to BD Tumblr, "Score Bonus = floor[ ( Your Score ) / 5500 ]"

                result = (place[posn] + BBScore1) * flameMultiplier;
                result1 = (int)Math.Floor(result);

                outputLabel.Visible = true;
                outputLabel.Text = "Your maximum BP for Band Battle Events with the current settings is: " + result1.ToString() + "EP.";
            }

            else if (eventType.SelectedIndex == -1)
            {
                MessageBox.Show("You not selected an event type.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeanAndMean
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //Set Variables
            int weightPounds = 0, heightFeet = 0, heightInches = 0, age = 0, amountToLoseMultiplier = 0, maleMultiplier = 66, femaleMultipler = 655;
            bool male = false;
            bool female = false;
            string lossPerWeek = "";
            string activityLevel = "";
            float activityMultiplier = 0, weightConv, heightConv, maleBMR, femaleBMR, maleTDEE, femaleTDEE, BMI;
            const float IN_TO_CM = 2.54f;
            const float LB_TO_KG = 0.453592f;


            //Exception Handling
            try
            {
                weightPounds = int.Parse(weightTextbox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid weight.");
            }
           
            try
            {
                heightFeet = int.Parse(heightftTextbox.Text);
                heightInches = int.Parse(heightinTextbox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid height.");
            }

            try
            {
                age = int.Parse(ageTextbox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid age.");
            }
            try
            {
                if (maleButton.Checked)
                {
                    male = true;
                }
                else if (femaleButton.Checked)
                {
                    female = true;
                }
                else
                {
                    throw new GenderNotFoundException("Please select a gender");
                }
            }
            catch (GenderNotFoundException msg)
            {
                MessageBox.Show(msg.Message);
            }

            try
            {
                if (lossPerWeekComboBox.SelectedIndex != -1)
                {
                    lossPerWeek = lossPerWeekComboBox.SelectedItem.ToString();
                }
                else
                {
                    throw new LossAmountNotFoundException("Please select an amount to lose.");
                }
            }
            catch (LossAmountNotFoundException msg)
            {
                MessageBox.Show(msg.Message);
            }

            try
            {
                if (activityLevelComboBox.SelectedIndex != -1)
                {
                    activityLevel = activityLevelComboBox.SelectedItem.ToString();

                }
                else
                {
                    throw new ActivityLevelNotFoundException("Please select an activity level.");
                }
            }
            catch (ActivityLevelNotFoundException msg)
            {
                MessageBox.Show(msg.Message);
            }

            switch (lossPerWeek)
            {
                case "Half a pound per week.":
                    amountToLoseMultiplier = 250;
                    break;
                case "One pound per week.":
                    amountToLoseMultiplier = 500;
                    break;
                case "Two pounds per week.":
                    amountToLoseMultiplier = 1000;
                    break;
                default:
                    amountToLoseMultiplier = 0;
                    break;
            }

            switch (activityLevel)
            {
                case "Sedentary (Office Job)":
                    activityMultiplier = 1.2f;
                    break;
                case "Light (1 - 2 days per week)":
                    activityMultiplier = 1.375f;
                    break;
                case "Moderate (3 - 5 days per week)":
                    activityMultiplier = 1.55f;
                    break;
                case "Heavy (6 - 7 days per week)":
                    activityMultiplier = 1.725f;
                    break;
                case "Athlete (Twice a day)":
                    activityMultiplier = 1.9f;
                    break;

            }

            // Conversions
            heightConv = ((heightFeet * 12) + heightInches) * IN_TO_CM;
            weightConv = weightPounds * LB_TO_KG;

            //Calculate BMI
            BMI = (weightPounds * 703) / (((heightFeet * 12) + heightInches) * ((heightFeet * 12) + heightInches));
            bmiOutputLabel.Text = BMI.ToString();

            //Calculates TDEE
            if (male == true)
            {
                maleBMR = maleMultiplier + (13.7f * weightConv) + (5 * heightConv) - (6.8f * age);
                maleTDEE = (maleBMR * activityMultiplier) - amountToLoseMultiplier;

                //Print details
                caloriesOutputLabel.Text = maleTDEE.ToString();

            }
            else if (female == true)
            {
                femaleBMR = femaleMultipler + (9.6f * weightConv) + (1.8f * heightConv) - (4.7f * age);
                femaleTDEE = (femaleBMR * activityMultiplier) - amountToLoseMultiplier;

                //Print details
                caloriesOutputLabel.Text = femaleTDEE.ToString();
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            weightTextbox.Text = " ";
            heightftTextbox.Text = " ";
            heightinTextbox.Text = " ";
            ageTextbox.Text = " ";
            bmiOutputLabel.Text = " ";
            caloriesOutputLabel.Text = " ";
            activityLevelComboBox.SelectedIndex = -1;
            lossPerWeekComboBox.SelectedIndex = -1;

        }
    }

    [Serializable]
    internal class ActivityLevelNotFoundException : Exception
    {
        public ActivityLevelNotFoundException()
        {
        }

        public ActivityLevelNotFoundException(string message) : base(message)
        {
        }

        public ActivityLevelNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ActivityLevelNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class LossAmountNotFoundException : Exception
    {
        public LossAmountNotFoundException()
        {
        }

        public LossAmountNotFoundException(string message) : base(message)
        {
        }

        public LossAmountNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LossAmountNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class GenderNotFoundException : Exception
    {
        public GenderNotFoundException()
        {
        }

        public GenderNotFoundException(string message) : base(message)
        {
        }

        public GenderNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GenderNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

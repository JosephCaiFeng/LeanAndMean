using System;
using System.Windows.Forms;

namespace LeanAndMean
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // Collect Form Data For Input Validation
            var formData = new RawUserInput
            {
                WeightInPounds = weightTextbox.Text,
                HeightFeetIndex = heightFtComboBox.SelectedIndex,
                HeightInchesIndex = heightInCombobox.SelectedIndex,
                HeightFeetValue = heightFtComboBox.Text,
                HeightInchesValue = heightInCombobox.Text,
                Age = ageTextbox.Text,
                IsMale = maleButton.Checked,
                IsFemale = femaleButton.Checked,
                LossPerWeekIndex = lossPerWeekComboBox.SelectedIndex.ToString(),
                ActivityLevel = activityLevelComboBox.SelectedIndex.ToString(),
                MacroParametersIndex = macroComboBox.SelectedIndex.ToString()
            };

            // Validate User Input
            string inputErrors = formData.ValidateInput();

            // If there were errors, notify the user
            if (!string.IsNullOrEmpty(inputErrors))
            {
                MessageBox.Show(inputErrors, "Input Invalid");
            }
            // If there were no errors, generate the calculation entity and process and display the data
            else
            {
                UserProfile profile = new UserProfile(formData);

                // Display the results
                bmiOutputLabel.Text = profile.BodyMassIndex.ToString("0.00");
                caloriesOutputLabel.Text = profile.TotalDailyEnergyExpenditure.ToString("0");

                macroLabelOutput.Text = $"Macronutrient Distribution: \r\n\t" +
                    $"Protein: { profile.Macros.GramsOfProtein }g " +
                    $"Carbs: { profile.Macros.GramsOfCarbohydrates }g " +
                    $"Fats: { profile.Macros.GramsOfFat }g";

                if (profile.BodyMassIndex < 18.5f)
                {
                    categoryLabel.Text = "Underweight";
                }
                else if (profile.BodyMassIndex > 18.5f & profile.BodyMassIndex < 24.5f)
                {
                    categoryLabel.Text = "Normal Weight";
                }
                else if (profile.BodyMassIndex > 24.5f & profile.BodyMassIndex < 29.9f)
                {
                    categoryLabel.Text = "Overweight";
                }
                else if (profile.BodyMassIndex > 30.0f)
                {
                    categoryLabel.Text = "Obese";
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            weightTextbox.Text = string.Empty;
            heightFtComboBox.SelectedIndex = -1;
            heightInCombobox.SelectedIndex = -1;
            ageTextbox.Text = string.Empty;
            bmiOutputLabel.Text = string.Empty;
            caloriesOutputLabel.Text = string.Empty;
            macroLabelOutput.Text = string.Empty;
            activityLevelComboBox.SelectedIndex = -1;
            lossPerWeekComboBox.SelectedIndex = -1;
            macroComboBox.SelectedIndex = -1;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;

namespace LeanAndMean
{
    public class RawUserInput
    {
        public string WeightInPounds { get; set; }
        public int HeightFeetIndex { get; set; }
        public string HeightFeetValue { get; set; }
        public int HeightInchesIndex { get; set; }
        public string HeightInchesValue { get; set; }
        public string Age { get; set; }
        public bool IsMale { get; set; }
        public bool IsFemale { get; set; }
        public string LossPerWeekIndex { get; set; }
        public int LossPerWeekValue { get; set; }
        public string ActivityLevel { get; set; }
        public string MacroParametersIndex { get; set; }
        public MacroParameters MacroParametersValue { get; set; }

        internal string ValidateInput()
        {
            string errorMessage = string.Empty;

            // Valitade Weight Input
            try
            {
                int.Parse(WeightInPounds);
            }
            catch
            {
                errorMessage = $"Please enter a valid weight.{Environment.NewLine}";
            }

            // Validate Height Selection
            if (HeightFeetIndex == -1 || HeightInchesIndex == -1)
            {

                errorMessage = $"{errorMessage}Please select your complete height.{Environment.NewLine}";
            }

            // Validate Age Input
            try
            {
                var inputAge = int.Parse(Age);
                if (int.Parse(Age) < 20 || int.Parse(Age) > 80)
                {
                    errorMessage = $"{errorMessage}Lean and Mean is designed for ages 18 to 80, please get nutritional guidance from a health professional";
                }
            }
            catch
            {
                errorMessage = $"{errorMessage}Please enter a valid age.{Environment.NewLine}";
            }

            // Validate Gender Selection 
            // NOTE: THIS SEEMS REDUNDANT WITH A NON NULLABLE RADIO BUTTON GROUP
            if ((IsMale && IsFemale) || (!IsMale && !IsFemale))
            {
                errorMessage = $"{errorMessage}Please select male or female.{Environment.NewLine}";
            }

            // Validate Weight Loss Selection
            if (int.Parse(LossPerWeekIndex) < 0)
            {
                errorMessage = $"{errorMessage}Please select weight loss target.{Environment.NewLine}";
            }

            // Validate Activity Level Selection
            if (int.Parse(ActivityLevel) < 0)
            {
                errorMessage = $"{errorMessage}Please select an activity level.{Environment.NewLine}";
            }

            // Validate Macros and Set Macro Parameters
            if (int.Parse(MacroParametersIndex) < 0)
            {
                errorMessage = $"{errorMessage}Please select macros.{Environment.NewLine}";
            }
            else
            {
                switch (int.Parse(MacroParametersIndex))
                {
                    case 0: //Maintain
                        MacroParametersValue = MacroParameters.Maintain;
                        break;
                    case 1: //Bulk
                        MacroParametersValue = MacroParameters.Bulk;
                        if (int.Parse(LossPerWeekIndex) >= 0 && int.Parse(LossPerWeekIndex) != 4)
                            errorMessage = $"{errorMessage}You can not choose Bulking Macros with a Weight Loss Target.{Environment.NewLine}";
                        break;
                    case 2: //Cut
                        MacroParametersValue = MacroParameters.Cut;
                        if (int.Parse(LossPerWeekIndex) == 4)
                            errorMessage = $"{errorMessage}You can not choose Cutting Macros with a Weight Maintenance Target.{Environment.NewLine}";
                        break;
                }
            }
            return errorMessage.TrimEnd(Environment.NewLine.ToCharArray());
        }
    }
}

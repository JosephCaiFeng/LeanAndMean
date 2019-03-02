using System;

namespace LeanAndMean
{

    public class UserProfile
    {
        public int WeightInPounds { get; set; }
        public int HeightInInches { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public double WeeklyWeightLossGoal { get; set; }
        public MacroNutrientBreakdown Macros { get; set; }
        public double BodyMassIndex => WeightInPounds * 703 / (Math.Pow(HeightInInches, 2));
        public double BasalMetabolicRate => _bmrBase + (_bmrWeightFactor * WeightInPounds) + (_bmrHeightFactor * HeightInInches) - (_bmrAgeFactor * Age);
        public double TotalDailyEnergyExpenditure => (BasalMetabolicRate * _activityMultiplier) - _weightLossBasedCalorieDeficit + _macroParameterAdjustment;



        private double _bmrBase => (Gender == Gender.Male) ? 66 : 655;
        private double _bmrWeightFactor => (Gender == Gender.Male) ? 6.23 : 4.35;
        private double _bmrHeightFactor => (Gender == Gender.Male) ? 12.7 : 4.7;
        private double _bmrAgeFactor => (Gender == Gender.Male) ? 6.8 : 4.7;
        private double _activityMultiplier { get; set; }
        private int _weightLossBasedCalorieDeficit { get; set; }
        private int _macroParameterAdjustment { get; set; }

        public UserProfile(RawUserInput userInput)
        {
            WeightInPounds = int.Parse(userInput.WeightInPounds);
            HeightInInches = int.Parse(userInput.HeightFeetValue) * 12 + int.Parse(userInput.HeightInchesValue);
            Age = int.Parse(userInput.Age);
            Gender = userInput.IsMale ? Gender.Male : Gender.Female;
            switch (userInput.ActivityLevel)
            {
                case "0":   // Sedentary
                    _activityMultiplier = 1.2;
                    break;
                case "1":   // Light
                    _activityMultiplier = 1.375;
                    break;
                case "2":   // Moderate
                    _activityMultiplier = 1.55;
                    break;
                case "3":   // Heavy
                    _activityMultiplier = 1.725;
                    break;
                case "4":   // Athlete
                    _activityMultiplier = 1.9;
                    break;
            }

            switch (userInput.LossPerWeekIndex)
            {
                case "3":   // Lose 2
                    _weightLossBasedCalorieDeficit = 1000;
                    break;
                case "2":   // Lose 1.5
                    _weightLossBasedCalorieDeficit = 750;
                    break;
                case "1":   // Lose 1
                    _weightLossBasedCalorieDeficit = 500;
                    break;
                case "0":   // Lose 0.5
                    _weightLossBasedCalorieDeficit = 250;
                    break;
                case "4":   // Maintain
                default:
                    _weightLossBasedCalorieDeficit = 0;
                    break;
            }

            switch (userInput.MacroParametersIndex)
            {
                case "0":   // Maintain
                    Macros = new MacroNutrientBreakdown
                    {
                        MacroParameters = MacroParameters.Maintain,
                        ProteinPercentage = 0.20,
                        GramsOfProtein = (int)Math.Floor(TotalDailyEnergyExpenditure * 0.20 / 4),
                        FatPercentage = 0.30,
                        GramsOfFat = (int)Math.Floor(TotalDailyEnergyExpenditure * 0.30 / 9),
                        CarbohydratePercentage = 0.50,
                        GramsOfCarbohydrates = (int)Math.Floor(TotalDailyEnergyExpenditure * 0.50 / 4)

                    };
                    _macroParameterAdjustment = 0;
                    break;
                case "1":   // Bulk
                    var adjustedTdee = TotalDailyEnergyExpenditure + 200;
                    int gramsOfProtein = (int)Math.Floor(0.8 * WeightInPounds);
                    int gramsOfFat = (int)Math.Floor(0.5 * WeightInPounds);

                    Macros = new MacroNutrientBreakdown
                    {
                        MacroParameters = MacroParameters.Bulk,
                        GramsOfProtein = gramsOfProtein,
                        GramsOfFat = gramsOfFat,
                        GramsOfCarbohydrates = (int)Math.Floor((adjustedTdee - (4 * gramsOfProtein) - (9 * gramsOfFat)) / 4)
                    };
                    _macroParameterAdjustment = 200;
                    break;
                case "2":   // Cut
                    Macros = new MacroNutrientBreakdown
                    {
                        MacroParameters = MacroParameters.Cut,
                        ProteinPercentage = 0.40,
                        GramsOfProtein = (int)Math.Floor(TotalDailyEnergyExpenditure * 0.40 / 4),
                        FatPercentage = 0.30,
                        GramsOfFat = (int)Math.Floor(TotalDailyEnergyExpenditure * 0.30 / 9),
                        CarbohydratePercentage = 0.30,
                        GramsOfCarbohydrates = (int)Math.Floor(TotalDailyEnergyExpenditure * 0.30 / 4)

                    };
                    _macroParameterAdjustment = 0;
                    break;
            }

        }
    }
}

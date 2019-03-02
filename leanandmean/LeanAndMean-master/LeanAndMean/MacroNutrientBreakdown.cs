namespace LeanAndMean
{
    public class MacroNutrientBreakdown
    {
        public MacroParameters MacroParameters { get; set; }
        public double ProteinPercentage { get; set; }
        public double CarbohydratePercentage { get; set; }
        public double FatPercentage { get; set; }

        public int GramsOfProtein { get; set; }
        public int GramsOfCarbohydrates { get; set; }
        public int GramsOfFat { get; set; }
    }
}

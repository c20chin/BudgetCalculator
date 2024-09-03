namespace BudgetCalculator.Services
{
    public class BudgetService
    {
        public double GoalSeek(double Z, double Y1, double Y2, double Hours, double OtherAdsBudget, double tolerance = 0.01)
        {
            double low = 0;
            double high = Z - Hours - OtherAdsBudget * (1 + Y1 / 100 + Y2 / 100);
            double mid = 0;

            while (high - low > tolerance)
            {
                mid = (low + high) / 2;
                double totalCost = CalculateTotalBudget(mid, Y1, Y2, Hours, OtherAdsBudget);

                if (totalCost < Z)
                    low = mid;
                else
                    high = mid;
            }

            return Math.Round(mid, 2);
        }

        private double CalculateTotalBudget(double X_target, double Y1, double Y2, double Hours, double OtherAdsBudget)
        {
            double X = X_target + OtherAdsBudget;
            double totalCost = X + (Y1 / 100) * X + (Y2 / 100) * (X_target + OtherAdsBudget) + Hours;
            return totalCost;
        }
    }
}

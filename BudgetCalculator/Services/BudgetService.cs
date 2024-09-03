namespace BudgetCalculator.Services
{
    public class BudgetService
    {
        public double GoalSeek(double Z, double Y1, double Y2, double Hours, double OtherAdsBudget, double tolerance = 0.0001)
        {
            double low = 0;
            double high = Z - Hours - OtherAdsBudget; // Maximum possible value for X_target
            double mid = 0;

            // Binary search to find the maximum X_target
            while (high - low > tolerance)
            {
                mid = (low + high) / 2;
                double totalCost = CalculateTotalBudget(mid, Y1, Y2, Hours, OtherAdsBudget);

                if (totalCost > Z)
                    high = mid; // Decrease upper bound if total cost exceeds Z
                else
                    low = mid; // Increase lower bound if total cost is within budget
            }

            return Math.Round(low, 2); // Return result rounded to 2 decimal places
        }

        private double CalculateTotalBudget(double X_target, double Y1, double Y2, double Hours, double OtherAdsBudget)
        {
            double X = OtherAdsBudget + X_target; // Total ad spend including target ad
            double totalCost = X + ((Y1 / 100) * X) + ((Y2 / 100) * X) + Hours;
            return totalCost;
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace BudgetCalculator.Models
{
    public class BudgetModel
    {
        [Required(ErrorMessage = "Total approved budget (Z) is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Total approved budget (Z) must be greater than zero.")]
        public double Z { get; set; }

        [Required(ErrorMessage = "Agency fee percentage (Y1) is required.")]
        [Range(0, 100, ErrorMessage = "Agency fee percentage (Y1) must be between 0 and 100.")]
        public double Y1 { get; set; }

        [Required(ErrorMessage = "Third-party tool fee percentage (Y2) is required.")]
        [Range(0, 100, ErrorMessage = "Third-party tool fee percentage (Y2) must be between 0 and 100.")]
        public double Y2 { get; set; }

        [Required(ErrorMessage = "Fixed cost for agency hours is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Fixed cost for agency hours must be non-negative.")]
        public double Hours { get; set; }

        [Required(ErrorMessage = "Budget for other ads is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Budget for other ads must be non-negative.")]
        public double OtherAdsBudget { get; set; }

        public double GoalSeek(double tolerance = 0.01)
        {
            double low = 0;
            double high = Z - Hours - OtherAdsBudget * (1 + Y1 / 100 + Y2 / 100);
            double mid = 0;

            while (high - low > tolerance)
            {
                mid = (low + high) / 2;
                double totalCost = CalculateTotalBudget(mid);

                if (totalCost < Z)
                    low = mid;
                else
                    high = mid;
            }

            return Math.Round(mid, 2); // Round the result to 2 decimal place
        }

        private double CalculateTotalBudget(double X_target)
        {
            double X = X_target + OtherAdsBudget;
            double totalCost = X + (Y1 / 100) * X + (Y2 / 100) * (X_target + OtherAdsBudget) + Hours;
            return totalCost;
        }
    }
}

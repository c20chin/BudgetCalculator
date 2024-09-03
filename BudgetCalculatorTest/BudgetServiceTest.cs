using System;
using Xunit;
using BudgetCalculator.Services;

namespace BudgetCalculator.Tests
{
    public class BudgetServiceTests
    {
        private readonly BudgetService _budgetService;

        public BudgetServiceTests()
        {
            _budgetService = new BudgetService();
        }

        [Theory]
        [InlineData(20000, 12, 6, 1000, 5000, 11101.69)]
        [InlineData(15000, 15, 7, 800, 4000, 7639.34)]
        [InlineData(10000, 10, 5, 500, 3000, 5260.87)]
        public void GoalSeek_ShouldReturnExpectedXTarget(double Z, double Y1, double Y2, double Hours, double OtherAdsBudget, double expectedXTarget)
        {
            // Act
            double result = _budgetService.GoalSeek(Z, Y1, Y2, Hours, OtherAdsBudget);

            // Assert
            Assert.Equal(expectedXTarget, result, 2); // Compare the result rounded to 2 decimal places
        }
    }
}

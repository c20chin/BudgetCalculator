using BudgetCalculator.Models;
using BudgetCalculator.Services;
using Microsoft.AspNetCore.Mvc;

namespace BudgetCalculator.Controllers
{
    public class BudgetController : Controller
    {
        private readonly BudgetService _budgetService;

        public BudgetController()
        {
            _budgetService = new BudgetService();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate(BudgetModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    double maxAdBudget = _budgetService.GoalSeek(model.Z, model.Y1, model.Y2, model.Hours, model.OtherAdsBudget);
                    ViewBag.MaxAdBudget = maxAdBudget;
                }
                catch (InvalidOperationException ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An unexpected error occurred. Please try again.");
                }
            }

            return View("Index", model);
        }
    }
}

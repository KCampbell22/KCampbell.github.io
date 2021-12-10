using Microsoft.AspNetCore.Mvc;
using Weekly_Salary_Calculator.Models;
namespace Weekly_Salary_Calculator.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Name = 0;
            ViewBag.Id = 0;
            ViewBag.HourlyPay = 0;
            ViewBag.HoursWorked = 0;
            ViewBag.WeeklyPay = 0;
            ViewBag.Results = " ";
            return View();
        }
    }

}
public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.WeeklyPay = 0;
        return View();
    }
    [HttpPost]
    public IActionResult Index(StudentWorkerModel model)
    {
        if (ModelState.IsValid)
        {
            model.WeeklySalary();
            ViewBag.WeeklyPay = model.WeeklyPay;

        }
        else
        {
            ViewBag.WeeklyPay = 0.0;

        }
        return View();
    }
}


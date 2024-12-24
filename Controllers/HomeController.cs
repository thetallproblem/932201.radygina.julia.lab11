using Lab11.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UsingModel()
        {
            NumOperations data = GetData();
            return View(data);
        }

        public IActionResult UsingViewData()
        {
            ViewData["data"] = GetData();
            return View();
        }
        public IActionResult UsingViewBag()
        {
            ViewBag.data = GetData();
            return View();
        }

        public IActionResult UsingServiceInjection()
        {
            return View();
        }

        public NumOperations GetData()
        {
            Random random = new Random();
            var firstNumber = random.Next() % 10;
            var secondNumber = random.Next() % 10;

            NumOperations numOperations = new NumOperations
            {
                firstNum = firstNumber,
                secondNum = secondNumber,
                summ = firstNumber + secondNumber,
                sub = firstNumber - secondNumber,
                mult = firstNumber * secondNumber,
                div = checkDivisionByZero(firstNumber, secondNumber)
            };

            return numOperations;
        }

        public int checkDivisionByZero(int first, int second)
        {
            if (second == 0)
            {
                return -1;
            }
            else 
                return first / second;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

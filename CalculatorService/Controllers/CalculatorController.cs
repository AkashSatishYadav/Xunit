using CalculatorService.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorService.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CalculatorController : Controller
    {
        private ICalculator _calculator;

        public CalculatorController(ICalculator calculator)
        {
            _calculator = calculator;
        }
        [HttpPost]
        [Route("Add")]
        public double Add(double x1, double x2)
        {
            return _calculator.Add(x1, x2);
        }
        [HttpPost]
        [Route("Divide")]
        public double Divide(double x1, double x2)
        {
            return _calculator.Divide(x1, x2);
        }
        [HttpPost]
        [Route("Multiply")]
        public double Multiply(double x1, double x2)
        {
            return _calculator.Multiply(x1, x2);
        }
        [HttpPost]
        [Route("Subtract")]
        public double Subtract(double x1, double x2)
        {
            return _calculator.Subtract(x1, x2);
        }
    }
}

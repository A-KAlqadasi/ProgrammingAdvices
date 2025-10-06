using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstRESTProject.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/MyFirstAPI")]
    [ApiController]
    public class MyFirstAPIController : ControllerBase
    {
        [HttpGet("koko1",Name ="MyName")]
        public string GetMyName()
        {
            return "My name is Abdulkareem Shawqi";
        }

        [HttpGet("koko2",Name ="YourName")]
        public string GetYourName()
        {
            return "Your name is Waleed Awn";
        }

        [HttpGet("sum/{Num1}/{Num2}")]
        public int Sum2Numbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        [HttpGet("multi/{Num1}/{Num2}")]
        public int Multi2Numbers(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
    }
}

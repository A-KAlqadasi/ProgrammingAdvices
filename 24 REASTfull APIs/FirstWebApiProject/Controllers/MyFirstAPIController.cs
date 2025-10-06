using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApiProject.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/MyFirstAPI")]
    [ApiController]
    public class MyFirstAPIController : ControllerBase
    {
        
        [HttpGet("MyName",Name ="MyName")]
        public string GetMyName()
        {
            return "My name is Abdulkareem Shawqi";
        }

        [HttpGet("YourName",Name ="YourName")]
        public string GetYourName()
        {
            return "Your name is Waleed Awn";
        }

        [HttpGet("Sum/{num1:int},{num2:int}",Name ="Sum")]
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        [HttpGet("Sum2/{num1}/{num2}", Name = "Sum2")]
        public int Sum2(int num1, int num2)
        {
            return num1 + num2;
        }

        // name and ID is important 
        [HttpGet("Sub/num1={num1},num2={num2}",Name ="Sub")]
        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        // name and ID is important 
        [HttpGet("Mul/{num1}/{num2}",Name ="Mul")]
        public int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        
        //[HttpGet("Div/num1,num2",Name ="Div")] // this is wrong the num1 nad num2 without {} will be optional 
        [HttpGet("Div/{num1}/{num2}",Name ="Div")]

        public float Div(float num1, float num2)
        {
            return num1 / num2;
        }

    }
}

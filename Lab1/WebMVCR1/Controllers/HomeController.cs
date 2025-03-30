using Microsoft.AspNetCore.Mvc;

namespace WebMVCR1.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public string Index()
        //{
        //    int hour = DateTime.Now.Hour;

        //    string Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";

        //    return "Hello from Index, and " + Greeting;
        //}

        public string Index(string hel)
        {
            int hour = DateTime.Now.Hour;

            string Greeting = hour < 12 ? "Good Morning" : "Good Afternoon" + ", " + hel;

            return Greeting;
        }

    }
}

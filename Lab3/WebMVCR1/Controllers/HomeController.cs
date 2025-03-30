using Microsoft.AspNetCore.Mvc;
using System.Text;
using WebMVCR1.Models;

namespace WebMVCR1.Controllers
{
    public class HomeController : Controller
    {
        private static PersonRepository db = new PersonRepository();

        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good day"; 
            ViewData["Mes"] = "Have a good one!";

            return View();
        }

        //public string Index(int? hel)
        //{
        //    //string res = ExeEnum();

        //    //string res = ExeStruct();

        //    //string res = StudyCsharp.SetStatus(3);

        //    //string res = StudyCsharp.ExeSwitch(StudyCsharp.SetStatus(3));

        //    //string res = StudyCsharp.GetFunction(0, 9);

        //    //string res = ExeFactorial(hel);

        //    //string res = ExeTriangle();

        //    //string res = ExeCircle();

        //    //string res = ExePolim();

        //    string res = ExeCollection();

        //    return res;
        //}

        //public ContentResult Index()
        //{
        //    string result = ExeCollection();

        //    return Content(result, "text/html");
        //}

        public string ExeEnum()
        {
            AccountType goldAccount;
            AccountType platinumAccount;

            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            string res1 = String.Format("Bank account type {0}", goldAccount);
            string res2 = String.Format("Bank account type  {0}", platinumAccount);

            string res = res1 + "<p>" + res2;
            //string res = "<html><body>" + res1 + "<p>" + res2 + "</body></html>";

            return res;
        }

        public string ExeStruct()
        {
            BankAccount goldBankAccount;

            goldBankAccount.accNo = 123;
            goldBankAccount.accBal = (decimal)3200.00;
            goldBankAccount.accType = AccountType.Checking;

            //string res1 = String.Format("Account No {0} balance {1} and type {2}", goldBankAccount.accNo, goldBankAccount.accBal, goldBankAccount.accType);

            //string res = goldBankAccount.ToString();
            string res = String.Format("Bank account information: {0}", goldBankAccount);

            string res1 = $" [{goldBankAccount.accNo}]";

            return res + res1;
        }

        public string ExeFactorial(int x)
        {
            int f;
            bool ok = StudyCsharp.Factorial(x, out f);

            if (ok)
                return String.Format("Factorial of {0} is {1}", x, f);
            else
                return "Cannot calculate factorial";
        }

        public string ExeTriangle()
        {
            Triangle tr1 = new Triangle(3, 5, 6);

            string sq1 = String.Format("The area of the figure {0} is: {1:0.##}", tr1.Name, tr1.Area);

            return sq1;
        }

        public string ExeCircle()
        {
            Circle cir1 = new Circle(3);

            string sq = String.Format("Aread of shape named {0} is: {1:0.##}", cir1.Name, cir1.Area);

            return sq;
        }

        public string ExePolim()
        {
            StringBuilder str = new StringBuilder();

            Shape[] sh = {
                 new Triangle(1,2,3),
                 new Circle(5),
                 new Triangle(5,6,8)
            };

            foreach (Shape item in sh)
            {
                str.AppendFormat("This is shape of {0}", item.Name + "<p>");
            }

            return str.ToString();
        }

        public string ExeCollection()
        {
            List<Circle> cirs = new List<Circle>
            {
                new Circle(12),
                new Circle(5),
                new Circle(15),
                new Circle(6)
            };

            cirs.Add(new Circle(7));

            cirs.Sort();

            StringBuilder str = new StringBuilder();

            foreach (Shape item in cirs)
            {
                str.AppendFormat("This is shape of {0}", item.Name + "<p>");
            }

            return str.ToString();
        }

        [HttpGet]
        public ViewResult InputData()
        {
            return View();
        }

        [HttpPost]
        public ViewResult InputData(Person p)
        {
            db.AddResponse(p);

            return View("Hello", p);
        }

        public ViewResult OutputData()
        {
            ViewBag.Pers = db.GetAllResponses;
            ViewBag.Count = db.NumberOfPerson;

            return View("ListPerson");
        }
    }
}

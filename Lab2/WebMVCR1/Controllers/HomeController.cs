using Microsoft.AspNetCore.Mvc;
using WebMVCR1.Models;

namespace WebMVCR1.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public string Index(string hel)
        {
            //string res = ExeEnum();

            string res = ExeStruct();

            return res;
        }

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
    }
}

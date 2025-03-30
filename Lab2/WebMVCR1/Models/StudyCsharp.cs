namespace WebMVCR1.Models
{
    public class StudyCsharp
    {
    }

    public enum AccountType
    {
        Checking,
        Deposit
    }

    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;

        public override string ToString()
        {
            string res = String.Format("Account No {0} balance {1} and type {2}", accNo, accBal, accType);
            
            return res;
            //return base.ToString();
        }
    }
}

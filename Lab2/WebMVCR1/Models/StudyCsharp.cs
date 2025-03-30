using System.Text;

namespace WebMVCR1.Models
{
    public class StudyCsharp
    {
        // 
        public static string SetStatus(int age)
        {
            string status = "junior developer";

            if ((age > 2) && (age < 7)) status = "middle developer";
            else if ((age >= 7) && (age < 15)) status = "senior developer";
            else if ((age >= 15)) status = "sensei";

            return status;
        }

        public static string ExeSwitch(string status)
        {
            string res;

            switch (status)
            {
                case "junior developer":
                    res = "Learn more!"; break;
                case "middle developer":
                    res = "Get more experience!"; break;
                case "senior developer":
                    res = "Manage others!"; break;
                case "sensei":
                    res = "Teach others?!"; break;

                default:
                    res = "I don't know what to do.";
                    break;
            }

            return res;
        }

        public static string GetFunction(double x1, double x2)
        {
            StringBuilder str = new StringBuilder();

            double x = x1;

            do
            {
                str.AppendFormat("x = {0:0.##} : y = {1:0.##};<br> ", x, Math.Pow(x, 3));

                x = x + 0.5;
            }
            while (x <= x2);

            return str.ToString();
        }

        public static bool Factorial(int n, out int answer)
        {
            int k;
            int f;
            bool ok = true;

            if (n < 0)
                ok = false;
            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)
            {
                f = 0;
                ok = false;
            }
            answer = f;
            return ok;
        }
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

    public class Triangle : Shape
    {
        //public double Sta { get; set; }

        // Sta > St

        public double Stb { get; set; }
        public double Stc { get; set; }

        //public string Name
        //{
        //    get
        //    {
        //        return String.Format("\"Triangle with sides {0}, {1} and {2}\"", Sta, Stb, Stc);
        //    }
        //}
        public override string Name => String.Format("\"Triangle with sides {0}, {1} and {2}\"", St, Stb, Stc);

        //public double Perimeter
        //{
        //    get
        //    {
        //        double p = Sta + Stb + Stc;
        //        return p;
        //    }
        //}
        public double Perimeter => Math.Round(St + Stb + Stc);

        public double Area
        {
            get
            {
                double sq = Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - St) * (Perimeter / 2 - Stb) * (Perimeter / 2 - Stc));
                return sq;
            }
        }

        public Triangle(double a, double b, double c)
        {
            St = a;
            Stb = b;
            Stc = c;
        }
    }

    public class Circle : Shape
    {
        //public double St { get; set; }

        // override
        public override string Name
        {
            get
            {
                return String.Format("\"Circle with radius {0}\"", St);
            }
        }
        public Circle(double a)
        {
            St = a;
        }
        public double Dlina
        {
            get
            {
                double p = 2 * Math.PI * St;
                return p;
            }
        }
        public double Area
        {
            get
            {
                double sq = Math.PI * St * St;
                return sq;
            }
        }
    }

    public class Shape
    {
        public double St { get; set; }

        virtual public string Name
        {
            get { return String.Format("\"Shape\""); }
        }
    }
}

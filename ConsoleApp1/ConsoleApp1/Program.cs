using System;
using Wrox.ProCSharp.VenusBank;
using Worx.ProCsharp.JupiterBank;
using Wrox.ProCSharp;

namespace Wrox.ProCSharp
{

    public interface IBankAccount
    {
        void PayIn(decimal amount);
        bool Withdraw(decimal amount);
        decimal Balance { get; }
    }
    class MainnEntryPoint
    {
        static void Main()
        {
            IBankAccount venusAccount = new SaverAccount();
            IBankAccount jupiterAccount = new GoidAccount();
            venusAccount.PayIn(200);
            venusAccount.Withdraw(100);
            Console.WriteLine(venusAccount.ToString());
            jupiterAccount.PayIn(500);
            jupiterAccount.Withdraw(600);
            jupiterAccount.Withdraw(100);
            Console.WriteLine(jupiterAccount.ToString());
            /*------*/
        }
    }
}

namespace Wrox.ProCSharp.VenusBank
{


    public class SaverAccount : IBankAccount
    {
        private decimal balance;
        public void PayIn(decimal amount)
        {
            balance += amount;
        }
        public bool Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            Console.WriteLine("withdrawal attempt failed.");
            return false;
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
        }

        decimal IBankAccount.Balance => throw new NotImplementedException();

        public override string ToString()
        {
            return string.Format("Venus Bank Saver:Balance=(0.6:C", balance);
        }

    }
}
namespace Worx.ProCsharp.JupiterBank
{
    public class GoidAccount : IBankAccount
    {


        private decimal balance;
        public void PayIn(decimal amount)
        {
            balance += amount;
        }
        public bool Withdraw(decimal amount)
           {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            Console.WriteLine("withdrawal attempt failed.");
            return false;
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
        }

        decimal IBankAccount.Balance => throw new NotImplementedException();

        public override string ToString()
        {
            return string.Format("Venus Bank Saver:Balance=(0.6:C", balance);
        }

    }
}
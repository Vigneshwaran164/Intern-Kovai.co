using System ;

namespace intern_task.oops
{
    class Hdfc : Bank
    {
        private double depositAmount;

        public double DepositAmount{
            get {return depositAmount ;}
            set {depositAmount = value ;}

        }
        public override void getBalance()
        {
            Console.WriteLine($"The Current Balance in your HDFC Account is {depositAmount}");
        }
    }
}
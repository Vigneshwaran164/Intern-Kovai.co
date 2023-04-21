using System ;

namespace intern_task.oops
{
    class Sbi : Bank
    {
        private double depositAmount;

        public double DepositAmount{
            get {return depositAmount ;}
            set {depositAmount = value ;}

        }
        public override void getBalance()
        {
            Console.WriteLine($"The Current Balance in your SBI Account is {depositAmount}");
        }
    }
}
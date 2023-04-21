using System ;

namespace intern_task.oops
{
    class BankContainer
    {
        
        public static void Main(string[] args)
        {
            //created object for the sbi class

            Sbi sbiUser = new Sbi();

            //setting the DepositAmount property in sbi class

            sbiUser.DepositAmount = 2000;
            sbiUser.getBalance();

            Hdfc hdfcUser = new Hdfc();

            //setting the DepositAmount property in hdfc class

            hdfcUser.DepositAmount = 3000 ;
            hdfcUser.getBalance();

            Canara canaraUser = new Canara();

            //setting the DepositAmount property in canara class

            canaraUser.DepositAmount = 5000 ;
            canaraUser.getBalance();

            
        }   

        
        
    }
}
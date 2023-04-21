using System ;

namespace intern_task.oops
{
    class StallContainer
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose Stall Type");
            Console.WriteLine("1)Gold Stall");
            Console.WriteLine("2)Premium Stall");
            Console.WriteLine("3)Executive Stall");

            int choosestallType = Convert.ToInt32(Console.ReadLine());

            switch(choosestallType)
            {

                case 1:
                    Console.WriteLine("Enter Stall details in comma separated(Stall Name,Stall Cost,Owner Name,Number of TV sets)");
                    string goldStallDetails = Console.ReadLine();
                    string[] seperatedGoldStallDetails = goldStallDetails.Split(",");
                    string stallNameOfGoldStall = seperatedGoldStallDetails[0];
                    int costOfGoldStall = Convert.ToInt32(seperatedGoldStallDetails[1]);
                    string ownerNameOfGoldStall = seperatedGoldStallDetails[2];
                    int tvSetOfGoldStall = Convert.ToInt32(seperatedGoldStallDetails[3]);
                    
                    GoldStall mechanic = new GoldStall( stallNameOfGoldStall , costOfGoldStall , ownerNameOfGoldStall , tvSetOfGoldStall);
                    mechanic.display();
                    break;

                case 2:
                    Console.WriteLine("Enter Stall details in comma separated(Stall Name,Stall Cost,Owner Name,Projectors)");
                    string premiumStallDetails = Console.ReadLine();
                    string[] seperatedPremiumStallDetails = premiumStallDetails.Split(",");
                    string stallNameOfPremiumStall = seperatedPremiumStallDetails[0];
                    int costOfPremiumStall = Convert.ToInt32(seperatedPremiumStallDetails[1]);
                    string ownerNameOfPremiumStall = seperatedPremiumStallDetails[2];
                    int projectorsOfPremiumStall = Convert.ToInt32(seperatedPremiumStallDetails[3]);
                    
                    GoldStall knittingPlaza = new GoldStall( stallNameOfPremiumStall , costOfPremiumStall , ownerNameOfPremiumStall , projectorsOfPremiumStall);
                    knittingPlaza.display();
                    break;
                
                case 3:
                    Console.WriteLine("Enter Stall details in comma separated(Stall Name,Stall Cost,Owner Name,Number Of Screens)");
                    string executiveStallDetails = Console.ReadLine();
                    string[] seperatedExecutiveStallDetails = executiveStallDetails.Split(",");
                    string stallNameOfExecutiveStall = seperatedExecutiveStallDetails[0];
                    int costOfExecutiveStall = Convert.ToInt32(seperatedExecutiveStallDetails[1]);
                    string ownerNameOfExecutiveStall = seperatedExecutiveStallDetails[2];
                    int screenOfExecutiveStall = Convert.ToInt32(seperatedExecutiveStallDetails[3]);
                    
                    GoldStall fruitsHunt = new GoldStall( stallNameOfExecutiveStall , costOfExecutiveStall , ownerNameOfExecutiveStall , screenOfExecutiveStall);
                    fruitsHunt.display();
                    break;
            }
        }
    }
}
using System ;

namespace intern_task.oops
{
    class PremiumStall : IStall
    {
        private string stallName ;
        private int cost ;
        private string ownerName ;

        private int projector ;

        public PremiumStall (string stallName , int cost , string ownerName , int projector )
        {
            this.stallName = stallName ;
            this.cost = cost ;
            this.ownerName = ownerName ;
            this.projector = projector ;
        }
        public void display()
        {
            
            Console.WriteLine($"Stall Name : {stallName}");
            Console.WriteLine($"Cost : {cost} Rs");
            Console.WriteLine($"Owner Name : {ownerName}");
            Console.WriteLine($"Number of Projectors : {projector}");
            
        }

    }
}
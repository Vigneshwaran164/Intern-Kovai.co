using System ;

namespace intern_task.oops
{
    class GoldStall : IStall
    {
        private string stallName ;
        private int cost ;

        private string ownerName ;

        private int tvSet ;

        public GoldStall(string stallName , int cost , string ownerName , int tvSet )
        {
            this.stallName = stallName ;
            this.cost = cost ;
            this.ownerName = ownerName ;
            this.tvSet = tvSet ;
        }
        public void display()
        {
            Console.WriteLine($"Stall Name : {stallName}");
            Console.WriteLine($"Cost : {cost} Rs");
            Console.WriteLine($"Owner Name : {ownerName}");
            Console.WriteLine($"Number of TV sets : {tvSet}");

        }

    }

}
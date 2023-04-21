using System ;

namespace intern_task.oops
{
    class ExecutiveStall : IStall
    {
        private string stallName ;
        private int cost ;

        private string ownerName ;

        private int screen ;

        public ExecutiveStall(string stallName , int cost , string ownerName , int screen )
        {
            this.stallName = stallName ;
            this.cost = cost ;
            this.ownerName = ownerName ;
            this.screen = screen ;
        }
        public void display()
        {
            Console.WriteLine($"Stall Name : {stallName}");
            Console.WriteLine($"Cost : {cost} Rs ");
            Console.WriteLine($"Owner Name : {ownerName}");
            Console.WriteLine($"Number of Screens : {screen}");

        }

    }
}
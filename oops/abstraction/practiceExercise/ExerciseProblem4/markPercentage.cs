using System ;

namespace intern_task.oops
{
    class MarksPercentage
    {
        
        public static void Main(string[] args)
        {

            //created object for the studentA class and passes the marks in the constructor 

            StudentA Rohit = new StudentA(78 , 85 , 95);
            float percentageOfRohit = Rohit.getPercentage();
            Console.WriteLine($"The Percentage of Student named Rohit is {percentageOfRohit} %");

            //created object for the studentB class and passes the marks in the constructor 

            StudentB Sachin = new StudentB(90 , 95 , 100, 100 ); 
            float percentageOfSachin = Sachin.getPercentage();
            Console.WriteLine($"The Percentage of Student named Sachin is {percentageOfSachin} %");
        
        }
        
        
    }
}
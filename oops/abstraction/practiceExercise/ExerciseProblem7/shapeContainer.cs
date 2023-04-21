
using System ;
 
namespace intern_task.oops.abstraction.problem7
{
    class ShapeContainer 
    {
        
        public static void Main(string[] args)
        {
            //creates object for the Area Class

            Shape squareBox = new Area();

            //calls the SquareArea method in Area Class with values passing in constructor

            double areaOfSquareBox = squareBox.SquareArea(4.2F);
            Console.WriteLine($"The Area of the Square Box is {areaOfSquareBox}");

            Shape footballground = new Area();

            //calls the RectangleArea method in Area Class with values passing in constructor

            double areaOfFootballground = footballground.RectangleArea(40F,60F);
            Console.WriteLine($"The Area of the Football Ground is {areaOfFootballground}");

            Shape cricketground = new Area();

            //calls the CircleArea method in Area Class with values passing in constructor

            double areaOfCricketground = cricketground.CircleArea(45F);
            Console.WriteLine($"The Area of the Cricket Ground is {areaOfCricketground}");




        }
        
    }
}
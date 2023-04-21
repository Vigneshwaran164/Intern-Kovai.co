
using System ; 

namespace intern_task.oops
{
    class ShapeContainer
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("List Of Shapes:");
            Console.WriteLine("1.Circle");
            Console.WriteLine("2.Rectangle");
            Console.WriteLine("3.Square");

            Console.WriteLine("Enter your choice:");

            //reading the chice from the user

            int choice = Convert.ToInt32(Console.ReadLine());
            

            switch(choice)
            {
                //case 1 is for circle

                case 1:
                    Console.WriteLine("Enter the Radius of the Circle : ");
                    float radius = Single.Parse(Console.ReadLine());

                    //created object for square and passing the value through the constructor 

                    Circle perimeterOfCircle = new Circle(radius);
                    
                    //calling the method to find the perimeter of circle 
                    //and storing it in variable 

                    double circlesPerimeter = perimeterOfCircle.calculatePerimeter();
                    Console.WriteLine($"The Perimeter of Circle is {circlesPerimeter}"); 
                    break;
                
                //case 2 is for Rectangle
                case 2:
                    Console.WriteLine("Enter the Length of the Rectangle");
                    float length = Single.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the breadth of the Rectangle");
                    float breadth = Single.Parse(Console.ReadLine());

                    //created object for square and passing the value through the constructor 

                    Rectangle perimeterOfRectangle = new Rectangle(length,breadth);

                    //calling the method to find the perimeter of rectangle
                    //and storing it in variable 

                    double rectanglesPerimeter = perimeterOfRectangle.calculatePerimeter();
                    Console.WriteLine($"The Perimeter of Rectangle is {rectanglesPerimeter}");
                    break;
                
                //case 3 is for Square
                case 3:
                    Console.WriteLine("Enter the Side of the Square : ");
                    float side = Single.Parse(Console.ReadLine());

                    //created object for square and passing the value through the constructor 

                    Square perimeterOfSquare = new Square(side);

                    //calling the method to find the perimeter of square
                    //and storing it in variable 

                    double squaresPerimeter = perimeterOfSquare.calculatePerimeter();
                    Console.WriteLine($"The Perimeter of Square is {squaresPerimeter}"); 
                    break;
                
                //default case if the choice are invalid 

                default:
                    Console.WriteLine("Please Choose the Choice Between the Range 1 to 3!");
                    break;

                    
            }

        }
        
    }
}
using System ;

namespace intern_task.oops.abstraction.problem7
{
    class Area : Shape
    {
        public override double CircleArea(float radius)
        {
            double areaOfCircle = Math.Round(3.14 * (radius * radius) , 2) ;
            return areaOfCircle ; 
        }

        public override double RectangleArea(float length, float breadth)
        {
            double areaOfRectangle = Math.Round(length * breadth ,2) ;
            return areaOfRectangle ;
        }

        public override double SquareArea(float side)
        {
            double areaOfSquare = Math.Round(side * side , 2);
            return areaOfSquare ;
        }
    }
}
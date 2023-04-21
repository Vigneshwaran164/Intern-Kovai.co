using System ;

namespace intern_task.oops.abstraction.problem7
{
    abstract class Shape
    {
        public abstract double RectangleArea(float length , float breadth );

        public abstract double SquareArea(float side);

        public abstract double CircleArea(float radius);

    } 
}
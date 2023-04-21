
using System ;

namespace intern_task.oops
{
    class Square : Shape
    {
        private float side ;

        public Square(float side)
        {
            this.side = side ;

        }

        public override double calculatePerimeter()
        {
            double result = Math.Round(4*side,2);
            return result ;
        }

    }
}
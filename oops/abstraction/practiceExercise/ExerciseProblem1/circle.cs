
using System ;

namespace intern_task.oops
{
    class Circle : Shape
    {
        private float radius;

        public Circle(float radius)
        {
            this.radius = radius ;
            
        }

       
        public override double calculatePerimeter()
        {
            double result = Math.Round(2*PI*radius,2);

            return result ;
            
        }


    }
}
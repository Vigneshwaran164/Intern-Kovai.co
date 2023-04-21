using System ; 

namespace intern_task.oops
{
    class Rectangle : Shape
    {
        private float length ; 
        private float breadth ;

        public Rectangle(float length , float breadth)
        {
            this.length = length ;
            this.breadth = breadth ;

        }
        public override double calculatePerimeter()
        {
            double result = 2*(length+breadth);
            return result ;
        }



    }
}
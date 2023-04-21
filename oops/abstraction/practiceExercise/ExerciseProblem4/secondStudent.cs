using System ;

namespace intern_task.oops
{
    class StudentB : Marks
    {
        private float maths;
        private float english;
        private float tamil;
        private float computerScience ;

        public StudentB(float maths , float english , float tamil , float computerScience )
        {
            this.maths = maths ;
            this.english = english ;
            this.tamil = tamil ;
            this.computerScience = computerScience ;

        }
        public override float getPercentage()
        {
            float percentage = (( maths + tamil + english + computerScience )/400)*100;
            double result = Math.Round(Convert.ToDouble(percentage),2);
            percentage = Convert.ToSingle(result);
            return percentage ;

            
        }

    }
}
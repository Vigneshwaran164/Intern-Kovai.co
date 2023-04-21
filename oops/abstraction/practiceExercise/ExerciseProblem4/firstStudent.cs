using System ;

namespace intern_task.oops
{
    class StudentA : Marks
    {
        public float maths;
        public float english;
        public float tamil;

        public StudentA(float maths , float english , float tamil)
        {
            this.maths = maths ;
            this.english = english ;
            this.tamil = tamil ;

        }
        public override float getPercentage()
        {
            float percentage = (( maths + tamil + english ) / 300) * 100;
            double result = Math.Round(Convert.ToDouble(percentage),2);
            percentage = Convert.ToSingle(result);
            return percentage;
        
        }

    }
}
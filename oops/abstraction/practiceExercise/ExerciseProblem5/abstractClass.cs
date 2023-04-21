using System ;

namespace intern_task.oops
{
    abstract class AbstractClass 
    {
        public AbstractClass()
        {
            Console.WriteLine("This is constructor of abstract class");
        }
        public abstract void abstractMethod();

        public void normalMethod()
        {
            Console.WriteLine("This is a normal method in abstract class ");
        }

    }
}
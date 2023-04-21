using System;

namespace intern_task.oops
{
    class Test
    {
        
        public static void Main(string[] args)
        {
            //creating object for subClass
            //while creating this object the constructor in abstract class gets called first as subclass extending parent abstract class

            SubClass testObject = new SubClass();
            
            //calls the overriden method in subclass
            testObject.abstractMethod();

            //calls the non abstract method in AbstractClass
            testObject.normalMethod();
        }
        
    }
}
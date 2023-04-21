using System;

namespace intern_task.oops
{
    class SecondMessage : ParentMessage
    {
        public override void message()
        {
            Console.WriteLine("This is the second subclass");
        }

    }
}
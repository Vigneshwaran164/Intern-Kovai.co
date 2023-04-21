using System ;

namespace intern_task.oops
{
    class FirstMessage : ParentMessage
    {
        public override void message()
        {
            Console.WriteLine("This is first subclass");
        }

    }
}
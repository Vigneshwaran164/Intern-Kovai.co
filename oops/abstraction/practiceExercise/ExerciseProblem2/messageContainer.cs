
using System ;

namespace intern_task.oops
{
    class MessageContainer
    {
        
        public static void Main(string[] args)
        {
            //creating object for FirstMessage Class

            ParentMessage firstMessage = new FirstMessage();

            //calling the overriden message method in FirstMessage class

            firstMessage.message();

            //creating object for SecondMessage Class

            ParentMessage secondMessage = new SecondMessage();

            //calling the overriden message method in FirstMessage class

            secondMessage.message();
        }
        
    }
}
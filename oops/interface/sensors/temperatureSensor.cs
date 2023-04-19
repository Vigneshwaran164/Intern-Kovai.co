using System ;
 
namespace intern_task.oops
{
    class TempertureSensor : IDevice
    {
        private bool connected ;
        private double temperature ;
        public void Connect()
        {
            connected = true ;
            Console.WriteLine($"The Devics is Connect Successfully!");
            
        }

        public void Disconnect()
        {
            connected = false ;
            Console.WriteLine($"The Device is Disconnected Successfully!");
        }

        public void GetData()
        {
            Random random = new Random();
            if(connected)
            {
                temperature = Math.Round(random.NextDouble()*50,2);
                Console.WriteLine($"The Temperature of the Device is {temperature}");
            }
            else
            {
                Console.WriteLine("Oops!The Device is Not in Connection");
            }
        }
    }
}
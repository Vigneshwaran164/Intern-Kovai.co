using System;

namespace intern_task.oops
{
    class Sensor
    {
        static void Main(string[] arggs)
        {
            //created object for the Temperature Sensor 
            
            IDevice temperatureSensor = new TempertureSensor();
            temperatureSensor.Connect();
            temperatureSensor.GetData();
            temperatureSensor.Disconnect();

            
        }
    }
}
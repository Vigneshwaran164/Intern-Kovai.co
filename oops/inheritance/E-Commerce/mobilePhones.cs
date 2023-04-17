using System ;

namespace intern_task.oops.inheritance
{
    //MobilePhone class derived from parent class "product"
    class MobilePhone : Product
    {
        private string modelName ;

        private string batteryCapacity ;
 

        public string ModelName { 
            get { return modelName ; }
            set { modelName = value; }
        }

        public string BatteryCapacity { 
            get { return batteryCapacity ; }
            set { batteryCapacity = value ;}
        }

  

        public void phoneDetails()
        {
            Console.WriteLine($"The type of Product : {base.ProductType}");
            Console.WriteLine($"The Product Price is {base.ProductPrice}");
            Console.WriteLine($"{base.ProductDescription}");
            Console.WriteLine($"The Mobile Phone model is {modelName}");
            Console.WriteLine($"The Mobile Phone's battery capacity is {batteryCapacity}");
           

        }





    }
}
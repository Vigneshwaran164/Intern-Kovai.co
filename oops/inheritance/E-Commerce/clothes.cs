using System ;

namespace intern_task.oops.inheritance
{

    //clothes class derived from parent class "product"
    class Clothes : Product
    {
        //defining fields for the clothes
        private string clothSize ;
        private string clothMaterial ;
        //declaring properties for the clothes class

        public string ClothSize {
            get { return clothSize ;}
            set { clothSize = value ;}
        }

        public string ClothMaterial {
            get { return clothMaterial ;}
            set { clothMaterial = value ;}
        }

        public void ClotheDetails()
        {
            Console.WriteLine($"The type of Product : {base.ProductType}");
            Console.WriteLine($"The Product Price is {base.ProductPrice}");
            Console.WriteLine($"{base.ProductDescription}");
            Console.WriteLine($"size of the cloth is {clothSize}");
            Console.WriteLine($"The Material of the clothe is {clothMaterial}");

        }





    }
}
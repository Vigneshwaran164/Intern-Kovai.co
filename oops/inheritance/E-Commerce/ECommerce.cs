using System ;
 
namespace intern_task.oops.inheritance
{
    class ECommerce
    {
        static void Main(string[] args)
        {

            //created clothe object for clothes class 
            Clothes clothe = new Clothes();
            clothe.ProductType = "Dress";
            clothe.ProductPrice = 1200 ;
            clothe.ProductDescription = "It is a denim styled one . This one makes you more stylish ";
            clothe.ClothMaterial = "Denim";
            clothe.ClothSize ="M";

            clothe.ClotheDetails();

            //created android object for mobilephone class

            MobilePhone android = new MobilePhone();
            android.ProductType = "Mobile Phone";
            android.ProductDescription = "it has elegant look and the colors available are red , blue , green";
            android.ProductPrice = 20000;
            android.ModelName = "Xiomi";
            android.BatteryCapacity = "4000Mah";
           

            android.phoneDetails();
            
            




        }
    }
}
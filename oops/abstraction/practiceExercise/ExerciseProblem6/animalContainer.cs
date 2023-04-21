using System ;

namespace intern_task.oops
{
    class AnimalContainer
    {
        

        public static void Main(string[] args)
        {

            //created object for Dog Class 

            Animal labrador = new Dog();

            //call the Dogs method in Dog Class
            labrador.Dogs();

            //created bobtail object for Cat Class

            Animal bobtail = new Cat();
            bobtail.Cats();
        }
        

    }
}
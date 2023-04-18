using System ;

namespace List
{
    class List
    {
        static void Main (string[] args)
        {
            List <string> nameOfEmployee = new List<string>();

            nameOfEmployee.Add("Ava");
            nameOfEmployee.Add("Adam");
            nameOfEmployee.Add("Alice");
            nameOfEmployee.Add("Kevin");
            nameOfEmployee.Add("Mark");

            Console.WriteLine("The list of names is ");
            foreach(var name in nameOfEmployee)
            {
                Console.WriteLine($"{name} ");
            }
            //Remove a name from the list

            nameOfEmployee.Remove("Alice");

            //list after removing the Alice
            Console.WriteLine("The updated name of the list is ");
            foreach(var name in nameOfEmployee)
            {
                Console.WriteLine($"{name} ");
            }

            //check if the name is present in the list

            bool containsAlice = nameOfEmployee.Contains("Alice");

            Console.WriteLine($"The list contains Alice is {containsAlice}.");

            //sort the list

            nameOfEmployee.Sort();

            //list looks like after sorting

            foreach(var name in nameOfEmployee)
            {
                Console.WriteLine($"{name} ");
            }



        }
        

    }
}

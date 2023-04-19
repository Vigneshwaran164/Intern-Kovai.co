using System ;
namespace intern_task.oops
{

    public abstract class DataAccessLayer
    {
        public void nonAbstractMethod(){
            Console.WriteLine("Hi Im an non abstract method");
        }
        public abstract void Insert(string data);
        public abstract void Update(string oldData , string updatedData);

        public abstract void Delete(string data);

        public abstract void DisplayData();
    }
}
using System;

using System.Collections ;

namespace intern_task.oops
{


    class MySqlDataAccessLayer : DataAccessLayer 
    {
        //creating Arraylist to store employeeDetails
        private ArrayList EmployeeDetails ;
        public MySqlDataAccessLayer()
        {
            EmployeeDetails = new ArrayList();
            
        }
        //Delete method in abstract DataAccessLayer class is overriden in mySqlDataAccessLayer Class
        public override void Delete(string data)
        {
            EmployeeDetails.Remove(data);        


        }

        //Insert method in abstract DataAccessLayer class is overriden in mySqlDataAccessLayer Class
        public override void Insert(string data)
        {
            EmployeeDetails.Add(data);
            
        }

        //Update method in abstract DataAccessLayer class is overriden in mySqlDataAccessLayer Class
        public override void Update(string oldData , string updatedData)
        {
            int oldDataPosition = EmployeeDetails.IndexOf(oldData);
            EmployeeDetails.RemoveAt(oldDataPosition);
            EmployeeDetails.Insert(oldDataPosition , updatedData);
            
        }

        //DisplayData method in abstract DataAccessLayer class is overriden in mySqlDataAccessLayer Class
        public override void DisplayData()
        {
            Console.WriteLine("The Data that are currently available in the MySql database are :");

            foreach(var currentData in EmployeeDetails)
            {
                Console.WriteLine($"{currentData} ");
            }
            
        }
    }
}
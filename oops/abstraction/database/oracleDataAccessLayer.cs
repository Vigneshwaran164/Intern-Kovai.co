using System;

using System.Collections ;
namespace intern_task.oops
{

//OracleDataAccessLayer class implements DataAccessLayer abstract class
    class OracleDataAccessLayer : DataAccessLayer 
    {
        //creating arrayList to store the employee details
        private ArrayList EmployeeDetails ;
        public OracleDataAccessLayer()
        {
            EmployeeDetails = new ArrayList();
            
        }

        //Delete method in abstract DataAccessLayer class is overriden in OracleDataAccessLayer Class
        public override void Delete(string data)
        {
            EmployeeDetails.Remove(data);        

        }

        //Insert method in abstract DataAccessLayer class is overriden in OracleDataAccessLayer Class
        public override void Insert(string data)
        {
            EmployeeDetails.Add(data);
            
        }

        //Update method in abstract DataAccessLayer class is overriden in OracleDataAccessLayer Class
        public override void Update(string oldData , string updatedData)
        {
            int oldDataPosition = EmployeeDetails.IndexOf(oldData);
            EmployeeDetails.RemoveAt(oldDataPosition);
            EmployeeDetails.Insert(oldDataPosition , updatedData);
            
        }
        //DisplayData method in abstract DataAccessLayer class is overriden in OracleDataAccessLayer Class
        public override void DisplayData()
        {
            Console.WriteLine("The Data that are currently available in the databse are :");

            foreach(var currentData in EmployeeDetails)
            {
                Console.WriteLine($"{currentData} ");
            }
            
        }
    }
}
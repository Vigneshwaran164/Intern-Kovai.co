
using System ;

namespace intern_task.oops.inheritance
{
    //student class is inheriting the parent class user
    class Student : User 
    {
        //fields required in student
        private string studentId ; 
        private string department ; 

        public string StudentId
        {
            get { return studentId ; }
            set { studentId = value ; }

        } 
        public string Department
        {
            get { return department ; }
            set { department = value ; }

        } 
        public void studentDetails()
        {
            Console.WriteLine($"The Student name is {base.Name}");
            Console.WriteLine($"The {base.Name}'s email is {base.Email}");
            Console.WriteLine($"The {base.Name}'s id is {studentId}");
            Console.WriteLine($"The {base.Name} department is {department}");
        }
    }
}
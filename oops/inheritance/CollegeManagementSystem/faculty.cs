
using System ;

namespace intern_task.oops.inheritance
{
    //faculty class is inheriting user class
    class Faculty : User 
    {
        //fields in faculty
        private string facultyId ; 
        private string department ; 

        //properties in faculty 

        public string FacultyId
        {
            get { return facultyId ; }
            set { facultyId = value ; }

        } 
        public string Department
        {
            get { return department ; }
            set { department = value ; }

        } 
        public void facultyDetails()
        {
            Console.WriteLine($"The Faculty name is {base.Name}");
            Console.WriteLine($"The {base.Name}'s email is {base.Email}");
            Console.WriteLine($"The {base.Name}'s id is {facultyId}");
            Console.WriteLine($"The {base.Name} department is {department}");
        }
    }
}
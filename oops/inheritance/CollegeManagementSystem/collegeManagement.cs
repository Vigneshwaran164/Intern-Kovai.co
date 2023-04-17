using System;

namespace intern_task.oops.inheritance
{
    class College{
        static void Main(String[] args)

        {
            //created object for student class

            Student student1 = new Student();
            student1.Name = "Vigneshwaran R" ;
            student1.Email = "vickie1045@gmail.com" ;
            student1.Address = "abc city" ;
            student1.StudentId = "123" ;
            student1.Department = "Cse" ; 

            student1.studentDetails();

             //created object for faculty class

            Faculty  faculty1 =  new Faculty();
            faculty1.Name = "rohit" ;
            faculty1.Email = "rohit45@gmail.com" ;
            faculty1.Address = "xyz city" ;
            faculty1.FacultyId = "456" ;
            faculty1.Department = "Cse" ;

            faculty1.facultyDetails();
            
            

            

            
            
        }
    }
}
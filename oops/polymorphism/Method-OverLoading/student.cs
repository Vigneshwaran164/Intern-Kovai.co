using System ;

class Student
{
    //the method named displayName are overloaded
    public void displayName (string firstName , string middleName , string lastName)
    {

        Console.WriteLine($"Student first name is {firstName} , middle name is {middleName} , last name is {lastName}");

    }
     public void displayName (string firstName , string lastName)
    {
        Console.WriteLine($"Student first name is {firstName} ,last name is {lastName}");

    }
    


}
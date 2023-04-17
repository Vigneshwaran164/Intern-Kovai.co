using System;
class overloading 
{
    public static void Main(string[] args)
    {
        //object having firstname and lastname
        Student vignesh = new Student();
        vignesh.displayName("Vigneshwaran","Rajendran");

        //object having firstname,mmiddlename,lastname
        Student sachin = new Student();
        sachin.displayName("Sachin","Ramesh","Tendulkar");
    }

}
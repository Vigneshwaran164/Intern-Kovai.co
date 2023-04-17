using System;

//hourlyclass extending parent class named Monthly Employee
class HourlyEmployee : MonthlyEmployee
{


   //This method is overrides
    public override void calculatePay ()
    {
        
        Console.WriteLine($"The salaray of the employee Per Hour is 500");
        
        
    }
  

}
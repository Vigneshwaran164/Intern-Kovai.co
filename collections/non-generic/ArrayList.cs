

using System.Collections;

class Array_List
{

    static void Main(string[] args)
    {
        //creating the arrayList 

        var ItemsInStock = new ArrayList(){"IPhone 12","IPhone 13","Iphone 14","Iphone 14 pro max"};

        //add new Items to the cart

        ItemsInStock.Add("IPhone XR");

        //remove the item that are out of stock

        ItemsInStock.Remove("IPhone 12");


        var ItemsInNewStock = new ArrayList(){"oneplus Nord 2",  "oneplus 7t" , "oneplus 8t"};

        //adding the items in old stock to the new stock

        ItemsInNewStock.AddRange(ItemsInStock);

        Console.WriteLine("The new stock items are ");

        foreach(var newPhone in ItemsInNewStock)
        {
            Console.WriteLine($"{newPhone} ");
        }

        //to find the position of the required item in the current stock

        Console.WriteLine("Input the Item you need to order!");


        var itemToOrder = Console.ReadLine();

        //display the ordered item's slot if the item is present in the cart

        if(ItemsInNewStock.Contains(itemToOrder))
        {
            Console.WriteLine($"The Ordered element is present in the slot {ItemsInNewStock.IndexOf(itemToOrder)+1}");
        }
        
        //if the item is not in the cart then display the information

        if(!ItemsInNewStock.Contains(itemToOrder))
        {
            Console.WriteLine("Sorry! The Requested item is out of stock");

        }

        //sorting the items in the list

        ItemsInNewStock.Sort();
        Console.Write("The items are sorted like ");
        
        foreach(var mobilePhone in ItemsInNewStock)
        {
            Console.Write($"{mobilePhone} ");
        }

        //Reverse the items in the list

        ItemsInNewStock.Reverse();
        Console.Write("\nThe items are reversed like ");

        foreach(var mobilePhone in ItemsInNewStock)
        {
            Console.Write($"{mobilePhone} ");
        }


       
      
    

       

      


        
        
        
    }
}
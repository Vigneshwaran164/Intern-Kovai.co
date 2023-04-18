
using System;

using System.Collections;

class Browser
{
    //defining statck class
   private Stack history ;

    //initializing the stack within the constructor
   public Browser()
   {
    history = new Stack();
   }

   //method to navigate to other websites

   public void NavigateTo(string Url)
   {
        Console.WriteLine($"Navigating To {Url}");
        history.Push(Url);
   }
   //method to navigate back to the previos window
   public void NavigateBack()
   {
        //checking if there is any previous page exist

        if(history.Count==0)
        {
            Console.WriteLine("No More Pages To Go Back");
            return;
        }
        history.Pop();
        string url = (string)history.Peek();
        Console.WriteLine($"Navigating Back to {url}");
   }
   //method to display the current web page
   public void CurrentWindow()
   {
        string currentWindow = (string)history.Peek();
        Console.WriteLine($"The browser is at {currentWindow} page");
   }


}
class stack
{
    static void Main(string[] args)
    {

        //creating object for the Browser class

        Browser browser = new Browser();

        //navigating to the new window

        browser.NavigateTo("www.google.com");
        browser.NavigateTo("www.facebook.com");
        browser.NavigateTo("www.youtube.com");
        browser.NavigateTo("www.Instagram.com");
        browser.NavigateTo("www.twitter.com");

        //navigating back to the previous window

        browser.NavigateBack();
        browser.NavigateBack();

        browser.CurrentWindow();
        
    }

}

using System;

using System.Collections;

class Browser
{
   private Stack history ;

   public Browser()
   {
    history = new Stack();
   }

   public void NavigateTo(string Url)
   {
        Console.WriteLine($"Navigatin To {Url}");
        history.Push(Url);
   }
   public void NavigateBack()
   {
        if(history.Count==0)
        {
            Console.WriteLine("No More Pages To Go Back");
            return;
        }
        history.Pop();
        string url = (string)history.Peek();
        Console.WriteLine($"Navigating Back to {url}");
   }
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
        Browser browser = new Browser();

        browser.NavigateTo("www.google.com");
        browser.NavigateTo("www.facebook.com");
        browser.NavigateTo("www.youtube.com");
        browser.NavigateTo("www.Instagram.com");
        browser.NavigateTo("www.twitter.com");

        browser.NavigateBack();
        browser.NavigateBack();
        browser.CurrentWindow();
        
    }

}
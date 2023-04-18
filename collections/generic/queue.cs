using System ;

class Queue
{
    static void Main(string[] args)
    {

        //initilaizing the queue 
        
        Queue <int> numbers = new Queue<int>();

        numbers.Enqueue(40);
        numbers.Enqueue(30);
        numbers.Enqueue(70);
        numbers.Enqueue(80);
        numbers.Enqueue(50);

        Console.WriteLine("The Queue is ");
        foreach(var number in numbers)
        {
            Console.WriteLine($"{number} ");
        }
        //get the number of items in the queue
        Console.WriteLine($"The count of numbers in queue is {numbers.Count}");

        int nextItem = numbers.Peek();
        Console.WriteLine($"The next element in the queue is {nextItem}");

        //deleting the first element in the queue

        Console.WriteLine($"The Deleted element is {numbers.Dequeue()}");

        //deleting all the elements in the queue

        numbers.Clear();
       
        //tries to delete the first element in the queue
        try
        {
            numbers.Dequeue();
        }

        //throws the exception as the queue is empty
        catch(Exception ex)
        {
            Console.WriteLine($"There is a Exception occured : {ex}");


        }

    }
}
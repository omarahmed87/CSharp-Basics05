#region 9st answer
/* #region 1st answer
/*1-Write a method bool TryGetPrice(string title, out double price) that returns 
true and sets price to 25.5 if title is "Clean Code", otherwise returns false and 
sets price to 0. Call it and print the price if found 
*/
#endregion

using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        string title = "Clean Code";
        if (TryGetPrice(title, out double price))
        {
            Console.WriteLine(price);
        }
    }
    static bool TryGetPrice(string title, out double price)
    {
        if (title == "Clean Code")
        {
            price = 25.5;
            return true;
        }
        else
        {
            price = 0;
            return false;
        }
    }

}

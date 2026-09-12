#region 6st answer
/* #region 1st answer
/* 6-Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to
see, and why?
*/
#endregion

using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        double[] prices = [25.5, 40.0];
        ApplyDiscount(prices);
        Console.WriteLine(prices[0]); 
    }
    // 20.5 Passing by referece type changes the original value  

    static void ApplyDiscount(double[] prices)
    {
        prices[0] -= 5;

    }
}

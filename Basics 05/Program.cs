#region 8st answer
/* #region 1st answer
/* 8-Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length
afterward.
*/
#endregion

using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        double[] prices =[25.5, 40.0];
        ReplaceArray(ref prices);

        Console.WriteLine(prices.Length);

    }

    static void ReplaceArray(ref double[] prices)
    {
        double[] newArray = [10.0, 12.5, 15.0];
        prices = newArray;
    }
}

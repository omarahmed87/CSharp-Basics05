#region 7st answer
/* #region 1st answer
/* 7-Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
Call it and print pages afterward. How is the result different from question 5?
*/
#endregion

using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        int pages = 400;
        AddBonusPagesByRef(ref pages);
        Console.WriteLine(pages);
        //450 using ref, Passing a value type by reference ,it changes the original value
    }

    static void AddBonusPagesByRef(ref int pages)
    {
        pages += 50;
    }
}

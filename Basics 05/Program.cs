#region 10st answer
/*2-Write a method PrintBookInfo(string title, int pages = 300) where pages is 
optional. Call it once with only a title, and once passing both a title and pages. 
*/
#endregion

using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        string title = "Clean Code";
        int pages = 300;
        PrintBookInfo(title);
        PrintBookInfo(title, 450);
    }
    static void PrintBookInfo(string title, int pages = 300)
    {
        Console.WriteLine($"Title is: {title} , Pages is: {pages}");
    }
}

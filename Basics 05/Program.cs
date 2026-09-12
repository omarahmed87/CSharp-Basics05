#region 4st answer
/* #region 1st answer
/* 4-Write a method PrintBookTitle(string title) that prints "Book title: " + title.
Call it with "Clean Code".
*/
#endregion

public class Program
{
    public static void Main()
    {
        string title = "Clean code";
        PrintWelcomeMessage(title);

    }

    static void PrintWelcomeMessage(string title)
    {
        Console.WriteLine($"Book title: {title}");
    }
}

#region 11st answer
/*3-Using the PrintBookInfo method from the question above, call it by naming 
the parameters, passing pages before title. 
*/
#endregion

using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        string title = "Clean Code";
        int pages = 300;
        PrintBookInfo(pages:pages, title:title );
    }
    static void PrintBookInfo(string title, int pages = 300)
    {
        Console.WriteLine($"Title is: {title} , Pages is: {pages}");
    }
}
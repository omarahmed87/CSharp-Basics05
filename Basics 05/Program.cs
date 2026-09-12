#region 12st answer
/*4-Write a method PrintAllTitles(params string[] titles) that prints each title on its 
own line. Call it with three book titles. 
*/
#endregion

public class Program
{
    public static void Main()
    {
        PrintAllTitles("Clean Code", "CSharp", "SQL");
    }
    static void PrintAllTitles(params string[] titles)
    {
        foreach (var title in titles)
        {
            Console.WriteLine(title);
        }
    }
}
#region 5st answer
/* #region 1st answer
/* 5-Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
int pages = 400; and print pages afterward. What do you expect to see, and why?
*/
#endregion

public class Program
{
    public static void Main()
    {
        int pages = 400;
        AddBonusPages(pages);
        Console.WriteLine(pages); 
        //400 pssing by value type does't change the original value, it takes just an instans
    }

    static void AddBonusPages(int pages)
    {
        pages += 50;
    }
}

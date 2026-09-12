#region 15st answer
/* 3-Add a public string Title; field to Book. Set it and print it from Main.
*/
#endregion

public class Program
{
    public static void Main()
    {
        Book book = new Book();
        book.Title = "Clean Code"; 
        Console.WriteLine(book.Title);

        // 'public' is accessible from any other code in the same assembly or another assembly that references it.
    }

    public class Book
    {
        public string Title;
    }
}
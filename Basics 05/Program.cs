#region 14st answer
/*2-Add an internal int copiesInStock = 5; field to Book. Print it from Main. 
Does it compile?  Why?
*/
#endregion

public class Program
{
    public static void Main()
    {
        Book book = new Book();
        Console.WriteLine(book.copiesInStock);
        // Yes, it compiles.
        // 'internal' members are accessible anywhere within the same assembly (project).

    }
    public class Book
    {
        internal int copiesInStock = 5;
    }
}

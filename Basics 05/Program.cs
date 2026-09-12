#region 13st answer
/*1-Add a private string password = "secret"; field to a Book class. Try to 
print it from Main  (outside the class). What happens, and why? 
*/
#endregion

public class Program
{
    public static void Main()
    {
        Book book = new Book();
        Console.WriteLine(book.password);
        // It can't acces varriable password out of own class because it's private.
        // it can access just in own class(scope).
    }
    public class Book
    {
        private string password= "secret";
    }
}
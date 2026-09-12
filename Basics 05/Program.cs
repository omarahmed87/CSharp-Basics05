#region 2st answer
/* #region 1st answer
/* 2-Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.
 */
#endregion

public class Program
{
    public static void Main()
    {

        int[,] shelfCopies = {
            { 3,5 },
            { 1,4 },
        };
        Console.WriteLine(shelfCopies[1, 0]);
    }
}

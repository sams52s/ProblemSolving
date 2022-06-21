namespace LittleExercise1;

public class Util
{
    static void DecimalToBinaryConverter(long num)
    {
        if (num > 1)
            DecimalToBinaryConverter(num / 2);
        Console.Write(num % 2);
    }
    /*
         * Here N is the number of N , M is the number of M, i is a possession and j is another possession.
         * Here I did capture mask so that
         * I can Shift 1 to i position in left and subtract 1 from this to get a bit mask having i-1 to 0 bits set.
         */

    public static int Processing(int N, int M, int i, int j)
    {
        var clearMask = -1 << (j + 1);
        var captureMask = (1 << i) - 1;


        var capturedBits = N & captureMask;

        N &= clearMask; //Now to clear bits j to 0, AND mask with N.  

        M = M << i; //Inserting M in N

        N |= M; //Do a OR of M with N to insert M at i to j position

        N |= capturedBits; //Inserting captured bits into N

        return N;
    }

    public static int RandomNumberGenerator(int val)
    {
        Random random = new Random();
        return random.Next(val);
    }


    public static void CreateResult()
    {

        var N = RandomNumberGenerator(9999);
        var M = RandomNumberGenerator(50);

        Console.WriteLine("\r\nThe Decimal Value of N is: " + N + "\r\nThe Binary of N is :");
        DecimalToBinaryConverter(N);
        Console.WriteLine("\r\n");
        Console.WriteLine("\r\nThe Decimal Value of M is: " + M + "\r\nThe Binary of M is :");
        DecimalToBinaryConverter(M);
        Console.WriteLine("\r\n");

        var i = RandomNumberGenerator(9);
        var j = RandomNumberGenerator(9);
        Console.WriteLine("i: " + i+ " j: " + j+"\r\n \r\n");
        N = Processing(N, M, i, j);

        Console.WriteLine("\r\nThe result in Decimal Value is: " + N + "\r\nThe result in Binary is: ");
        DecimalToBinaryConverter(N);

        Console.WriteLine("\r\n \r\n");
    }
}

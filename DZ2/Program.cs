namespace DZ2;

class Program
{
    static void Main(string[] args)
    {
        Bits byteBits = new Bits(4);
        Bits intBits = new Bits(257);
        Bits longBits = new Bits(3_000_000_000);
        
        byte byteVal = (byte)byteBits;
        Console.WriteLine(byteVal);

        int intVal = (int)intBits;
        Console.WriteLine(intVal);

        long longVal = (long)longBits;
        Console.WriteLine(longVal);

        Console.ReadKey();
    }
}


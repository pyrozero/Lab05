using System;
class Program
{
    static void Main(string[]args)
    {
        try
        {
            double d = 5e9d;
            Console.WriteLine(d);
            int i = checked((int)d);
            Console.WriteLine(i);
        }
        catch(OverflowException e)
        {
            Console.WriteLine(e.Message);
        }        
    }
}
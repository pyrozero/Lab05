﻿using System;


class Program
{
    static void Main(string[]args)
    {
      try
        {
            Console.Write("Enter value : ");
            int val1 = Convert.ToInt32(Console.ReadLine());
            EventCheck(val1);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (OverflowException)
        {
            Console.WriteLine(e.Message);
        }
    }

    static int EventCheck(int val1)
    {
        if (val1 % 2 == 0)
        {
            Console.WriteLine("{0} is Event Number", val1);
        }
        else
        {
            Console.WriteLine("{0} is Odd Number", val1);
        }
        return (0);

    }

}
﻿namespace ConsoleApp2;

class Program
{
    static void Main()
    {
        int a = 10;
        for (int i = 0; i < a; i++)
        {
            Console.WriteLine(i);
        }
        //new code
        Console.WriteLine(a);
        Console.WriteLine("asdf");
        Console.WriteLine("sdfGSDFG");
    }


}
record User(string Name, int Age, string Email, string Hash, string Sold)
{
   
};

using System;

namespace variable;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        DateTime dt = DateTime.Now;
        //Console.WriteLine(dt);

        string dt1 = DateTime.Now.ToString();
        Console.WriteLine(dt1);
        string dt2 = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(dt2);
        string dt3 = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(dt3);
    }
}

using System;

namespace switch_case;

class Program
{
    static void Main(string[] args)
    {
        int month = DateTime.Now.Month;
        
        switch (month)
        {
            case 1:
                Console.WriteLine("Ocak ayındasınız");
                break;
            case 2:
                Console.WriteLine("Şubat ayı");
                break;
            default:
                break;
        }
    }
}

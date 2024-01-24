﻿using System;

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

        switch(month) {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Sezon kış");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Sezon bahar");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("Sezon yaz");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Sezon sonbahar");
                break;
        }
    }
}

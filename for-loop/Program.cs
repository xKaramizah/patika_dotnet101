using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        string space = "";
        string symbol = "";
        
        for(int i = 1; i <=n; i++)
        {
            for(int j = 0; j < n-i; j++ )
            {
                space += " ";
            }
            for(int k = 0; k < i; k++)
            {
                symbol += "#";    
            }
            Console.WriteLine(space + symbol);
            space = "";
            symbol = "";

        }
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        try 
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            Result.staircase(n);

        }
        catch(Exception ex) {
            Console.WriteLine("Hata oluştu: " + ex.Message);
        }

    }
}

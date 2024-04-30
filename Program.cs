using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;

namespace App011;

class Program
{
    static void Main(string[] args)
    {
    
        int x = 5;
        int y =11;

        int z = Max(x,y);
        Console.WriteLine($"The maximum of {x} and {y} is {z}.");

    } //Hello World


    public static int Max(int a, int b)
    {
        if(a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
        
    }


    
}

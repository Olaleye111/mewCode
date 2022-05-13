using System;
using System.Collections.Generic;
using System.Collections;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
          Random random = new Random();

          long num = random.Next(1000000000, 300000000);
          Console.WriteLine(num);      
        }
    }
}
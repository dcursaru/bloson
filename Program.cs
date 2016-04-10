using System;
using System.Diagnostics;

namespace ConsoleApplication
{
  internal class Program
  {
    private static void Main(string[] args)
    {
    	Console.WriteLine("Ana are mere");
      	var policy = new Policy("B12134ACX");
        Debug.Print("tata are pere");
        Debug.Print("Hmmmm!");
    }

      private double CalculateBaseSalary()
      {
          return 100.00;

      }

  }
}



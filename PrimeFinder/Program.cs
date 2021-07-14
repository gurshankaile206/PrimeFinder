using System;
using PrimeFinder.Models;


namespace PrimeFinder
{
  class Program
  {
    static void Main()
    {
      ThePrimeFinder newPrime = new ThePrimeFinder(2);
      Console.WriteLine("Main Works" + newPrime.Number.GetType());
      
    }
  }
}

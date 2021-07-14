using System;
using PrimeFinder.Models;
using System.Collections.Generic;

namespace PrimeFinder
{
  class Program
  {
    static void Main()
    {
      ThePrimeFinder newPrime = new ThePrimeFinder(100);
      newPrime.MakeList(newPrime.Number);
      Console.WriteLine("Frist List: " + newPrime.numberList);
      newPrime.ChangeListTwo(newPrime.Number);
      Console.WriteLine("Main Works " + newPrime.Number);
      Console.WriteLine(string.Join(" ", newPrime.numberList));
      newPrime.ChangeListThree(newPrime.Number);
      Console.WriteLine(string.Join(" ", newPrime.numberList));
      newPrime.ChangeListFive(newPrime.Number);
      Console.WriteLine(string.Join(" ", newPrime.numberList));
      
    }
  }
}

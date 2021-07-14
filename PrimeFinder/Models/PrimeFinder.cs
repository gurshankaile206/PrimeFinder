using System;
using System.Collections.Generic;

namespace PrimeFinder.Models
{
  public class ThePrimeFinder
  {

    public int Number { get; set; } // property of the Constructor??  Class?
    public List<int> numberList = new List<int>() {};
    public ThePrimeFinder(int number) // this is our Constructor??  
    {
      Number = number;
    }
    public void MakeList(int Number)
    {
      for(int i = 2; i <= Number; i++)
      { 
        numberList.Add(i);
      } 
    }
    public void ChangeListTwo(int Number)
    {
      for(int i = 3; i <= Number; i++)
      {
        if (i % 2 == 0)
        {
          numberList.Remove(i);
        }
      }
    }
    public void ChangeListThree(int Number)
    {
      for(int i = 3; i <= Number; i++)
      {
        if (i % 3 == 0)
        {
          numberList.Remove(i);
        }
      }
    }
    public void ChangeListFive(int Number)
    {
      for(int i = 3; i <= Number; i++)
      {
        if (i % 5 == 0)
        {
          numberList.Remove(i);
        }
      }
    }
  }
}


    // if (x <= 1)
    //             return false;
    //         else if (x == 2)
    //             return true;
    //         else if (x % 2 == 0)
    //             return false;
    //         else
    //             for (int i = 3; i < x; i += 2)
    //             {
    //                 if ((x % i) == 0)
    //                 {
    //                     return false;
    //                 }
    //             }
    //         return true;
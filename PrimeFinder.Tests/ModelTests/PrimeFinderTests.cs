using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeFinder.Models;

namespace ToDoList.Tests
{
  [TestClass]
      public class PrimeFinderTests
    {
      [TestMethod]
      public void ThePrimeFinder_IntializesValuesCorrectly_ThePrimeFinder()
      {
        ThePrimeFinder newPrime = new ThePrimeFinder(2);
        Assert.AreEqual(typeof(ThePrimeFinder), newPrime.GetType()); //GetType() is a method that tells you what the property is
      }
      [TestMethod]
      public void GetInt_ReturnsInteger_Int()
      {
        // Arrange
        int number = 2;
        ThePrimeFinder newPrime = new ThePrimeFinder(number);
        // Act
        int result = newPrime.Number;
        // Assert
        Assert.AreEqual(number, result);
      }

    }

}

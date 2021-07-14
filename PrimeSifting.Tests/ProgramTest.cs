using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifting;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class ProgramTests
  {
    [TestMethod]
    public void IsPrime_GivesCorrectAnswer_ReturnsFalseFor0Or1 ()
    {
      Assert.AreEqual(Program.IsPrime(0), false);
      Assert.AreEqual(Program.IsPrime(1), false);
    }

    [TestMethod]
    public void IsPrime_GivesCorrectAnswer_ReturnsTrueFor2 ()
    {
      bool actual = Program.IsPrime(2);
      bool expected = true;

      Assert.AreEqual(actual, expected);
    }

    [TestMethod]
    public void IsPrime_GivesCorrectAnswer_ReturnsTrueFor3 ()
    {
      bool actual = Program.IsPrime(3);
      bool expected = true;

      Assert.AreEqual(actual, expected);
    }

    [TestMethod]
    public void IsPrime_GivesCorrectAnswer_ReturnsTrueFor5 ()
    {
      bool actual = Program.IsPrime(5);
      bool expected = true;

      Assert.AreEqual(actual, expected);
    }

    [TestMethod]
    public void IsPrime_GivesCorrectAnswer_ReturnsFalseFor9 ()
    {
      Assert.AreEqual(Program.IsPrime(9), false);
    }

    [TestMethod]
    public void IsPrime_GivesCorrectAnswer_ReturnsTrueForVariousPrimeNumbers ()
    {
      Assert.AreEqual(Program.IsPrime(11), true);
      Assert.AreEqual(Program.IsPrime(17), true);
      Assert.AreEqual(Program.IsPrime(31), true);
      Assert.AreEqual(Program.IsPrime(7793), true);
    }

  //   [TestMethod]
  //   public void Solve_GivesCorrectPrimes_WhenInputIs1 ()
  //   {
  //     List<int> actual = Program.Solve(1);
  //     List<int> expected = new List<int> {};

  //     CollectionAssert.AreEqual(actual, expected);
  //   }

  //   [TestMethod]
  //   public void Solve_GivesCorrectPrimes_WhenInputIs2 ()
  //   {
  //     List<int> actual = Program.Solve(2);
  //     List<int> expected = new List<int> {};

  //     CollectionAssert.AreEqual(actual, expected);
  //   }

  //   [TestMethod]
  //   public void Solve_GivesCorrectPrimes_WhenInputIs3 ()
  //   {
  //     List<int> actual = Program.Solve(3);
  //     List<int> expected = new List<int> {2};

  //     CollectionAssert.AreEqual(actual, expected);
  //   }

  //   [TestMethod]
  //   public void Solve_GivesCorrectPrimes_WhenInputIs4 ()
  //   {
  //     List<int> actual = Program.Solve(4);
  //     List<int> expected = new List<int> {2, 3};

  //     CollectionAssert.AreEqual(actual, expected);
  //   }
  }
}
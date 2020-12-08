using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;


namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {

    [TestMethod]
    public void TriangleType_IsEquilateral_True()
    {
      Triangle testType = new Triangle();
      Assert.AreEqual(true, testType.TriangleType(3,3,3));
    } 

    [TestMethod]
    public void TriangleType_IsScalene_True()
    {
      Triangle testType = new Triangle();
      Assert.AreEqual(true, testType.TriangleType(1,2,3));
    } 

    [TestMethod]
    public void TriangleType_Isosceles_True()
    {
      Triangle testType = new Triangle();  
      Assert.AreEqual(true, testType.TriangleType(2,2,3));
    }
    

    }
  }

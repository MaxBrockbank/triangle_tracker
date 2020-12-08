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
  }
}

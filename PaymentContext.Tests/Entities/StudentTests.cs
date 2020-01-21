using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
  [TestClass]
  public class StudentTests
  {
    [TestMethod]
    public void TestMethod1()
    {
      var student = new Student("David", "Campos", "156561214545", "teste@gmail.com");

    }
  }
}

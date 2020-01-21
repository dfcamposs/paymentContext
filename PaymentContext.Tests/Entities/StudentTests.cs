using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicinarAssinatura()
        {
            var subscription = new Subscription(null);
            var student = new Student("David", "Campos", "156561214545", "teste@gmail.com");
            student.AddSubscription(subscription);
        }
    }
}

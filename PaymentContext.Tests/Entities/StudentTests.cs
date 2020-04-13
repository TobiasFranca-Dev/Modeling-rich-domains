using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Entities
{

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AddSubscription()
        {
            var subscription = new Subscription(null);

            var student = new Student("Tobias", "França", "12312312312", "email@email.com");
            student.AddSubscription(subscription);
        }
    }
}

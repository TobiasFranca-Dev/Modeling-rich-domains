using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Entities
{

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AddSubscription()
        {
            var subscription = new Subscription(null);

            var student = new Student(new Name("Tobias", "França"), new Document("12312312312", EDocumentType.CPF), new Email("email@email.com"));
            student.AddSubscription(subscription);
        }
    }
}

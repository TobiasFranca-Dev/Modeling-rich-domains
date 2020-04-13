using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
using System;

namespace PaymentContext.Tests.Entities
{

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AddSubscription()
        {

            var name = new Name("Tobias", "França");
            var document = new Document("12312312312", EDocumentType.CPF);
            var email = new Email("email@email.com");
            var subscription = new Subscription(DateTime.Now.AddDays(30));

            var student = new Student(name, document, email);
            student.AddSubscription(subscription);
        }
    }
}

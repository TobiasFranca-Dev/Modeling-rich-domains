using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow("123")]
        [DataRow("9336136700018")]
        [DataRow("6380818000115")]
        [DataRow("4079919003122")]
        [DataRow("364379000173")]
        public void ShouldReturnErrorWhenCNPJIsInvalid(string cnpj)
        {
            var doc = new Document(cnpj, EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);
        }


        [TestMethod]
        [DataTestMethod]
        [DataRow("76793664000117")]
        [DataRow("17683756000185")]
        [DataRow("83885836000148")]
        [DataRow("16356355000158")]
        [DataRow("26908340000109")]
        public void ShouldReturnSuccessWhenCNPJIsValid(string cnpj)
        {
            var doc = new Document(cnpj, EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);
        }


        [TestMethod]
        [DataTestMethod]
        [DataRow("123")]
        [DataRow("8453889045")]
        [DataRow("4237882012")]
        [DataRow("9054180060")]
        [DataRow("9228096001")]
        public void ShouldReturnErrorWhenCPFIsInvalid(string cpf)
        {
            var doc = new Document(cpf, EDocumentType.CPF);
            Assert.IsTrue(doc.Invalid);
        }


        [TestMethod]
        [DataTestMethod]
        [DataRow("46018959011")]
        [DataRow("33614006000")]
        [DataRow("66401050047")]
        [DataRow("38110450083")]
        [DataRow("91813106096")]
        public void ShouldReturnSuccessWhenCPFIsValid(string cpf)
        {
            var doc = new Document(cpf, EDocumentType.CPF);
            Assert.IsTrue(doc.Valid);
        }
    }
}

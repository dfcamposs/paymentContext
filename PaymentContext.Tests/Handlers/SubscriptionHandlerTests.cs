using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;
using System;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    class SubscriptionHandlerTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Bruce";
            command.LastName = "Wayne";
            command.Document = "99999999999";
            command.Email = "teste@teste.com";
            command.BarCode = "123456789";
            command.BoletoNumber = "515151146454";
            command.PaymentNumber = "2121454";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "WAYNE CORP";
            command.PayerDocument = "5452124568";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "teste@teste.com";
            command.Street = "akhskajs";
            command.Number = "123";
            command.Neighborhood = "akjskjasas";
            command.City = "kajskajs";
            command.State = "aslks";
            command.Country = "lfjksd";
            command.ZipCode = "12345678";

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Queries;
using PaymentContext.Domain.ValueObjects;
using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentQueriesTests
    {
        private IList<Student> _student;

        public StudentQueriesTests()
        {
            for (int i = 0; i < 10; i++)
            {
                _student.Add(new Student(
                    new Name("Aluno", i.ToString()),
                    new Document("11111111111" + i.ToString(), EDocumentType.CPF),
                    new Email(i.ToString() + "teste.com")
                    ));
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenDocumentNotExists()
        {
            var exp = StudentQueries.GetStudentInfo("12345678911");
            var studn = _student.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreEqual(null, studn);
        }

        [TestMethod]
        public void ShouldReturnWhenDocumentExists()
        {
            var exp = StudentQueries.GetStudentInfo("111111111111");
            var studn = _student.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreNotEqual(null, studn);
        }
    }
}


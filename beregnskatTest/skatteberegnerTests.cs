using Microsoft.VisualStudio.TestTools.UnitTesting;
using Skatberegnunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skatberegnunit.Tests
{
    [TestClass()]
    public class skatteberegnerTests
    {
        [TestMethod()]
        [DataRow(0, Person.Jobkategori.Studerende, 0)]
        [DataRow(10000, Person.Jobkategori.Studerende, 1000)]
        [DataRow(20000, Person.Jobkategori.Studerende, 2000)]
        [DataRow(20001, Person.Jobkategori.Studerende, 4000)]
        [DataRow(0, Person.Jobkategori.Underviser, 0)]
        [DataRow(10000, Person.Jobkategori.Underviser, 1000)]
        [DataRow(20000, Person.Jobkategori.Underviser, 2000)]
        [DataRow(20001, Person.Jobkategori.Underviser, 4000)]
        [DataRow(0, Person.Jobkategori.Pensionist, 0)]
        [DataRow(10000, Person.Jobkategori.Pensionist, 500)]
        [DataRow(20000, Person.Jobkategori.Pensionist, 1000)]
        [DataRow(20001, Person.Jobkategori.Pensionist, 1000)]


        public void BeregnSkatTest(int income, Person.Jobkategori jobkategori, int expectedTax)
        {
            // Arrange
            Person person = new Person(income, jobkategori);
            // Act
            var result = skatteberegner.BeregnSkat(person);
            // Assert
            Assert.AreEqual(expectedTax, result);
        }
    }
}
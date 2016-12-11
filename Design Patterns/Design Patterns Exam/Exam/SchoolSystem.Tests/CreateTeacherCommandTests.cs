using System;
using NUnit.Framework;
using SchoolSystem.Framework.Models;
using SchoolSystem.Framework.Models.Enums;

namespace SchoolSystem.Tests
{
    [TestFixture]
    public class CreateTeacherCommandTests
    {
        [Test]
        public void Constructor_ShouldCreateTeacherCorrectly()
        {
            var teacher = new Teacher("Pesho", "Peshov", Subject.Math);

            Assert.IsInstanceOf<Teacher>(teacher);
        }

        [TestCase("P", "Goshev")]
        [TestCase("Pesho", "G")]
        [TestCase("PeshoPeshoPeshoPeshoPeshoPeshoPesho", "Goshev")]
        [TestCase("Pesho", "GoshevGoshevGoshevGoshevGoshevGoshevGoshev")]
        [TestCase("123", "Goshev")]
        [TestCase("Pesho", "123")]
        public void Constructor_ShouldThrowArgumentException_WhenPassedFirstOrLastNameIsInvalid(string firstName, string lastName)
        {
            Assert.Throws<ArgumentException>(() => new Teacher(firstName, lastName, Subject.Bulgarian));
        }

        [Test]
        public void Constructor_ShouldSetGradeProperty_WhenInitialized()
        {
            var expectedSubject = Subject.English;
            var teacher = new Teacher("Pesho", "Peshov", expectedSubject);
            Assert.AreEqual(expectedSubject, teacher.Subject);
        }

        [Test]
        public void Constructor_ShouldSetFirstNameProperty_WhenInitialized()
        {
            var expectedFirstName = "Pesho";
            var teacher = new Teacher(expectedFirstName, "Peshov", Subject.Bulgarian);
            Assert.AreEqual(expectedFirstName, teacher.FirstName);
        }

        [Test]
        public void Constructor_ShouldSetLastNameProperty_WhenInitialized()
        {
            var expectedLastName = "Peshev";
            var teacher = new Teacher("Pesho", expectedLastName, Subject.Math);
            Assert.AreEqual(expectedLastName, teacher.LastName);
        }
    }
}

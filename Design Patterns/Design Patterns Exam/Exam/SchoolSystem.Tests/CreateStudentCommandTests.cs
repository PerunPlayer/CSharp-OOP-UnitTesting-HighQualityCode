using System;
using NUnit.Framework;
using SchoolSystem.Framework.Models;
using SchoolSystem.Framework.Models.Enums;

namespace SchoolSystem.Tests
{
    [TestFixture]
    public class CreateStudentCommandTests
    {
        [Test]
        public void Constructor_ShouldCreateStudentCorrectly()
        {
            var student = new Student("Pesho", "Peshov", Grade.Eighth);

            Assert.IsInstanceOf<Student>(student);
        }

        [TestCase("P", "Goshev")]
        [TestCase("Pesho", "G")]
        [TestCase("PeshoPeshoPeshoPeshoPeshoPeshoPesho", "Goshev")]
        [TestCase("Pesho", "GoshevGoshevGoshevGoshevGoshevGoshevGoshev")]
        [TestCase("123", "Goshev")]
        [TestCase("Pesho", "123")]
        public void Constructor_ShouldThrowArgumentException_WhenPassedFirstOrLastNameIsInvalid(string firstName, string lastName)
        {
            Assert.Throws<ArgumentException>(() => new Student(firstName, lastName, Grade.Sixth));
        }

        [Test]
        public void Constructor_ShouldSetGradeProperty_WhenInitialized()
        {
            var expectedGrade = Grade.Fifth;
            var student = new Student("Pesho", "Peshov", expectedGrade);
            Assert.AreEqual(expectedGrade, student.Grade);
        }

        [Test]
        public void Constructor_ShouldSetFirstNameProperty_WhenInitialized()
        {
            var expectedFirstName = "Pesho";
            var student = new Student(expectedFirstName, "Peshov", Grade.Seventh);
            Assert.AreEqual(expectedFirstName, student.FirstName);
        }

        [Test]
        public void Constructor_ShouldSetLastNameProperty_WhenInitialized()
        {
            var expectedLastName = "Peshev";
            var student = new Student("Pesho", expectedLastName, Grade.Third);
            Assert.AreEqual(expectedLastName, student.LastName);
        }
    }
}

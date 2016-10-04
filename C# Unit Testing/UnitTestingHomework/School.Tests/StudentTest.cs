namespace School.Tests
{
    using System;
    using NUnit.Framework;
    using School;

    [TestFixture]
    public class StudentTest
    {
        [Test]
        public void Students_ConstructorInitialisesCorrectly_StudentName()
        {
            string name = "Pesho";
            var student = new Student(name);
            Assert.AreSame(name, student.Name);
        }

        [Test]
        public void Students_ConstructorTestEmptyName_ShouldThrowArgumentOutOfRangeException()
        {
            string name = "";
            TestDelegate test = () => new Student(name);
            Assert.Throws(typeof(ArgumentOutOfRangeException), test);
        }

        [Test]
        public void Students_IDIsInRange()
        {
            string name = "Pesho";
            var student = new Student(name);
            Assert.IsTrue(student.ID >= 10000 && student.ID <= 99999);
        }
    }
}

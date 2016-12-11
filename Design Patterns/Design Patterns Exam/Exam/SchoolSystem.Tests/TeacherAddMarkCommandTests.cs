using System;
using System.Collections.Generic;
using System.Linq;

using SchoolSystem.Framework.Models;
using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Enums;

using Moq;
using NUnit.Framework;

namespace SchoolSystem.Tests
{
    [TestFixture]
    public class TeacherAddMarkCommandTests
    {
        [Test]
        public void AddMark_ShouldThrowNullReferenceExeption_WhenPassedMarkIsNotValid()
        {
            var expectedSubject = Subject.Bulgarian;
            var expectedValue = 5;

            var student = new Mock<IStudent>();
            var teacher = new Teacher("Pesho", "Peshov", expectedSubject);

            student.Setup(c => c.Marks).Returns(new List<IMark>());

            Assert.Throws<NullReferenceException>(() => teacher.AddMark(student.Object, expectedValue));
        }

        [Test]
        public void AddMark_ShouldThrowArgumentException_WhenAddingMoreThan20Marks()
        {
            var student = new Mock<IStudent>();
            var teacher = new Teacher("Pesho", "Peshov", Subject.Bulgarian);
            var mark = new Mock<IMark>();

            var listOfMarks = Enumerable.Repeat(mark.Object, 20)
                    .ToList();

            student.Setup(c => c.Marks)
                .Returns(listOfMarks);

            Assert.Throws<ArgumentException>(() => teacher.AddMark(student.Object, 5));
        }
    }
}

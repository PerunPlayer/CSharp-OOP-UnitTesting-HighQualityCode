using System.Collections.Generic;

using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Models.Enums;
using SchoolSystem.Framework.Models.Contracts;

namespace SchoolSystem.Framework.Core.Commands
{
    public class CreateStudentCommand : ICommand
    {
        private int currentStudentId = 0;
        private readonly IStudentFactory studentFactory;

        public string Execute(IList<string> parameters)
        {
            string firstName = parameters[0];
            string lastName = parameters[1];
            Grade grade = (Grade)int.Parse(parameters[2]);

            IStudent student = this.studentFactory.CreateStudent(firstName, lastName, grade);
            Engine.Students.Add(currentStudentId, student);

            return $"A new student with name {firstName} {lastName}, grade {grade} and ID {currentStudentId++} was created.";
        }
    }
}

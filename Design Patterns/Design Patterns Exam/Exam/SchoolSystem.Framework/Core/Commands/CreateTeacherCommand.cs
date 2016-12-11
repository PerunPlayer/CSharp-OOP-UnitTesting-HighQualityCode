using System.Collections.Generic;

using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Models.Enums;
using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Core.Contracts;

namespace SchoolSystem.Framework.Core.Commands
{
    public class CreateTeacherCommand : ICommand
    {
        private int currentTeacherId = 0;
        private readonly ITeacherFactory teacherFactory;

        public string Execute(IList<string> parameters)
        {
            string firstName = parameters[0];
            string lastName = parameters[1];
            Subject subject = (Subject)int.Parse(parameters[2]);

            ITeacher teacher = this.teacherFactory.CreateTeacher(firstName, lastName, subject);
            Engine.Teachers.Add(currentTeacherId, teacher);

            return $"A new teacher with name {firstName} {lastName}, subject {subject} and ID {currentTeacherId++} was created.";
        }
    }
}

namespace StudentClass
{
    using StudentClass.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int ssnNum;
        private string permAdress;
        private string phoneNumber;
        private string email;
        private string course;
        private Specialities speciality;
        private Universities university;
        private Faculties faculty;

        public Student(
            string firstName,
            string middleName,
            string lastName,
            int ssnNum,
            string permAdress,
            string phoneNumber,
            string email,
            string course,
            Specialities speciality,
            Universities university,
            Faculties faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssnNum;
            this.PermanentAdress = permAdress;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Course = course;
            this.Speciality = speciality;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (firstName == null)
                {
                    throw new ArgumentException("Firstname cannot be empty!");
                }
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            private set
            {
                if (middleName == null)
                {
                    throw new ArgumentException("Middlename cannot be empty!");
                }
                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (lastName == null)
                {
                    throw new ArgumentException("Lastname cannot be empty!");
                }
                this.lastName = value;
            }
        }

        public int SSN
        {
            get
            {
                return this.ssnNum;
            }

            private set
            {
                if (ssnNum <= 0)
                {
                    throw new ArgumentException("SSN must be positive number!");
                }
                this.ssnNum = value;
            }
        }

        public string PermanentAdress
        {
            get
            {
                return this.permAdress;
            }

            private set
            {
                if (permAdress == null)
                {
                    throw new ArgumentException("Permanent adress cannot be empty!");
                }
                this.permAdress = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }

            internal set
            {
                if (phoneNumber == null)
                {
                    throw new ArgumentException("Phonenumber cannot be empty!");
                }
                this.phoneNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            internal set
            {
                if (email == null)
                {
                    throw new ArgumentException("Email cannot be empty!");
                }
                this.email = value;
            }
        }

        public string Course
        {
            get
            {
                return this.course;
            }

            internal set
            {
                if (course == null)
                {
                    throw new ArgumentException("Course cannot be empty!");
                }
                this.course = value;
            }
        }

        public Specialities Speciality
        {
            get
            {
                return this.speciality;
            }

            internal set
            {
                this.speciality = value;
            }
        }

        public Universities University
        {
            get
            {
                return this.university;
            }

            internal set
            {
                this.university = value;
            }
        }

        public Faculties Faculty
        {
            get
            {
                return this.faculty;
            }

            internal set
            {
                this.faculty = value;
            }
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (this.SSN == student.SSN)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("Student data");
            builder.Append(new string('=', 50));
            builder.Append(string.Format("\nFullname: {0} {1} {2}", firstName, middleName, lastName));
            builder.Append(string.Format("\nSSN: {0}", ssnNum));
            builder.Append(string.Format("\nAdress: {0}", permAdress));
            builder.Append(string.Format("\nPhone: {0}", phoneNumber));
            builder.Append(string.Format("\nEmail: {0}", email));
            builder.Append(string.Format("\nCourse: {0}", course));
            builder.Append(string.Format("\nSpeciality: {0}", speciality));
            builder.Append(string.Format("\nUniversity: {0}", university));
            builder.Append(string.Format("\nFaculty: {0}", faculty));

            return builder.ToString();
        }

        public override int GetHashCode()
        {
            var result = this.SSN.GetHashCode() + this.PhoneNumber.GetHashCode();
            return result;
        }

        public object Clone()
        {
            return new Student(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.SSN,
                this.PermanentAdress,
                this.PhoneNumber,
                this.Email,
                this.Course,
                this.Speciality,
                this.University,
                this.Faculty);
        }

        public int CompareTo(Student otherStudent)
        {
            var stringCompare = new List<Student> { this, otherStudent };
            Student sorted;
            if (this.FirstName != otherStudent.FirstName &&
                this.MiddleName != otherStudent.MiddleName &&
                this.LastName != otherStudent.LastName)
            {
                sorted = stringCompare
                    .OrderBy(x => x.FirstName)
                    .ThenBy(x => x.MiddleName)
                    .ThenBy(x => x.LastName)
                    .ToList()
                    .FirstOrDefault();

                if (sorted == this)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else if (this.SSN != otherStudent.SSN)
            {
                sorted = stringCompare
                    .OrderBy(x => x.SSN)
                    .ToList()
                    .FirstOrDefault();

                if (this.SSN == sorted.SSN)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}

namespace StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private double weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (weekSalary < 0)
                {
                    throw new ArgumentException("Week salary must be positive number!");
                }
                else
                {
                    this.weekSalary = value;
                }
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (workHoursPerDay < 0)
                {
                    throw new ArgumentException("Work hours per day can not be negative number!");
                }
                else
                {
                    this.workHoursPerDay = value;
                }
            }
        }

        public double MoneyPerHour()
        {
            double moneyPerHour = this.weekSalary / (this.workHoursPerDay * 5);

            return moneyPerHour;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} with WeekSalary: ${2:F2}, WorkHoursPerDay: {3}, MoneyPerHour: ${4:F2}"
                , this.FirstName, this.LastName, this.weekSalary, this.workHoursPerDay, this.MoneyPerHour());
        }
    }
}

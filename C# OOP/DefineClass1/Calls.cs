namespace DefineClass
{
    using System;
    using System.Collections.Generic;

    public class Calls
    {
        private string date;
        private string time;
        private string phoneNumber;
        private int callDuration;

        public Calls(string date, string time, string phoneNumber, int callDuration)
        {
            this.Date = date;
            this.Time = time;
            this.PhoneNumber = phoneNumber;
            this.CallDuration = callDuration;
        }

        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                if (value == "" || value == null || value == String.Empty)
                {
                    throw new IndexOutOfRangeException("The call must have a date!");
                }
                else
                {
                    this.date = value;
                }
            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }
            set
            {
                if (value == "" || value == null || value == string.Empty)
                {
                    throw new IndexOutOfRangeException("The call must have a time!");
                }
                else
                {
                    this.time = value;
                }
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (value == "" || value == null || value == String.Empty)
                {
                    throw new IndexOutOfRangeException("The dialled phone number must have 10 digits!");
                }  
                else
                {
                    this.phoneNumber = value;
                }
            }
        }

        public int CallDuration
        {
            get
            {
                return this.callDuration;
            }
            set
            {
                if (value >= 0)
                {
                    this.callDuration = value;
                }
                else
                {
                    throw new ArgumentException("The duration of the call is always a positive number!");
                }
            }
        }

        public override string ToString()
        {
            List<string> callInformation = new List<string>();

            callInformation.Add("Call Date - " + this.Date);
            callInformation.Add(" Time - " + this.Time);
            callInformation.Add("Number  - " + this.PhoneNumber);
            callInformation.Add(" Duration - " + this.CallDuration);

            return String.Join("\n", callInformation);
        }
    }
}

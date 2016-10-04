namespace DefineClass
{
    using System;

    public class Battery
    {
        private string batteryModel;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType type;

        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType type)
        {
            this.batteryModel = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.type = type;
        }

        public string Model
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                if (value == "" || value == null || value == String.Empty)
                {
                    throw new ArgumentException("The battery must have a model!");
                }
                else
                {
                    this.batteryModel = value;
                }
            }
        }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Battery idle time must be a positive number!");
                }

                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Battery talk time must be a positive number!");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType batteryType
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
    }
}

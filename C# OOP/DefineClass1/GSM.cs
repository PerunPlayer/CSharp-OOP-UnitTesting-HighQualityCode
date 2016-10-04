namespace DefineClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class GSM
    {
        public static GSM Iphone4S = new GSM("IPhone 4S", "Apple", 1000, "Milko Kalaidjiev",
            new Battery("G5", 50, 100, BatteryType.LiIon), new Display(5, 16000000));

        private string model;
        private string manufactorer;
        private decimal price;
        private string owner;

        private Battery battery;
        private Display display;

        public GSM(string model, string manufactorer)
        {
            History = new List<Calls>();
            this.model = model;
            this.manufactorer = manufactorer;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display): this(model, manufacturer)
        {
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public override string ToString()
        {
            string result = string.Format(
                "This {0} cost exactly {1}. This phone is made by {2} and the owner is {3}.",
                this.model, this.price, this.manufactorer, this.owner);
            return result;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == "" || value == null || value == String.Empty)
                {
                    throw new ArgumentException("The phone must have a model!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufactorer
        {
            get
            {
                return this.manufactorer;
            }
            set
            {
                if (value == "" || value == null || value == String.Empty)
                {
                    throw new ArgumentException("The phone must have a manufactorer!");
                }
                else
                {
                    this.manufactorer = value;
                }
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The price of the phone must be positive number!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value == "" || value == null || value == String.Empty)
                {
                    throw new ArgumentException("The phone must have an owner!");
                }
                else
                {
                    this.owner = value;
                }
            }
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public List<Calls> History { get; set; }

        public void AddCall(Calls call)
        {
            History.Add(call);
        }

        public void DeleteCall(Calls call)
        {
            History.Remove(call);
        }

        public void DeleteCall(int callIndex)
        {
            History.RemoveAt(callIndex);
        }

        public void ClearCallHistory()
        {
            History.Clear();
        }

        public decimal totalPrice(decimal pricePerMinute)
        {
            decimal price = this.History.Select(x => x.CallDuration).Sum();
            return pricePerMinute * (price / 60.0m);
        }
    }
}

namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(string msg, T start, T end, Exception ex)
            : base(msg, ex)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string msg, T start, T end)
            : this(string.Format("{0}\nShould be between {1} and {2}", msg, start, end), start, end, null)
        {
        }

        public T Start
        {
            get { return this.start; }
            set { this.start = value; }
        }

        public T End
        {
            get { return this.end; }
            set { this.end = value; }
        }
    }
}

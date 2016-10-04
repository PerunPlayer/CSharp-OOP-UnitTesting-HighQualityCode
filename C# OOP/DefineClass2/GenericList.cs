namespace _3D
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class GenericList<T> : IEnumerable<T>
        where T : IComparable
    {
        private const int constCountInitial = 0;
        private int capacity;
        private T[] arrayT;
        private int count;

        public GenericList(int capacityInitial)
        {
            this.Capacity = capacityInitial;
            this.Count = constCountInitial;
            this.arrayT = new T[this.capacity];
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            private set
            {
                if (!(value > 0 && value <= int.MaxValue))
                {
                    throw new ArgumentOutOfRangeException("Rows cannot be negative or zero or over 2,147,483,647! Try again!");
                }
                else
                {
                    this.capacity = value;
                }
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }

            set
            {
                this.count = value;
            }
        }

        public T this[int index]
        {
            get
            {
                if (!(index < 0 || index >= this.Count))
                {
                    return this.arrayT[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Index cannot be negative or {this.Count - 1}.");
                }
            }

            set
            {
                if (!(index < 0 || index >= this.Count))
                {
                    this.arrayT[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Index should be between 0 and {this.Count - 1}.");
                }
            }
        }

        public void Add(T item)
        {
            if (this.Count == this.capacity)
            {
                this.Capacity = Capacity * 2;
                var oldArray = this.arrayT;
                this.arrayT = new T[this.Capacity];
                Array.Copy(oldArray, this.arrayT, this.Count);
            }

            this.arrayT[this.Count] = item;
            this.Count++;
        }

        public void Remove(int index)
        {
            if (!(index < 0 || index >= this.Count))
            {
                var oldArray = this.arrayT;

                this.Count = 0;
                this.arrayT = new T[this.Capacity];

                for (int i = 0; i < index; i++)
                {
                    this.Add(oldArray[i]);
                }

                for (int i = index; i < oldArray.Length - index; i++)
                {
                    this.Add(oldArray[i + 1]);
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Index cannot be negative or over {this.Count - 1}.");
            }
        }

        public void Insirt(int index, T item)
        {
            if (!(index < 0 || index >= this.Count))
            {
                var oldArray = this.arrayT;
                this.Count = 0;
                this.arrayT = new T[this.Capacity];

                for (int i = 0; i < index; i++)
                {
                    this.Add(oldArray[i]);
                }

                this.Add(item);

                for (int i = index + 1; i < oldArray.Length - index - 1; i++)
                {
                    this.Add(oldArray[i - 1]);
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Index cannot be negative number or {this.Count - 1}.");
            }
        }

        public void Clear()
        {
            this.Count = constCountInitial;
            this.arrayT = new T[this.Capacity];
        }

        public int IndexOf(T item)
        {
            var index = -1;

            for (int i = 0; i < this.Count; i++)
            {
                if (this.arrayT[i].CompareTo(item) == 0)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                builder.Append(this.arrayT[i] + ", ");
            }

            return builder.ToString().Trim(new[] { ',', ' ' });
        }

        public T[] Sort()
        {
            for (int i = 0; i < this.Count; i++)
            {
                for (int j = i + 1; j < this.Count; j++)
                {
                    if (this.arrayT[j].CompareTo(this.arrayT[i]) < 0)
                    {
                        var temp = this.arrayT[j];
                        this.arrayT[j] = this.arrayT[i];
                        this.arrayT[i] = temp;
                    }
                }
            }

            return this.arrayT;
        }

        public T Min()
        {
            var minElement = default(T);

            if (this.count > 0)
            {
                this.arrayT = this.Sort();
                minElement = this.arrayT[0];
            }

            return minElement;
        }

        public T Max()
        {
            var maxElement = default(T);

            if (this.count > 0)
            {
                this.arrayT = this.Sort();
                maxElement = this.arrayT[this.Count - 1];
            }

            return maxElement;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                var item = this.arrayT[i];
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
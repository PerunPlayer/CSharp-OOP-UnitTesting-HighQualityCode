﻿namespace SixtyfourBitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray : IEnumerable<int>
    {
        private const int length = 64;
        private int[] bitArray;

        public BitArray(ulong value)
        {
            string bits = DecToBinary(value);

            this.bitArray = BitsToArray(bits);
        }

        public static bool operator ==(BitArray firstArr, BitArray secondArr)
        {
            return firstArr.Equals(secondArr);
        }

        public static bool operator !=(BitArray firstArr, BitArray secondArr)
        {
            return !firstArr.Equals(secondArr);
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > length - 1)
                {
                    throw new ArgumentException("Index is out of Bitarray!");
                }

                return this.bitArray[bitArray.Length - 1 - index];
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in bitArray)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            var other = obj as BitArray;

            for (int i = 0; i < length; i++)
            {
                if (this.bitArray[i] != (other.bitArray[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return bitArray.GetHashCode();
        }

        public static string DecToBinary(ulong number)
        {
            string result = String.Empty;
            do
            {
                ulong digit = number % 2;
                result = digit + result;
                number /= 2;

            } while (number != 0);

            return result.ToString().PadLeft(64, '0');
        }

        public static int[] BitsToArray(string bits)
        {
            var bitArray = new int[64];
            for (int i = 0; i < bitArray.Length; i++)
            {
                bitArray[i] = int.Parse(bits[i].ToString());
            }
            return bitArray;
        }

        public override string ToString()
        {
            return String.Join(string.Empty, this.bitArray);
        }
    }
}

namespace _3D
{
    using System;

    internal class Matrix<T>
        where T : struct, IComparable, IComparable<T>,
                  IConvertible, IEquatable<T>, IFormattable
    {
        private readonly T[,] _container;

        public Matrix(int x, int y)
        {
            this._container = new T[x, y];
        }

        public int rows => this._container.GetLength(0);

        public int cols => this._container.GetLength(1);

        public T this[int row, int col]
        {
            get
            {
                return this._container[row, col];
            }
            set
            {
                this._container[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            if (!(a.rows == b.rows && a.cols == b.cols))
            {
                throw new ArgumentException("Matrices cannot perform this operation, because of their size!");
            }

            var result = new Matrix<T>(a.rows, b.cols);

            for (int row = 0; row < a.rows; row++)
            {
                for (int col = 0; col < b.cols; col++)
                {
                    try
                    {
                        dynamic num1 = a[row, col];
                        dynamic num2 = b[row, col];

                        result[row, col] = num1 + num2;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            return result;
        }
        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            if (!(a.rows == b.rows && a.cols == b.cols))
            {
                throw new ArgumentException("Matrices cannot perform this operation, because of their size!");
            }

            var result = new Matrix<T>(a.rows, b.cols);

            for (int row = 0; row < a.rows; row++)
            {
                for (int col = 0; col < b.cols; col++)
                {
                    try
                    {
                        dynamic num1 = a[row, col];
                        dynamic num2 = b[row, col];

                        result[row, col] = num1 - num2;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("-----------------EXCEPTION-------------------");
                        throw;
                    }
                }
            }
            return result;
        }
        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            if (a.cols != b.rows)
            {
                throw new ArgumentException("Matrices cannot perform this operation, because of their size!");
            }

            var result = new Matrix<T>(a.rows, b.cols);

            for (int row = 0; row < a.rows; row++)
            {
                for (int col = 0; col < b.cols; col++)
                {
                    dynamic sum = 0;

                    try
                    {
                        for (int element = 0; element < a.cols; element++)
                        {
                            dynamic num1 = a[row, element];
                            dynamic num2 = b[element, col];

                            sum += num1 * num2;
                        }
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Invalid Data Type");
                        throw;
                    }

                    result[row, col] = sum;
                }
            }

            return result;
        }
        public static bool operator true(Matrix<T> a)
        {
            var output = true;

            for (int row = 0; row < a.rows; row++)
            {
                for (int col = 0; col < a.cols; col++)
                {
                    dynamic value = a[row, col];

                    if (value == 0)
                    {
                        output = false;
                    }
                }
            }

            return output;
        }
        public static bool operator false(Matrix<T> a)
        {
            var output = false;

            for (int row = 0; row < a.rows; row++)
            {
                for (int col = 0; col < a.cols; col++)
                {
                    dynamic value = a[row, col];

                    if (value == 0)
                    {
                        output = true;
                    }
                }
            }

            return output;
        }
        public override string ToString()
        {
            for (int row = 0; row < this.rows; row++)
            {
                for (int col = 0; col < this.cols; col++)
                {
                    Console.Write(this[row, col].ToString() + "|");
                }
            }

            return base.ToString();
        }
    }
}

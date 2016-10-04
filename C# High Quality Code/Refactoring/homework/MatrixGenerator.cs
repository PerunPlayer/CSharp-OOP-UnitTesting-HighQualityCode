using System;
using System.Text;

namespace MatrixWalk
{
    public class MatrixGenerator : Matrix
    {
        private const int MatrixMinSize = 1;
        private const int MatrixMaxSize = 100;
        private const int MaxCountDirection = 8;

        private int size = 1;
        private int[,] matrix;
        private int row = 0;
        private int col = 0;

        public MatrixGenerator(int size)
        {
            this.Size = size;

            this.matrix = new int[this.size, this.size];

            this.FindCell();
            this.FillCells();
        }

        string exceptionMessage = string.Format("Size of the matrix must be between {0} and {1}!", MatrixMinSize, MatrixMaxSize);

        public int Size
        {
            get
            {
                return this.size;
            }

            private set
            {
                if (value < MatrixMinSize || value > MatrixMaxSize)
                {
                    throw new ArgumentOutOfRangeException(exceptionMessage);
                }

                this.size = value;
            }
        }

        public override string ToString()
        {
            StringBuilder matrixToStirng = new StringBuilder();

            for (int row = 0; row < this.size; row++)
            {
                for (int col = 0; col < this.size; col++)
                {
                    matrixToStirng.AppendFormat("{0,3}", this.matrix[row, col]);
                }

                matrixToStirng.Append("\r\n");
            }

            return matrixToStirng.ToString();
        }

        private void GetDirection(ref int rowDirection, ref int colDirection)
        {
            int[] directionRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionCol = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int currentDirection = 0;

            for (int dirIndex = 0; dirIndex < MaxCountDirection; dirIndex++)
            {
                if (directionRow[dirIndex] == rowDirection && directionCol[dirIndex] == colDirection)
                {
                    currentDirection = dirIndex;
                    break;
                }
            }

            if (currentDirection == MaxCountDirection - 1)
            {
                rowDirection = directionRow[0];
                colDirection = directionCol[0];
                return;
            }

            rowDirection = directionRow[currentDirection + 1];
            colDirection = directionCol[currentDirection + 1];
        }

        private bool IsCellAvailable(int row, int col)
        {
            int[] directionRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionCol = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int directionIndex = 0; directionIndex < MaxCountDirection; directionIndex++)
            {
                int nextRow = row + directionRow[directionIndex];

                if (!this.IsInRange(nextRow))
                {
                    directionRow[directionIndex] = 0;
                }

                int nextCol = col + directionCol[directionIndex];

                if (!this.IsInRange(nextCol))
                {
                    directionCol[directionIndex] = 0;
                }
            }

            return this.IsNextCellEmpty(row, col, directionRow, directionCol);
        }

        private void FindCell()
        {
            this.row = 0;
            this.col = 0;

            for (int currRow = 0; currRow < this.size; currRow++)
            {
                for (int currCol = 0; currCol < this.size; currCol++)
                {
                    if (this.matrix[currRow, currCol] == 0)
                    {
                        this.row = currRow;
                        this.col = currCol;
                        return;
                    }
                }
            }
        }

        private void FillCells()
        {
            int directionRow = 1;
            int directionCol = 1;
            int cellValue = 1;

            while (true)
            {
                this.matrix[this.row, this.col] = cellValue;

                if (!this.IsCellAvailable(this.row, this.col))
                {
                    this.FindCell();
                    if (this.IsCellAvailable(this.row, this.col))
                    {
                        cellValue++;
                        this.matrix[this.row, this.col] = cellValue;
                        directionRow = 1;
                        directionCol = 1;
                    }
                    else
                    {
                        break;
                    }
                }

                int nextRow = this.row + directionRow;
                int nextCol = this.col + directionCol;

                if (!this.IsInRange(nextRow) || !this.IsInRange(nextCol) || this.matrix[nextRow, nextCol] != 0)
                {
                    while (!this.IsInRange(nextRow) || !this.IsInRange(nextCol) || this.matrix[nextRow, nextCol] != 0)
                    {
                        this.GetDirection(ref directionRow, ref directionCol);

                        nextRow = this.row + directionRow;
                        nextCol = this.col + directionCol;
                    }
                }

                this.row = nextRow;
                this.col = nextCol;
                cellValue++;
            }
        }

        private bool IsNextCellEmpty(int row, int col, int[] directionRow, int[] directionCol)
        {
            for (int directionIndex = 0; directionIndex < MaxCountDirection; directionIndex++)
            {
                int nextRow = row + directionRow[directionIndex];
                int nextCol = col + directionCol[directionIndex];

                if (this.matrix[nextRow, nextCol] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsInRange(int value)
        {
            if (value >= this.size || value < 0)
            {
                return false;
            }

            return true;
        }
    }
}

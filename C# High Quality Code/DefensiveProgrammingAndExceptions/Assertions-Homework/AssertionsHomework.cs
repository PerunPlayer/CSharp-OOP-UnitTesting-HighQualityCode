using System;
using System.Diagnostics;

class AssertionsHomework
{
    public static void SelectionSort<T>(T[] arrayToSort) where T : IComparable<T>
    {
        Debug.Assert(arrayToSort != null, "The array is null!");

        for (int index = 0; index < arrayToSort.Length-1; index++)
        {
            int minElementIndex = FindMinElementIndex(arrayToSort, index, arrayToSort.Length - 1);
            Swap(ref arrayToSort[index], ref arrayToSort[minElementIndex]);
        }
    }
  
    private static int FindMinElementIndex<T>(T[] elementsToFind, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        Debug.Assert(elementsToFind != null, "The array parameter is null!");
        Debug.Assert(startIndex <= endIndex, "startIndex is greater than endIndex!");
        Debug.Assert(endIndex == elementsToFind.Length - 1, "endIndex is not the last element of the array!");

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (elementsToFind[i].CompareTo(elementsToFind[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        Debug.Assert(0 <= minElementIndex, "minElementIndex is less than zero!");
        Debug.Assert(minElementIndex <= endIndex, "minElementIndex is greater than array size!");

        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        Debug.Assert(x != null, "x is null!");
        Debug.Assert(y != null, "y is null!");

        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] colectionToSearch, T value) where T : IComparable<T>
    {
        Debug.Assert(colectionToSearch != null, "The colection is null!");
        Debug.Assert(value != null, "value is null!");

        var index = BinarySearch(colectionToSearch, value, 0, colectionToSearch.Length - 1);

        Debug.Assert(index <= colectionToSearch.Length, "index is greater than colection size!");

        return index;
    }

    private static int BinarySearch<T>(T[] colectionToSearch, T value, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        while (startIndex <= endIndex)
        {
            Debug.Assert(startIndex >= 0, "startIndex is less than zero!");
            Debug.Assert(endIndex < colectionToSearch.Length, "endIndex is greater than array size!");

            int midIndex = (startIndex + endIndex) / 2;
            if (colectionToSearch[midIndex].Equals(value))
            {
                return midIndex;
            }
            if (colectionToSearch[midIndex].CompareTo(value) < 0)
            {
                startIndex = midIndex + 1;
            }
            else 
            {
                endIndex = midIndex - 1;
            }
        }

        return -1;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]);
        SelectionSort(new int[1]);

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class DamageMergeSort {

    public static void DoMergeSort(this int[] numbers)
    {
        var sortedNumbers = MergeSorter(numbers);

        for(int i = 0; i < sortedNumbers.Length; i++)
            numbers[i] = sortedNumbers[i];
    }

    private static int[] MergeSorter(int[] numbers)
    {
        if (numbers.Length <= 1)
            return numbers; //base case


        var left = new List<int>();
        var right = new List<int>();

        Divide(numbers, left, right);

        left = MergeSorter(left.ToArray()).ToList();
        right = MergeSorter(right.ToArray()).ToList();

        return Merge(left, right);
    }

    private static void Divide(int[] numbers, List<int> left, List<int> right)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 > 0) //takes mod of i, if it returns 1 then it is odd else positive
                left.Add(numbers[i]);

            else
                right.Add(numbers[i]);
        }
    }

    private static int[] Merge(List<int> left, List<int> right)
    {
        var result = new List<int>();

        while (NotEmpty(left) && NotEmpty(right))
        {
            if (left.First() <= right.First())
                MoveValueToResult(left, result);

            else
                MoveValueToResult(right, result);
        }

        while (NotEmpty(left))
        {
            MoveValueToResult(left, result);
        }

        while (NotEmpty(right))
        {
            MoveValueToResult(right, result);
        }

        return result.ToArray();
    }

    private static bool NotEmpty(List<int> list)
    {
        return list.Count > 0;
    }
    
    private static void MoveValueToResult (List<int> list, List<int> result)
    {
        result.Add(list.First());
        list.RemoveAt(0);
    }
}

using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int[] leftSlices = new int[A.Length];
        int[] rightSlices = new int[A.Length];

        for(int i = 1; i < A.Length; i++)
        {
            leftSlices[i] = Math.Max(0, leftSlices[i - 1] + A[i]);
        }

        for(int i = A.Length - 2; i >0; i--)
        {
            rightSlices[i] = Math.Max(0, rightSlices[i + 1] + A[i]);
        }

        int maxDoubleSlice = 0;
        for(int i = 1; i < A.Length - 1; i++)
        {
            maxDoubleSlice = Math.Max(maxDoubleSlice, leftSlices[i - 1] + rightSlices[i + 1]);
        }

        return maxDoubleSlice;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2Task1
{
    public class Solution
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            //Solution is based on bitwise XOR
            //http://www.ardendertat.com/2011/12/13/programming-interview-questions-22-find-odd-occurring-element/
            //http://www.geeksforgeeks.org/find-the-two-numbers-with-odd-occurences-in-an-unsorted-array/

            var result = 0;
            for (int i = 0; i < A.Length; i++) 
            {
                result ^= A[i];
            }

            return result;
        }
    }
}

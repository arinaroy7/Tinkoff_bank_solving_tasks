using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        List<long> powersOfTwo = new List<long>();

        for (int i = 0; i <= 60; i++) {
            powersOfTwo.Add(1L << i); // 2^i
        }

        List<long> validSums = new List<long>();

        for (int i = 0; i < powersOfTwo.Count; i++) {
            for (int j = i + 1; j < powersOfTwo.Count; j++) {
                for (int k = j + 1; k < powersOfTwo.Count; k++) {
                    long sum = powersOfTwo[i] + powersOfTwo[j] + powersOfTwo[k];
                    validSums.Add(sum);
                }
            }
        }
        validSums.Sort();

        while (n-- > 0) {
            long money = long.Parse(Console.ReadLine());
            int index = BinarySearch(validSums, money);
            Console.WriteLine(index >= 0 ? validSums[index] : -1);
        }
    }

    static int BinarySearch(List<long> arr, long target) {
        int left = 0, right = arr.Count - 1, bestIndex = -1;
        while (left <= right) {
            int mid = (left + right) / 2;
            if (arr[mid] <= target) {
                bestIndex = mid;
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        return bestIndex;
    }
}
/*using System; // НЕВЕРНАЯ ВЕРОЯТНО
class Program {
    static void Main(string[] args) {
        var days = Console.ReadLine().Split();
        var (n, m) = (int.Parse(days[0]), int.Parse(days[1]));

        var limits = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int lowerBound = limits[0], upperBound = limits[1];

        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int goodDays = 0;

        for (int i=0; i < numbers.Length; i++) {
            if (numbers[i] >= lowerBound && numbers[i] <= upperBound) {
                goodDays = i;
            }
            else if (numbers[i] < numbers[0]) { 
                goodDays++;
            }
            else if (numbers[i] > numbers[1]) {
                goodDays = i - 1;
            }
        }
        Console.WriteLine((goodDays+1));
    }
}*/
using System;
using System.Linq;

class Program
{
    static void Solve()
    {
        int n, m;
        string[] nm = Console.ReadLine().Split();
        n = int.Parse(nm[0]);
        m = int.Parse(nm[1]);

        long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long x = a[0];
        long y = a[1];

        long[] b = a.Skip(2).ToArray();
        Array.Sort(b);

        long ans = long.MaxValue;
        for (int r = m - 1; r < b.Length; ++r)
        {
            int l = r - m + 1;
            long need_x = 0;
            long need_y = 0;

            if (x > b[l]) need_x = x - b[l];
            if (y < b[r]) need_y = b[r] - y;

            ans = Math.Min(ans, need_x + need_y);
        }

        Console.WriteLine(ans);
    }

    static void Main()
    {
        int t = 1;
        while (t-- > 0)
        {
            Solve();
        }
    }
}
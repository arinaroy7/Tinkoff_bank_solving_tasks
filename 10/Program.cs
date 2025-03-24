using System;

class Program
{
    static void Solve()
    {

        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]); 
        long s = long.Parse(input[1]); 

        long[] a = new long[n + 1];
        long[] prefixSum = new long[n + 1];

        for (int i = 1; i <= n; ++i)
        {
            a[i] = long.Parse(Console.ReadLine()); 
            s = Math.Max(s, a[i]);
            prefixSum[i] = prefixSum[i - 1] + a[i];
        }

        int j = 1;
        long[] cntClose = new long[n + 1];

        for (int i = 1; i <= n; ++i)
        {
            while (j <= n && prefixSum[j] - prefixSum[i - 1] <= s)
            {
                j++;
            }
            if (j == n + 1) break;
            j--;
            cntClose[j] += 1 + cntClose[i - 1];
        }

        long ans = 0;
        for (int i = 1; i <= n; ++i)
        {
            ans += cntClose[i] * (n - i);
        }

        ans += (n * (n + 1)) / 2;
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
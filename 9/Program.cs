using System;
using System.Linq;

class Program
{
    const int MOD = 998244353;

    static int Add(int x, int y)
    {
        return (x + y) % MOD;
    }

    static int Mult(int x, int y)
    {
        return (int)((x * 1L * y) % MOD);
    }

    static int Sub(int x, int y)
    {
        return (x - y + MOD) % MOD;
    }

    static void Solve()
    {
        int n, k;
        string[] nk = Console.ReadLine().Split();
        n = int.Parse(nk[0]);
        k = int.Parse(nk[1]);

        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] prefixSum = new int[k + 1];
        prefixSum[0] = n;

        for (int i = 0; i < n; ++i)
        {
            int res = 1;
            for (int j = 1; j <= k; ++j)
            {
                res = Mult(res, a[i]);
                prefixSum[j] = Add(prefixSum[j], res);
            }
        }

        int[] twoPow = new int[k + 1];
        twoPow[0] = 1;
        for (int i = 1; i <= k; ++i)
        {
            twoPow[i] = Mult(twoPow[i - 1], 2);
        }

        int[,] C = new int[k + 1, k + 1];
        for (int i = 0; i <= k; ++i)
        {
            C[i, 0] = C[i, i] = 1;
            for (int j = 1; j < i; ++j)
            {
                C[i, j] = Add(C[i - 1, j - 1], C[i - 1, j]);
            }
        }

        int inv2 = 499122177;

        for (int i = 1; i <= k; ++i)
        {
            int A = 0;
            for (int j = 0; j <= i; ++j)
            {
                int res = Mult(C[i, j], prefixSum[j]);
                res = Mult(res, prefixSum[i - j]);
                A = Add(A, res);
            }
            int B = Mult(twoPow[i - 1], prefixSum[i]);
            A = Mult(A, inv2);
            Console.WriteLine(Sub(A, B));
        }
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

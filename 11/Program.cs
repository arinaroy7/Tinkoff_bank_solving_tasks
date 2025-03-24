using System;

class Program
{
    static void Solve()
    {
        int n = int.Parse(Console.ReadLine());
        int[] x = new int[n];
        int[] y = new int[n];

        for (int i = 0; i < n; ++i)
        {
            string[] input = Console.ReadLine().Split();
            x[i] = int.Parse(input[0]);
            y[i] = int.Parse(input[1]);
        }

        int maxInLine = 0;
        for (int i = 0; i < n; ++i)
        {
            for (int j = i + 1; j < n; ++j)
            {
                int cntInLine = 0;
                for (int k = 0; k < n; ++k)
                {
                    if ((long)(x[k] - x[i]) * (y[j] - y[i]) == (long)(y[k] - y[i]) * (x[j] - x[i]))
                    {
                        cntInLine++;
                    }
                }

                maxInLine = Math.Max(maxInLine, cntInLine);
            }
        }

        if (maxInLine <= (2 * n) / 3)
        {
            Console.WriteLine(n / 3);
        }
        else
        {
            Console.WriteLine(n - maxInLine);
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
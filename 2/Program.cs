using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int n) || n < 3)
        {
            Console.WriteLine(0);
            return;
        }

        var points = new List<(int, int)>();

        for (int i = 0; i < n; i++)
        {
            string? coordinates = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(coordinates))
            {
                Console.WriteLine(0);
                return;
            }

            var parts = coordinates.Split();
            if (parts.Length != 2 || 
                !int.TryParse(parts[0], out int x) || 
                !int.TryParse(parts[1], out int y))
            {
                Console.WriteLine(0);
                return;
            }

            points.Add((x, y));
        }

        Console.WriteLine(FindMaxHappyTriangles(points));
    }

    static int FindMaxHappyTriangles(List<(int, int)> points)
    {
        int n = points.Count;
        var used = new bool[n];
        int triangleCount = 0;

        for (int i = 0; i < n; i++)
        {
            if (used[i]) continue;
            for (int j = i + 1; j < n; j++)
            {
                if (used[j]) continue;
                for (int k = j + 1; k < n; k++)
                {
                    if (used[k]) continue;

                    if (IsTriangle(points[i], points[j], points[k]))
                    {
                        used[i] = true;
                        used[j] = true;
                        used[k] = true;
                        triangleCount++;
                        break;
                    }
                }
            }
        }

        return triangleCount;
    }

    static bool IsTriangle((int, int) p1, (int, int) p2, (int, int) p3)
    {
        int area = p1.Item1 * (p2.Item2 - p3.Item2) + 
                   p2.Item1 * (p3.Item2 - p1.Item2) + 
                   p3.Item1 * (p1.Item2 - p2.Item2);
        return area != 0;
    }
}
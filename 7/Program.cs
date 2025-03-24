using System;
using System.Linq;

class Program {
    static void Main() {
        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long n = input[0], x = input[1], y = input[2], z = input[3];

        var a = Console.ReadLine().Split().Select(long.Parse).ToArray();

        long minX = long.MaxValue, minY = long.MaxValue, minZ = long.MaxValue;
        
        foreach (var num in a) {
            minX = Math.Min(minX, (x - num % x) % x);
            minY = Math.Min(minY, (y - num % y) % y);
            minZ = Math.Min(minZ, (z - num % z) % z);
        }
        
        long[] minOps = { minX, minY, minZ };
        Array.Sort(minOps);
        
        long result = minOps[0] + minOps[1]; 
        Console.WriteLine(result+1);
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

class Program {
    static void Main(string[] args) {
        var n = Convert.ToInt32(Console.ReadLine());
        var points = new Point[n];

        var triangles = 0;

        for (int i = 0; i < n; i++) {
            var line = Console.ReadLine().Split(); 
            int x = int.Parse(line[0]); 
            int y = int.Parse(line[1]); 

            points[i] = new Point(x, y);
        }

        for (int i = 0; i < n - 2; i++) {
            for (int j = i + 1; j < n - 1; j++) {
                for (int k = j + 1; k < n; k++) {
                    if (!AreCollinear(points[i], points[j], points[k])) {
                        triangles++;
                    }
                }
            }
        }

        Console.WriteLine(triangles);
    }

    static bool AreCollinear(Point p1, Point p2, Point p3) {
        return (p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y)) == 0;
    }
}
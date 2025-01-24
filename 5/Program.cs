using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Напишите количество дней, за которые Борис будет покупать цветы: ");
        int n = int.Parse(Console.ReadLine());

        int[] money = new int[n];
        for (int i = 0; i < n; i++) {
            Console.WriteLine($"Введите количество денег для {i + 1}-го дня: ");
            money[i] = int.Parse(Console.ReadLine());
        }

        int[] flowerPrices = Enumerable.Range(1, 100).ToArray();

        foreach (int moneyAmount in money) {
            int result = CountFlowers(moneyAmount, flowerPrices);
            Console.WriteLine(result);
        }
    }

    static int CountFlowers(int money, int[] flowerPrices) {
        int maxSum = -1;

        for (int i = 0; i < flowerPrices.Length - 2; i++) {
            for (int j = i + 1; j < flowerPrices.Length - 1; j++) {
                for (int k = j + 1; k < flowerPrices.Length; k++) {
                    int totalCost = flowerPrices[i] + flowerPrices[j] + flowerPrices[k];
                    if (totalCost < money && totalCost > maxSum) {
                        maxSum = totalCost;
                    }
                }
            }
        }
        return maxSum;
    }
}
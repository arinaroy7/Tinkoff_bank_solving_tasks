using System;

class Program {
    static void Main(string[] args) {
        int i, a;
        int sum;
        -32000 <= i <= 32000 && -32000 <= a <= 32000;
        sum = i + a;
        Console.WriteLine("Напишите значение i: ");
        Console.WriteLine("Напишите значение a: ");
        Console.WriteLine("Сумма равна: " + sum + "рублей.");
    } 
}
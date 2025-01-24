using System;

class Program {
    static void Main(string[] args) {
        const string str1= "RSM";
        const string str2 = "RMS";

        Console.WriteLine("Введите строку, состоящую из трех букв: R, S, M ");
        string str = Console.ReadLine();

        if (checkString(str, str1, str2))
        {
            Console.WriteLine("Yes"); 
        }
        else {
            Console.WriteLine("No");
        }
    }
    static bool checkString(string str, string str1, string str2) {
        bool result = str == str1 || str == str2;
        return result;
    }
}
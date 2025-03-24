/*using System;

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
}*/
using System;

class Program
{
    static void Solve()
    {
        string s = Console.ReadLine();
        int posR = 0;
        int posM = 0;

        for (int i = 0; i < 3; ++i)
        {
            if (s[i] == 'R') posR = i;
            if (s[i] == 'M') posM = i;
        }

        if (posR < posM)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
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

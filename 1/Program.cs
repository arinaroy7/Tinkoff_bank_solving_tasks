using System; 
class Program {
    static void Main() {
        Console.WriteLine("Введите стоимость тарифа Кости: ");
        string? A = Console.ReadLine(); 
        int.TryParse(A, out int a);
        a = a != 0 ? a : 0;
        Console.WriteLine("Введите размер тарифа Кости: ");
        string? B = Console.ReadLine();
        int.TryParse(B, out int b);
        b = b != 0 ? b : 0;
        Console.WriteLine("Введите стоимость каждого лишнего мегабайта: ");
        string? C = Console.ReadLine();
        int.TryParse(C, out int c);
        c = c != 0 ? c : 0;
        Console.WriteLine("Введите размер интернет-трафика Кости в следующем месяце: ");
        string? D = Console.ReadLine();
        int.TryParse(D, out int d);
        d = d != 0 ? d : 0;

        Check(a, b, c, d);
    }
    private static void  Check(int a, int b, int c, int d) {
        if (a <= 0 || c <= 0) {
            Console.WriteLine("Значение подобрано неверно, повторите попытку");
            return;
        }
        else {
            CostInvoice(a, b, c, d);
        }
    }
    private static void CostInvoice( int a, int b, int c, int d) {
        if ( b > d) {
            Console.WriteLine("Костя не превышает тариф, абонентская плата составит: " + a + "рублей.");
        }
        else {
            a = a + (d-b)*c;
            Console.WriteLine("Стоимость тарифа Кости в следующем месяце составит: " + a + "рублей.");
        }
    }
}
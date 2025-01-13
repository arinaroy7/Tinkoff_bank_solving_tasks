using System; 
class Program {
    static void Main(string[] args) {
        Console.WriteLine("Введите стоимость тарифа Кости: ");
        int a = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Введите размер тарифа Кости: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите стоимость каждого лишнего мегабайта: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите размер интернет-трафика Кости в следующем месяце: ");
        int d = int.Parse(Console.ReadLine());

        Check(a, b, c, d);
    }
    private static void  Check(int a, int b, int c, int d) {
        if (a < 0 || c < 0) {
            Console.WriteLine("Значение подобрано неверно, повторите попытку");
            return;
        }
    }
    private static void CostInvoice( int a, int b, int c, int d) {
        if ( b > d) {
            Console.WriteLine("Костя не превышает тариф, абонентская плата составит: ");
            Console.WriteLine(a);
        }
        else {
            a = a + (d-b)*c;
            Console.WriteLine("Стоимость тарифа Кости в следующем месяце составит: ");
            Console.WriteLine(a);  
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so thu nhat: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap so thu hai: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Nhap so thu ba: ");
        int c = int.Parse(Console.ReadLine());

        int tong = a + b + c;

        Console.WriteLine("Tong 3 so la: " + tong);
    }
}

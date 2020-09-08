using System;

namespace chuyendoitiente
{
    class Program
    {
        static void Main(string[] args)
        {


            int tigia = 23000;
            Console.WriteLine("Nhap USD :");
            int usd = int.Parse(Console.ReadLine());
            int vnd = tigia * usd;
            Console.WriteLine("VNĐ là : {0} Vnđ", vnd);
            Console.ReadKey();
        }
    }
}

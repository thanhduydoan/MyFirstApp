using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CPhanSo ps1 = new CPhanSo(1, 2);
            CPhanSo ps2 = new CPhanSo(2, 4);
            CPhanSo psTong = new CPhanSo();
            //nhap phan so
            Console.WriteLine("Nhap vao phan so thu nhat");
            ps1.nhapPS();
            Console.WriteLine("Nhap vao phan so thu hai");
            ps2.nhapPS();
            //tinh tong
            psTong = ps1.tinhTongPS(ps2);
        }
    }
}

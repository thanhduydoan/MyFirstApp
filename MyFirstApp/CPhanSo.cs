using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class CPhanSo
    {
        //thuoc tinh 
        private int tuSo;
        private int mauSo;
        //phuong thuc
        //ham khoi tao khong doi so
        public CPhanSo()
        {
            tuSo = 0;
            mauSo = 1;
        }
        //ham khoi tao co doi so
        public CPhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }
        //ham nhap phan so
        public void nhapPS()
        {
            int a;
            int b;
            do
            {
                Console.Write("Nhap vao tu so: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Nhap vao mau so: ");
                a = int.Parse(Console.ReadLine());
                //kiem tra dieu kien
                if (b==0)
                {

                    Console.WriteLine("Hãy nhập mẫu khác 0");
                }
                else
                {
                    tuSo = a;
                    mauSo = b;
                }    
            }
            while (b == 0);
        }
        //ham hien thi phan so
        public void hienThiPS()
        {
            if(tuSo*mauSo<0)
            {
                Console.WriteLine("-" + Math.Abs(tuSo) + "/" + Math.Abs(mauSo));
            }  
            else
            {
                Console.WriteLine(Math.Abs(tuSo) + "/" + Math.Abs(mauSo));
            }    
        }
        //ham tinh tong 2 phan so
        public CPhanSo tinhTongPS(CPhanSo ps2)
        {
            int tu = tuSo * ps2.mauSo + ps2.tuSo * mauSo;
            int mau = mauSo * ps2.mauSo;

            return new CPhanSo(tu, mau);
        }
        //ham tinh hieu 2 phan so
        public CPhanSo tinhHieuPS(CPhanSo ps3)
        {
            int tu = tuSo * ps3.mauSo - ps3.tuSo * mauSo;
            int mau = mauSo * ps3.mauSo;
            return new CPhanSo(tu, mau);
        }
        //ham tinh tich 2 phan so
        public CPhanSo tinhTichPS(CPhanSo ps3)
        {
            int tu = tuSo * ps3.tuSo;
            int mau = mauSo * ps3.mauSo;
            return new CPhanSo(tu, mau);
        }
    }
}

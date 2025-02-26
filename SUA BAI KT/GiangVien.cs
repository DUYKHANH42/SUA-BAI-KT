using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUA_BAI_KT
{
    public class GiangVien
    {
        private string maso;
        private string hoten;
        private int namsinh;
        public GiangVien(string maso, string hoten, int namsinh)
        {
            this.maso = maso;
            this.hoten = hoten;
            this.namsinh = namsinh;
        }
        public GiangVien()
        {
            maso = "";
            hoten = "";
            namsinh = 0;
        }
        public string Maso
        {
            get { return maso; }
            set { maso = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public int Namsinh
        {
            get { return namsinh; }
            set { namsinh = value; }
        }
        public virtual void Nhap()
        {
            
            Console.Write("Nhap ma so: ");
            maso = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            namsinh = int.Parse(Console.ReadLine());
        }
        public virtual double TinhLuong()
        {
            return 0;
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Ma so: " + maso);
            Console.WriteLine("Ho ten: " + hoten);
            Console.WriteLine("Nam sinh: " + namsinh);
        }
    }
}

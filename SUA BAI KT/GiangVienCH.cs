using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUA_BAI_KT
{
    public class GiangVienCH : GiangVien
    {
        private float hesoluong;
        public GiangVienCH(string maso, string hoten, int namsinh, float hesoluong) : base(maso, hoten, namsinh)
        {
            this.hesoluong = hesoluong;
        }
        public GiangVienCH() : base()
        {
            hesoluong = 0;
        }
        public float Hesoluong
        {
            get { return hesoluong; }
            set { hesoluong = value; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap he so luong: ");
            hesoluong = float.Parse(Console.ReadLine());
        }
        public override double TinhLuong()
        {
            return hesoluong* 23400000;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("He so luong: " + hesoluong);
            Console.WriteLine("Luong: " + TinhLuong());
        }
    }
}

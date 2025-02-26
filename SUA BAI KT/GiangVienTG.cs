using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUA_BAI_KT
{
    public class GiangVienTG: GiangVien
    {
        private int sotietday;
        public GiangVienTG(string maso, string hoten, int namsinh, int sotietday) : base(maso, hoten, namsinh)
        {
            this.sotietday = sotietday;
        }
        public GiangVienTG() : base()
        {
            sotietday = 0;
        }
        public int Sotietday
        {
            get { return sotietday; }
            set { sotietday = value; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so tiet day: ");
            sotietday = int.Parse(Console.ReadLine());
        }
        public override double TinhLuong()
        {
            return sotietday * 120000;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So tiet day: " + sotietday);
            Console.WriteLine("Luong: " + TinhLuong());
        }
    }
}

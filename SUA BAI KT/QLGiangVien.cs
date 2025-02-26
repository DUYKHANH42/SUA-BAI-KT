using System;
using System.Collections.Generic;

namespace SUA_BAI_KT
{
    public class QLGiangVien
    {
        List<GiangVien> dsGiangVien = new List<GiangVien>();
        public QLGiangVien()
        {
            dsGiangVien = new List<GiangVien>();
        }
        public void DuLieuSan()
        {
            dsGiangVien.Add(new GiangVienTG { Maso = "123", Hoten = "Nguyễn Văn A", Namsinh = 1980, Sotietday = 10 });
            dsGiangVien.Add(new GiangVienTG { Maso = "133", Hoten = "Nguyễn Văn B", Namsinh = 1980, Sotietday = 20 });
            dsGiangVien.Add(new GiangVienCH { Maso = "173", Hoten = "Nguyễn Văn Tèo", Namsinh = 1984, Hesoluong = 3 });
            dsGiangVien.Add(new GiangVienCH { Maso = "183", Hoten = "Nguyễn Văn Hai", Namsinh = 1989, Hesoluong = 2 });
        }
        public void Nhap()
        {
            string chon;
            do
            {
                Console.Write("Nhap loai giang vien (1: Co huu, 2: Thinh giang): ");
                int loaigv = int.Parse(Console.ReadLine());
                GiangVien gv = null;
                if (loaigv == 1)
                {
                    gv = new GiangVienCH();
                }
                else if (loaigv == 2)
                {
                    gv = new GiangVienTG();
                }
                else
                {
                    Console.WriteLine("Loai giang vien khong hop le!");
                    return;
                }
                gv.Nhap();
                dsGiangVien.Add(gv);
                Console.Write("Ban co muon nhap tiep khong? (Y/N): ");
                chon = Console.ReadLine();

            } while (chon == "Y" || chon == "y");
        }
        public void TinhTongLuong()
        {
            double tong = 0;
            foreach (GiangVien gv in dsGiangVien)
            {
                tong += gv.TinhLuong();
            }
            Console.WriteLine($"Tong luong cua tat ca giang vien la: {tong.ToString("#,0.0")} VND ");
        }
        public void XoaGV()
        {
            Console.Write("Nhap ma so giang vien can xoa: ");
            string maso = Console.ReadLine();
            for (int i = 0; i < dsGiangVien.Count; i++)
            {
                if (dsGiangVien[i].Maso == maso)
                {
                    dsGiangVien.RemoveAt(i);
                    Console.WriteLine("Xoa thanh cong!");
                    return;
                }
            }
            Console.WriteLine($"Khong tim thay giang vien co ma so {maso}!");
        }
        public void Xuat()
        {
            Console.WriteLine("{0,-20}{1,-15}{2,15}{3,15}"
          , "Ma So Giang Vien", "Ho Ten Giang Vien", "Nam Sinh", "Muc Luong");
            foreach (GiangVien gv in dsGiangVien)
            {

                Console.WriteLine("{0,-20}{1,-15}{2,15}{3,15}"
              , gv.Maso, gv.Hoten, gv.Namsinh, gv.TinhLuong().ToString("#,0.0"));
            }
        }

    }
}

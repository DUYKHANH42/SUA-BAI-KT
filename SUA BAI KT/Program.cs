using System;

namespace SUA_BAI_KT
{
    public class Program
    {
        static void Main(string[] args)
        {
            QLGiangVien GV = new QLGiangVien();
            GV.DuLieuSan();
            int chon;
            do
            {
                Console.WriteLine("------------Danh Sách Giảng Viên------------");
                Console.WriteLine("1.Nhập Giảng Viên.");
                Console.WriteLine("2.Xóa Giảng Viên.");
                Console.WriteLine("3.Xuất Giảng Viên.");
                Console.WriteLine("4.Xuất Tổng Tiền Nhà Trường Trả Cho Giảng Viên.");
                Console.WriteLine("5.Thoát");
                Console.Write("Chọn: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        GV.Nhap();
                        break;
                    case 2:
                        GV.XoaGV();
                        break;
                    case 3:
                        GV.Xuat();
                        break;
                    case 4:
                        GV.TinhTongLuong();
                        break;
                    case 5:
                        Console.WriteLine("Thoát.");
                        break;
                    default:
                        Console.WriteLine("Chọn không hợp lệ.");
                        break;
                }
            }
            while (chon != 5);
            Console.ReadLine();
        }
    }
}


namespace GIUAKI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static TaiLieu NhapTaiLieu()
            {
                TaiLieu taiLieu = new TaiLieu();
                Console.Write("Nhap ma tai lieu: ");

                taiLieu.TenTaiLieu = Console.ReadLine();
                Console.Write("Nhap loai tai lieu: ");

                taiLieu.TacGia = Console.ReadLine();
                Console.Write("Nhap tac giả: ");

                taiLieu.NamXuatBan = int.Parse(Console.ReadLine());


                return taiLieu;
            }
            static NguoiDung NhapNguoiDung()
            {
                NguoiDung nguoiDung = new NguoiDung();
                Console.Write("Nhap ma nguoi dung: ");
                nguoiDung.TenNguoiDung = Console.ReadLine();
                Console.Write("Nhap ten nguoi dung: ");

                nguoiDung.Email = Console.ReadLine();
                Console.Write("Nhap so dien thoai: ");
                nguoiDung.SoDienThoai = Console.ReadLine();

                return nguoiDung;
            }
            List<TaiLieu> danhSachTaiLieu = new List<TaiLieu>();
            List<NguoiDung> danhSachNguoiDung = new List<NguoiDung>();
            List<TaiLieuNguoiDung> danhSachTaiLieuNguoiDung = new List<TaiLieuNguoiDung>();
            // Thêm tài liệu
            TaiLieu taiLieu2 = new TaiLieu { ID = 1, TenTaiLieu = "Sách Toán", MoTa = "Sách giáo khoa lớp 12", TacGia = "Nguyễn Văn A", NamXuatBan = 2019 };
            danhSachTaiLieu.Add(taiLieu);
            TaiLieu taiLieu1 = new TaiLieu { ID = 2, TenTaiLieu = "Sách văn", MoTa = "Sách giáo khoa lớp 12", TacGia = "Nguyễn Văn B", NamXuatBan = 2020 };
            danhSachTaiLieu.Add(taiLieu1);

            // Thêm người dùng
            NguoiDung nguoiDung = new NguoiDung { ID = 1, TenNguoiDung = "Nguyễn Văn C", Email = "nguyenvanc@gmail.com", SoDienThoai = "0901234567" };
            danhSachNguoiDung.Add(nguoiDung);
            NguoiDung nguoiDung1 = new NguoiDung { ID = 1, TenNguoiDung = "Nguyễn Văn D", Email = "nguyenvand@gmail.com", SoDienThoai = "0901234567" };
            danhSachNguoiDung.Add(nguoiDung1);
            // thêm tai lieu nguoi dung 
            TaiLieuNguoiDung taiLieuNguoiDung2 = new TaiLieuNguoiDung { ID = 1, TaiLieuID = 01, NguoiDungID = 01 };
            danhSachTaiLieuNguoiDung.Add(taiLieuNguoiDung2);
            TaiLieuNguoiDung taiLieuNguoiDung3 = new TaiLieuNguoiDung { ID = 2, TaiLieuID = 02, NguoiDungID = 02 };
            danhSachTaiLieuNguoiDung.Add(taiLieuNguoiDung3);
            // Sửa tài liệu
            taiLieu1.TenTaiLieu = "Sách Toán lớp 11";
            // Sửa nguoid dùng
            nguoiDung.TenNguoiDung = "Nguyen thi E";
            // Sửa tai lieu nguoi dung
            taiLieuNguoiDung2.NguoiDungID = 5;


            // Xóa người dùng
            danhSachNguoiDung.Remove(nguoiDung1);
            // Xóa tai lieu
            danhSachTaiLieu.Remove(taiLieu1);

            // Xóa tài liệu người dùng
            danhSachTaiLieuNguoiDung.Remove(taiLieuNguoiDung2);
        }
    }
}

#!/usr/bin/python
#-*- coding: utf-8 -*-

class NVBanHang:
    """Class Nhân viên bán hàng"""
    def __init__(self, MaNV, Hoten, LuongCB):
        self.MaNV = MaNV
        self.Hoten = Hoten
        self.Luongcoban = LuongCB
        self.Sosanpham = 100
        self.LuongHT = 0

    def Xuatthongtin_NVBH(self):
        self.LuongHT = self.Luongcoban + self.Sosanpham * 18_000
        print("Thông tin Nhân viên Bán hàng:")
        print("\t+ Mã nhân viên :", self.MaNV)
        print("\t+ Họ tên :", self.Hoten)
        print("\t+ Lương cơ bản :", "{:,.0f} VNĐ".format(self.Luongcoban).replace(",", "."))
        print("\t+ Số sản phẩm :", self.Sosanpham)
        print("\t+ Lương hằng tháng :", "{:,.0f} VNĐ".format(self.LuongHT).replace(",", "."))
        print()

    def Tinhluong_NVBH(self):
        self.LuongHT = self.Luongcoban + self.Sosanpham * 18_000

class NVVanPhong:
    """Class Nhân viên văn phòng"""
    def __init__(self, MaNV, Hoten, LuongCB):
        self.MaNV = MaNV
        self.Hoten = Hoten
        self.Luongcoban = LuongCB
        self.Songay = 100
        self.LuongHT = 0

    def Xuatthongtin_NVVP(self):
        self.LuongHT = self.Luongcoban + self.Songay * 150_000
        print("Thông tin Nhân viên Văn phòng:")
        print("\t+ Mã nhân viên :", self.MaNV)
        print("\t+ Họ tên :", self.Hoten)
        print("\t+ Lương cơ bản :", "{:,.0f} VNĐ".format(self.Luongcoban).replace(",", "."))
        print("\t+ Số ngày :", self.Songay)
        print("\t+ Lương hằng tháng :", "{:,.0f} VNĐ".format(self.LuongHT).replace(",", "."))
        print()

    def Tinhluong_NVVP(self):
        self.LuongHT = self.Luongcoban + self.Songay * 150_000

class CongTy:
    """Class Công Ty quản lý các nhân viên"""
    def __init__(self, Macongty, Tencongty):
        self.Macongty = Macongty
        self.Tencongty = Tencongty
        self.DanhsachNV = []

    def KhoitaoNV(self, LoaiNV, MaNV, Hoten, LuongCB):
        """Khởi tạo tự động các nhân viên"""
        if LoaiNV == "NVBanHang":
            nhan_vien1 = NVBanHang(MaNV, Hoten, LuongCB)
        elif LoaiNV == "NVVanPhong":
            nhan_vien1 = NVVanPhong(MaNV, Hoten, LuongCB)
        else:
            raise ValueError("Loại nhân viên không hợp lệ (LoaiNV, MaNV, Hoten, LuongCB), LoaiNV phải là NVBanHang hoặc NVVanPhong")
        #Thêm các nhân viên vào Danh Sách Nhân Viên
        self.DanhsachNV.append(nhan_vien1)


    def TinhLuong(self):
        """Tính lương hằng tháng"""
        for nhan_vien2 in self.DanhsachNV:
            #Hàm isinstance kiểm tra xem một đối tượng có thuộc kiểu dữ liệu cụ thể hay không. Nó trả về True nếu đối tượng thuộc kiểu dữ liệu được xác định và False nếu không thuộc.
            #Dùng đối tượng nhan_vien để so sánh có giống đối tượng NVVanPhong. Nếu chuẩn thì dùng công thức
            if isinstance(nhan_vien2, NVVanPhong):
                nhan_vien2.LuongHT = nhan_vien2.Luongcoban + nhan_vien2.Songay * 150_000
            elif isinstance(nhan_vien2, NVBanHang):
                nhan_vien2.LuongHT = nhan_vien2.Luongcoban + nhan_vien2.Sosanpham * 18_000

    def XuatNV(self):
        """Xuất các nhân viên (mã nhân viên, họ tên, lương cơ bản, lương hằng tháng)"""
        for nhan_vien3 in self.DanhsachNV:
            print("Mã NV:", nhan_vien3.MaNV, end=", ")
            print("Họ tên:", nhan_vien3.Hoten, end=", ")
            print("Lương cơ bản:", "{:,.0f} VNĐ".format(nhan_vien3.Luongcoban).replace(",", "."), end=", ")
            print("Lương hằng tháng:", "{:,.0f} VNĐ".format(nhan_vien3.LuongHT).replace(",", "."))
            print()

            # hiển thị hàng dọc
            # print("Mã NV:", nhan_vien3.MaNV)
            # print("Họ tên:", nhan_vien3.Hoten)
            # print("Lương cơ bản:", "{:,.0f} VNĐ".format(nhan_vien3.Luongcoban).replace(",", "."))
            # print("Lương hằng tháng:", "{:,.0f} VNĐ".format(nhan_vien3.Luongcoban).replace(",", "."))
            # print()

    def TimNV_theoma(self, ma_nv):
        """Tìm nhân viên theo mã nhân viên"""
        for nhan_vien4 in self.DanhsachNV:
            if nhan_vien4.MaNV == ma_nv:
                print("Tìm thấy nhân viên có mã nhân viên là", ma_nv)
                print("Thông tin nhân viên:")
                print("Mã nhân viên:", nhan_vien4.MaNV)
                print("Họ và tên:", nhan_vien4.Hoten)
                print("Lương cơ bản:", "{:,.0f} VNĐ".format(nhan_vien4.Luongcoban).replace(",", "."))
                if isinstance(nhan_vien4, NVVanPhong):
                    print("Số ngày làm việc:", nhan_vien4.Songay)
                elif isinstance(nhan_vien4, NVBanHang):
                    print("Số sản phẩm:", nhan_vien4.Sosanpham)
                print("Lương hằng tháng:", "{:,.0f} VNĐ".format(nhan_vien4.LuongHT).replace(",", "."))
                return
        print("Không tìm thấy nhân viên có mã nhân viên là", ma_nv)

    def TimNV_LuongHT_caonhat(self):
        """Tìm nhân viên có lương hằng tháng cao nhất"""
        # -inf (âm vô cùng) của kiểu dữ liệu float. Giá trị -inf (âm vô cùng) đại diện cho giá trị không giới hạn nhỏ nhất trong kiểu dữ liệu float
        max_luong = float("-inf") #float(0)
        nhan_vien_max = []
        for nhan_vien5 in self.DanhsachNV:
            if nhan_vien5.LuongHT > max_luong:
                max_luong = nhan_vien5.LuongHT
                nhan_vien_max = [nhan_vien5]
            #thêm nhân viên khi có nguười có lương cao nhất giống lương của người cao nhất hiện tại
            elif nhan_vien5.LuongHT == max_luong:
                nhan_vien_max.append(nhan_vien5)

        print("\nNhân viên có lương hằng tháng cao nhất:")
        if nhan_vien_max:
            for nhan_vien5 in nhan_vien_max:
                print("Họ tên:", nhan_vien5.Hoten, end=" - ")
                print("Lương hằng tháng:", "{:,.0f} VNĐ".format(nhan_vien5.LuongHT).replace(",", "."))
        else:
            print("Không tìm thấy nhân viên.")

    def TimNVBH_LuongHT_thapnhat(self):
        """Tìm nhân viên bán hàng có lương hằng tháng thấp nhất"""
        min_luong = float("inf")
        nhan_vien_min = []
        for nhan_vien6 in self.DanhsachNV:
            if isinstance(nhan_vien6, NVBanHang) and nhan_vien6.LuongHT < min_luong:
                min_luong = nhan_vien6.LuongHT
                nhan_vien_min = [nhan_vien6]
            elif isinstance(nhan_vien6, NVBanHang) and nhan_vien6.LuongHT == min_luong:
                nhan_vien_min.append(nhan_vien6)

        print("\nNhân viên bán hàng có lương hằng tháng thấp nhất:")
        if nhan_vien_min:
            for nhan_vien6 in nhan_vien_min:
                print("Họ tên:", nhan_vien6.Hoten, end=" - ")
                print("Lương hằng tháng:", "{:,.0f} VNĐ".format(nhan_vien6.LuongHT).replace(",", "."))
        else:
            print("Không tìm thấy nhân viên bán hàng.")


# Test NVBH và NVVP
nhanvien1 = NVBanHang("NV001", "Nguyễn Văn Anh", 4_500_000)
nhanvien1.Xuatthongtin_NVBH()
nhanvien1.Tinhluong_NVBH()

nhanvien2 = NVVanPhong("NV002", "Nguyễn Văn Sang", 4_500_000)
nhanvien2.Xuatthongtin_NVVP()
nhanvien2.Tinhluong_NVVP()


# Tạo đối tượng công ty
cong_ty = CongTy("CT001", "Công ty XYZ")

# Khởi tạo tự động các nhân viên
cong_ty.KhoitaoNV("NVBanHang", "NV001", "Nguyễn Văn Anh", 4_500_000)
cong_ty.KhoitaoNV("NVBanHang", "NV002", "Trần Thị Thu", 6_000_000)
cong_ty.KhoitaoNV("NVBanHang", "NV003", "Lê Hoàng Tuấn", 4_500_000)
cong_ty.KhoitaoNV("NVBanHang", "NV004", "Nguyễn Tấn Cầm", 10_000_000)
cong_ty.KhoitaoNV("NVBanHang", "NV005", "Phạm Hoàng Sang", 6_500_000)
cong_ty.KhoitaoNV("NVVanPhong", "NV006", "Đinh Tiên Hoàng", 7_500_000)
cong_ty.KhoitaoNV("NVVanPhong", "NV007", "Trương Minh Quang", 10_000_000)
cong_ty.KhoitaoNV("NVVanPhong", "NV008", "Cao Đức Hiền", 8_000_000)
cong_ty.KhoitaoNV("NVVanPhong", "NV009", "Nguyễn Chu Toàn", 10_000_000)
cong_ty.KhoitaoNV("NVVanPhong", "NV010", "Đinh Thị Mẫn", 7_800_000)


# Tính lương hằng tháng
cong_ty.TinhLuong()

# Xuất thông tin các nhân viên
cong_ty.XuatNV()

# Tìm nhân viên theo mã nhân viên
cong_ty.TimNV_theoma("NV002")

# Tìm nhân viên có lương hằng tháng cao nhất
cong_ty.TimNV_LuongHT_caonhat()

# Tìm nhân viên bán hàng có lương hằng tháng thấp nhất
cong_ty.TimNVBH_LuongHT_thapnhat()
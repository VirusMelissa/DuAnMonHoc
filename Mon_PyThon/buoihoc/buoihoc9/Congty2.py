#!/usr/bin/python
#-*- coding: utf-8 -*-

class NVBanHang:
    """Class Nhân viên bán hàng"""
    def __init__(self, MaNV: int, **kwargs):
        self.MaNV = MaNV
        self.Hoten = kwargs.get('Hoten', '')
        self.Luongcoban = kwargs.get('Luongcoban', 0)
        self.Sosanpham = kwargs.get('Sosanpham', 0)
        self.LuongHT = kwargs.get('LuongHT', 0)

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

    # tạo chuỗi xuất thông tin
    def __str__(self):
        return str([self.MaNV, self.Hoten, self.Luongcoban, self.LuongHT])


class NVVanPhong:
    """Class Nhân viên văn phòng"""
    def __init__(self, MaNV: int, **kwargs):
        self.MaNV = MaNV
        self.Hoten = kwargs.get('Hoten', '')
        self.Luongcoban = kwargs.get('Luongcoban', 0)
        self.Songay = kwargs.get('Songay', 0)
        self.LuongHT = kwargs.get('LuongHT', 0)

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

    #tạo chuỗi xuất thông tin
    def __str__(self):
        return str(self.MaNV) + " " + self.Hoten

class CongTy:
    """Class Công Ty quản lý các nhân viên"""
    def __init__(self, Macongty: int, Tencongty: str):
        self.Macongty = Macongty
        self.Tencongty = Tencongty
        self.DanhsachNV = []

    def KhoitaoNV(self):
        """Khởi tạo tự động các nhân viên"""
        vp1 = NVVanPhong(MaNV=123, Hoten='Nguyễn Văn A', Songay=20, Luongcoban=3_000_000 )
        bh1 = NVBanHang(MaNV=124, Hoten='Nguyễn Văn B', Sosanpham=100, Luongcoban=3_000_000)
        self.DanhsachNV.extend([vp1, bh1])

    def print(self):
        for nv in self.DanhsachNV:
            print(nv)

    def TinhLuong(self):
        """Tính lương hằng tháng"""
        for nhan_vien2 in self.DanhsachNV:
            #Hàm isinstance kiểm tra xem một đối tượng có thuộc kiểu dữ liệu cụ thể hay không. Nó trả về True nếu đối tượng thuộc kiểu dữ liệu được xác định và False nếu không thuộc.
            #Dùng đối tượng nhan_vien để so sánh có giống đối tượng NVVanPhong. Nếu chuẩn thì dùng công thức
            if isinstance(nhan_vien2, NVVanPhong):
                nhan_vien2.LuongHT = nhan_vien2.Luongcoban + nhan_vien2.Songay * 150_000
            elif isinstance(nhan_vien2, NVBanHang):
                nhan_vien2.LuongHT = nhan_vien2.Luongcoban + nhan_vien2.Sosanpham * 18_000

    def TimNV_theoma(self, ma_nv: int):
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

    def in_NVBH(self):
        for nhan_vien in self.DanhsachNV:
            if isinstance(nhan_vien, NVBanHang):
                print(nhan_vien)

    # Cách 2
    # def in_NVBH(self):
    #     for nhan_vien in self.DanhsachNV:
    #         if type(nhan_vien) is NVBanHang:
    #             print(nhan_vien)

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

if __name__ == '__main__':
    # vp1 = NVVanPhong(MaNV=123, Hoten='Nguyễn Văn A', Songay=20, )
    # bh1 = NVBanHang(MaNV=124, Hoten='Nguyễn Văn B', Sosanpham=100, Luongcoban= 3_000_000)
    # vp1.Xuatthongtin_NVVP()
    # print(bh1)

    ct = CongTy(309, "ABC")
    ct.KhoitaoNV()
    # ct.print()
    #
    # ct.TimNV_theoma(123)

    ct.in_NVBH()


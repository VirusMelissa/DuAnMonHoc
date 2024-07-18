from django.shortcuts import render, get_object_or_404, redirect
from django.db.models import Max
from .models import LoaiNV as LoaiNV_model, NhanVien as NhanVien_model

def Danhsach_NV(request):
    DS_NhanVien = NhanVien_model.objects.all()
    DS_LoaiNV = LoaiNV_model.objects.all()
    return render(request, 'danhsachNV.html', {'dsNhanVien': DS_NhanVien, 'dsLoaiNV': DS_LoaiNV})


def Them_NV(request):
    if request.method == 'POST':
        MaNV = request.POST['MaNV']
        LoaiNV_id = request.POST['LoaiNV']
        Hoten = request.POST['Hoten']
        Luongcoban = request.POST['Luongcoban']

        LoaiNV = LoaiNV_model.objects.get(LoaiNV_id=LoaiNV_id)

        if LoaiNV_id == '1':  # Nhân viên văn phòng
            SoNgayLam = request.POST['SoNgayLam']
            SoSanPham = 0
        elif LoaiNV_id == '2':  # Nhân viên kinh doanh
            SoNgayLam = 0
            SoSanPham = request.POST['SoSanPhamBan']
        else:
            SoNgayLam = 0
            SoSanPham = 0

        nhanvien = NhanVien_model.objects.create(MaNV=MaNV,
                                                 LoaiNV_id=LoaiNV,
                                                 SoNgayLam=SoNgayLam,
                                                 SoSanPham=SoSanPham,
                                                 Hoten=Hoten,
                                                 Luongcoban=Luongcoban)
        nhanvien.save()
        return redirect('List_nhanvien')
    return render(request, 'danhsachNV.html')


def Tinh_Luong_Hang_Thang(request):
    DS_NhanVien = NhanVien_model.objects.all()

    for nhanvien in DS_NhanVien:
        if nhanvien.LoaiNV_id.LoaiNV_id == 1:  # Nhân viên văn phòng
            nhanvien.Luonghangthang = nhanvien.Luongcoban + nhanvien.SoNgayLam * 180_000

            # Thưởng cho nhân viên văn phòng
            if nhanvien.SoNgayLam > 26:
                nhanvien.Luonghangthang += 1_000_000

        elif nhanvien.LoaiNV_id.LoaiNV_id == 2:  # Nhân viên kinh doanh
            nhanvien.Luonghangthang = nhanvien.Luongcoban + nhanvien.SoSanPham * 120_000

            # Thưởng cho nhân viên kinh doanh
            if nhanvien.SoSanPham > 40:
                nhanvien.Luonghangthang += nhanvien.Luongcoban * 0.3

            if nhanvien.Luonghangthang < 5_000_000:
                nhanvien.Luonghangthang += nhanvien.Luonghangthang * 0.3

        if nhanvien.Luonghangthang > 8_000_000:
            nhanvien.Luonghangthang += nhanvien.Luonghangthang * 0.05

        nhanvien.save()

    return redirect('List_nhanvien')


def Sua_NV(request, pk):
    nhanvien = get_object_or_404(NhanVien_model, pk=pk)
    DS_LoaiNV = LoaiNV_model.objects.all()

    if request.method == 'POST':
        # Kiểm tra xem 'MaNV' có tồn tại trong request.POST hay không
        if 'MaNV' in request.POST:
            MaNV = request.POST['MaNV']
            Hoten = request.POST['Hoten']
            Luongcoban = request.POST['Luongcoban']
            LoaiNV_id = request.POST['LoaiNV']

            LoaiNV = LoaiNV_model.objects.get(LoaiNV_id=LoaiNV_id)

            if LoaiNV_id == '1':  # Nhân viên văn phòng
                SoNgayLam = request.POST['SoNgayLam']
                SoSanPham = 0
            elif LoaiNV_id == '2':  # Nhân viên kinh doanh
                SoNgayLam = 0
                SoSanPham = request.POST['SoSanPhamBan']
            else:
                SoNgayLam = 0
                SoSanPham = 0

            nhanvien.MaNV = MaNV
            nhanvien.LoaiNV_id = LoaiNV
            nhanvien.SoNgayLam = int(SoNgayLam)
            nhanvien.SoSanPham = int(SoSanPham)
            nhanvien.Hoten = Hoten
            nhanvien.Luongcoban = int(Luongcoban)

            # Tính lương hằng tháng tự động
            if LoaiNV_id == '1':  # Nhân viên văn phòng
                nhanvien.Luonghangthang = nhanvien.Luongcoban + nhanvien.SoNgayLam * 180_000

                # Thưởng cho nhân viên văn phòng
                if nhanvien.SoNgayLam > 26:
                    nhanvien.Luonghangthang += 1_000_000
            elif LoaiNV_id == '2':  # Nhân viên kinh doanh
                nhanvien.Luonghangthang = nhanvien.Luongcoban + nhanvien.SoSanPham * 120_000

                # Thưởng cho nhân viên kinh doanh
                if nhanvien.SoSanPham > 40:
                    nhanvien.Luonghangthang += nhanvien.Luongcoban * 0.3

                if nhanvien.Luonghangthang < 5_000_000:
                    nhanvien.Luonghangthang += nhanvien.Luonghangthang * 0.3

            if nhanvien.Luonghangthang > 8_000_000:
                nhanvien.Luonghangthang += nhanvien.Luonghangthang * 0.05

            nhanvien.save()

            return redirect('List_nhanvien')

    return render(request, 'suaNV.html', {'nhanvien': nhanvien, 'dsLoaiNV': DS_LoaiNV})


def Xoa_NV(request, pk):
    nhanvien = get_object_or_404(NhanVien_model, MaNV=pk)
    nhanvien.delete()
    return redirect('List_nhanvien')


def Tim_NV(request):
    DS_NhanVien = NhanVien_model.objects.all()
    if request.method == 'POST':
        ma_nv = request.POST.get('MaNV', '')
        dsNhanVien = NhanVien_model.objects.filter(MaNV=ma_nv)

        return render(request, 'timNV.html', {'dsNhanVien': dsNhanVien, 'searched_ma_nv': ma_nv})

    return render(request, 'timNV.html', {'dsNhanVien': DS_NhanVien})


def Tim_NV_Luongmax(request):
    # Lấy nhân viên có lương hằng tháng cao nhất
    luong_max = NhanVien_model.objects.aggregate(Max('Luonghangthang'))
    # Luonghangthang=luong_max['Luonghangthang__max']: Điều kiện lọc này được áp dụng để chọn tất cả các đối tượng trong đó giá trị của trường Luonghangthang bằng với giá trị lớn nhất đã được tính toán ở phía trước.
    nhanvien_luong_max = NhanVien_model.objects.filter(Luonghangthang=luong_max['Luonghangthang__max'])

    return render(request, 'timNV.html', {'dsNhanVien': nhanvien_luong_max})


def Tim_NV_kinhdoanh_Luongmax(request):
    # Lấy nhân viên kinh doanh có lương hằng tháng cao nhất
    luong_max_kinhdoanh = NhanVien_model.objects.filter(LoaiNV_id__Name='Nhân Viên Kinh Doanh').aggregate(Max('Luonghangthang'))
    nhanvien_luong_max_kinhdoanh = NhanVien_model.objects.filter(LoaiNV_id__Name='Nhân Viên Kinh Doanh', Luonghangthang=luong_max_kinhdoanh['Luonghangthang__max'])

    return render(request, 'timNV.html', {'dsNhanVien': nhanvien_luong_max_kinhdoanh})

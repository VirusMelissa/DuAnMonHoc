from django.db import models

class LoaiNV(models.Model):
    LoaiNV_id = models.AutoField(primary_key=True)
    Name = models.CharField(max_length=50, null=False)

    def __str__(self):
        return self.Name


class NhanVien(models.Model):
    MaNV = models.TextField(primary_key=True)
    LoaiNV_id = models.ForeignKey(LoaiNV, default=None, on_delete=models.CASCADE)
    SoNgayLam = models.IntegerField(null=False)
    SoSanPham = models.IntegerField(null=False)
    Hoten = models.TextField(max_length=50, null=False)
    Luongcoban = models.BigIntegerField(null=False)
    Luonghangthang = models.BigIntegerField(default=0, blank=True, null=True)

    def __str__(self):
        return (f"Mã nhân viên: {self.MaNV}"
                f", Họ tên: {self.Hoten}"
                f", Lương cơ bản: {'{:,.0f} VNĐ'.format(self.Luongcoban).replace(',', '.')}"
                f", Lương hằng tháng: {'{:,.0f} VNĐ'.format(self.Luonghangthang).replace(',', '.')}\n")



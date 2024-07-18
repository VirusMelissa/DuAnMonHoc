from django.contrib import admin
from .models import LoaiNV, NhanVien

# Register your models here.
class LoaiNVAdmin(admin.ModelAdmin):
    list_display = ('LoaiNV_id', 'Name')
    search_fields = ['Name']
    list_filter = ()
admin.site.register(LoaiNV,LoaiNVAdmin)

class NhanVienAdmin(admin.ModelAdmin):
    list_display = ('MaNV', 'LoaiNV_id', 'Hoten', 'SoNgayLam', 'SoSanPham', 'Luongcoban')
    search_fields = ['MaNV', 'Hoten']
    list_filter = ()
admin.site.register(NhanVien,NhanVienAdmin)

from django.urls import path

from .import views

urlpatterns = [
    path('danhsachNV/', views.Danhsach_NV, name='List_nhanvien'),
    path('Tinhluong', views.Tinh_Luong_Hang_Thang, name='Tinhluong'),
    path('Timnhanvien', views.Tim_NV, name='Timkiem_nhanvien'),
    path('LuongHT_max', views.Tim_NV_Luongmax, name='LuongHT_max'),
    path('LuongHT_kinhdoanh_max', views.Tim_NV_kinhdoanh_Luongmax, name='LuongHT_kinhdoanh_max'),
    path('addnhanvien', views.Them_NV, name='create'),
    path('edit/<str:pk>/', views.Sua_NV, name='update'),
    path('delete/<str:pk>/', views.Xoa_NV, name='delete'),
]
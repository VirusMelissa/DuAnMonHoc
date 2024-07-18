from django.urls import path
from . import views

urlpatterns = [
    path("", views.dashboard, name='dashboard'),
    path("login", views.login_user, name='login_user'),
    path("logout", views.logout_user, name='logout'),
    path("create-user", views.CreateUserView.as_view(), name='createuser'),
    path("update-user/<int:id>/", views.UpdateUserView.as_view(), name='updateuser'),
    path("list-user", views.ListUserView.as_view(), name='listuser'),
    path("delete-user", views.delete_user, name='delete_user'),
    path('upload', views.upload_image, name='upload_image'),
    path("create-category", views.CreateCategoryView.as_view(), name='createcategory'),
    path("update-category/<int:id>/", views.UpdateCategoryView.as_view(), name='updatecategory'),
    path("list-category", views.ListCategoryView.as_view(), name='listcategory'),
    path("delete-category", views.delete_category, name='delete_category'),
    path("create-product", views.CreateProductView.as_view(), name='createproduct'),
    path("list-product", views.ListProductView.as_view(), name='listproduct'),
    path("update-product/<int:id>/", views.UpdateProductView.as_view(), name='updateproduct'),
    path("order-cart", views.CreateOrderView.as_view(), name='ordercart'),
    path("list-order", views.ListOrderView.as_view(), name='listorder'),
    path("list-invoice", views.ListInvoiceView.as_view(), name='listinvoice'),
] 

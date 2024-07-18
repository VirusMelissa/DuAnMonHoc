from django.urls import path
from . import views

urlpatterns = [
    path("", views.home, name='home'),
    path('logout/', views.logout_user, name='logout'),
    path('register/', views.register_user, name='register'),
    path("collections/", views.danhsach, name='danhsach'),
    path("product/<int:id>/", views.product, name='product'),
    path("order", views.order, name='product'),
    path("addtocart", views.add_to_cart, name='addtocart'),
    path("clear_cart", views.clear_cart, name='clear_cart'),
    path("payment_success", views.payment_success, name='payment_success'),
]

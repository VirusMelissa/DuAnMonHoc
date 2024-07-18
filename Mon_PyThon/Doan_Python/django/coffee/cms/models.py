from django.contrib.auth.models import User
from django.db import models
from ckeditor.fields import RichTextField
from django.utils import timezone
from django.db.models import Sum, F, ExpressionWrapper, DecimalField
from django.db.models.functions import ExtractMonth, ExtractYear

class Account(models.Model):
    user = models.OneToOneField(User, on_delete=models.CASCADE)
    birthday = models.DateTimeField()
    gender = models.CharField(max_length=6, choices=[('MALE', 'MALE'), ('FEMALE', 'FEMALE')], default="FEMALE")
    role = models.CharField(max_length=8, choices=[('ADMIN', 'ADMIN'), ('EMPLOYEE', 'EMPLOYEE'),("USER", "USER")])
    avatar = models.ImageField(upload_to='avatars/', null=True, blank=True)

    def __str__(self) -> str:
        return self.user.username


class Category(models.Model):
    name =  models.CharField(max_length=255, default=None)
    image = models.ImageField(upload_to='categories/', null=True, blank=True)
    parent_category = models.IntegerField(null=True)

    def get_parent_category_name(self):
        parent_category = Category.objects.get(id=self.parent_category)
        return parent_category.name
    
    def get_child_categories(self):
        children = Category.objects.filter(parent_category=self)
        print(self.id, 'child')
        return children

    def __str__(self) -> str:
        return self.name + " "+ self.image
    
    
class Product(models.Model):
    name = models.CharField(max_length=100)
    content =  RichTextField()
    image = models.ImageField(upload_to='products/', null=True, blank=True)
    price = models.DecimalField(max_digits=10, decimal_places=2)
    discount_price = models.DecimalField(max_digits=10, decimal_places=2)
    note = models.TextField()
    category = models.ForeignKey(Category, on_delete=models.CASCADE)

    def __str__(self) -> str:
        return self.name + " "+ self.image
    
    def getCategoryName(self):
        category = Category.objects.get(id= self.category)
        return category.name


class Size(models.Model):
    size_name = models.CharField(max_length=100)

    def getProductSize(self, sizeId, productId):
        try:
            size_product = SanPhamSize.objects.get(size_id = sizeId, product_id = productId)
            return size_product
        except SanPhamSize.DoesNotExist:
            return

class SanPhamSize(models.Model):
    product = models.ForeignKey(Product, on_delete=models.CASCADE)
    size = models.ForeignKey(Size, on_delete=models.CASCADE)
    price = models.DecimalField(max_digits=10, decimal_places=2)

    # def getProductPrice(self):
    #     try:
    #         size_product = SanPhamSize.objects.get(id=self.id, size=self.size, product = self.product)
    #         return size_product.price
    #     except SanPhamSize.DoesNotExist:
    #         return ''


class Order(models.Model):
    username= models.CharField(max_length=100)
    phone = models.CharField(max_length=100)
    note= models.CharField(max_length=100)
    total_price = models.DecimalField(max_digits=10, decimal_places=2)
    paymentType = models.CharField(max_length=100, null=True)
    paymentStatus = models.CharField(max_length=100, null=True)
    created = models.DateTimeField(auto_now_add=True)
    updated = models.DateTimeField(auto_now=True)
    orderPartnerId = models.CharField(max_length=100,  null=True)

    def getProductOrder(self):
        try:
            product_order = ProductOrder.objects.filter(order = self)
            product_names = ', '.join([prOrder.name for prOrder in product_order])
            return product_names
        except ProductOrder.DoesNotExist:
            return 'x'

    def get_product_percentage_sold(year=None, month=None):
        # Bắt đầu với queryset chính của ProductOrder
        queryset = ProductOrder.objects

        # Lọc theo năm nếu được chỉ định
        if year is not None:
            queryset = queryset.filter(order__created__year=year)

        # Lọc theo tháng nếu được chỉ định
        if month is not None:
            queryset = queryset.filter(order__created__month=month)

        # Tính tổng số lượng bán của từng sản phẩm
        products_sold = queryset.values('product__name').annotate(
            total_quantity=Sum('quantity'),
             total_price=Sum(ExpressionWrapper(F('quantity') * F('product__price'), output_field=DecimalField()))
        )

        # Tính tổng số lượng bán của tất cả các sản phẩm
        total_quantity_all_products = queryset.aggregate(total=Sum('quantity'))['total'] or 1  # Tránh chia cho 0

        # Tính phần trăm bán của mỗi sản phẩm
        for product in products_sold:
            product['percentage_sold'] = (product['total_quantity'] / total_quantity_all_products) * 100

        sorted_products = sorted(products_sold, key=lambda x: x['percentage_sold'], reverse=True)

        return sorted_products

class ProductOrder(models.Model):
    order = models.ForeignKey(Order, on_delete=models.CASCADE)
    product = models.ForeignKey(Product, on_delete=models.CASCADE)
    quantity = models.CharField(max_length=100)
    size = models.CharField(max_length=100, null=True)
    name = models.CharField(max_length=100, null=True)
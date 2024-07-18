from django.contrib.auth import  login, logout, authenticate
from django.shortcuts import render, redirect
from django.contrib import messages
from django.contrib.auth.decorators import login_required
from django.views import View
from django.contrib.auth.models import User
from django.contrib.auth.mixins import LoginRequiredMixin
from datetime import datetime
from cms.models import Account, Category, Order, Product, ProductOrder, SanPhamSize, Size
from django.core.files.storage import FileSystemStorage
from django.core.exceptions import ValidationError
from django.http import JsonResponse
from django.core.paginator import Paginator, EmptyPage, PageNotAnInteger
from decimal import Decimal
from website.Cart import Cart
from django.db.models import Q
from django.db.models import Sum
from django.utils import timezone
from django.db.models import Count
import json
import urllib.request
import urllib
import uuid
import requests
import hmac
import hashlib


# Create your views here.
def login_user(request):
    if request.user.is_authenticated: 
        return redirect('dashboard')

    if request.method == 'POST':
        username = request.POST["username"]
        password = request.POST["password"]
        user = authenticate(request, username=username, password=password)
        if user is not None:
            login(request, user)
            return redirect('dashboard')
            
        else:
            # Return an 'invalid login' error message.
            return render(request, 'login.html')
    else:
            return render(request, 'login.html')

def logout_user(request):
    logout(request)
    messages.success(request, "You have been logged out")
    return redirect('home')

@login_required
def dashboard(request):
    product_names_count = ProductOrder.objects.values('name').annotate(name_count=Count('name')).count()
    
    today = timezone.now().date()

    start_of_year = today.replace(month=1, day=1)
    total_this_year = Order.objects.filter(created__date__gte=start_of_year).filter(paymentStatus="SUCCESS").aggregate(Sum('total_price'))['total_price__sum'] or 0
    return render(request, 'index.html', {'product_count': product_names_count, 'year': total_this_year})

def create_user(request):
    return render(request, 'create_user.html')

class CreateUserView(LoginRequiredMixin, View):
    template_name = 'create_user.html'

    def get(self, request):
        return render(request, 'create_user.html')  

    def post(self, request):
        username = request.POST.get('username', None)
        email = request.POST.get('email', None)
        password1 = request.POST.get('password1', None)
        password2 = request.POST.get('password2', None)
        lastname = request.POST.get('lastname', None)
        firstname = request.POST.get('firstname', None)
        role = request.POST.get('role', None)
        birthday = request.POST.get('birthday', None)

        if password1 != password2:
            messages.error(request, "Passwords do not match")
            return redirect('createuser')


        if role is None:
            role = "USER"
        
        if User.objects.filter(email=email).exists():
            messages.error(request, "Email already exists.")

        # Check if the username already exists
        if User.objects.filter(username=username).exists():
            messages.error(request, "Username already exists.")
        
        user = User.objects.create_user(
            username=username,
            email=email,
            password=password1,
            last_name=lastname,
            first_name=firstname,
        )

        if role == 'ADMIN':
            user.is_staff = True
            user.is_superuser = False
        elif role == 'EMPLOYEE':
            user.is_staff = True
            user.is_superuser = False
        else:
            user.is_staff = False
            user.is_superuser = False

        user.save()
        avatar = request.FILES.get('avatar', None)
        if avatar is not None: 
            fss = FileSystemStorage()
            file = fss.save(avatar.name, avatar)
            file_url = fss.url(file)

        parsed_date = datetime.strptime(birthday, '%Y-%m-%d')
        formatted_datetime = parsed_date.strftime('%Y-%m-%d %H:%M:%S')

        account_instance = Account.objects.create(
            user_id=user.pk,
            gender="MALE",
            birthday=formatted_datetime,
            role=role,
            avatar=file_url
        )
        account_instance.save()

        messages.success(request, 'User created successfully')
        return redirect('listuser')
    
class UpdateUserView(LoginRequiredMixin, View):
    template_name = 'user/update_user.html'

    def get(self, request, id):
        user = User.objects.get(id=id)
        return render(request, self.template_name, {'user': user})  

    def post(self, request, id):
        user = User.objects.get(id=id)
       
        user.username = request.POST.get('username')
        user.email = request.POST.get('email')
        password1 = request.POST.get('password1', None)
        password2 = request.POST.get('password2', None)
        user.last_name = request.POST.get('lastname')
        user.first_name = request.POST.get('firstname')
        role = request.POST.get('role')
        birthday = request.POST.get('birthday')
    
        if password1 != password2 and password1 != '' and password2 != '' :
            messages.error(request, "Passwords do not match")
            return redirect('createuser')


        if role is None:
            role = "USER"
        
        if User.objects.filter(email=request.POST.get('email')).exists():
            messages.error(request, "Email already exists.")

        # Check if the username already exists
        if User.objects.filter(username=request.POST.get('username')).exists():
            messages.error(request, "Username already exists.")

       
        # if password1 is not None and password2 is not None:
        #     user.password=password1,
        
        if role == 'ADMIN':
            user.is_staff = True
            user.is_superuser = False
        elif role == 'EMPLOYEE':
            user.is_staff = True
            user.is_superuser = False
        else:
            user.is_staff = False
            user.is_superuser = False

        user.save()
        avatar = request.FILES.get('avatar', None)
        if avatar is not None: 
            fss = FileSystemStorage()
            file = fss.save(avatar.name, avatar)
            file_url = fss.url(file)

        parsed_date = datetime.strptime(birthday, '%Y-%m-%d')
        formatted_datetime = parsed_date.strftime('%Y-%m-%d %H:%M:%S')

        account_instance = Account.objects.get(user_id=id)
        
        # account_instance.gender="MALE",

        birthday=formatted_datetime,
        account_instance.role=role
        if avatar is not None: 
            avatar=file_url
        
        account_instance.save()

        messages.success(request, 'User created successfully')
        return redirect('listuser')

class ListUserView(LoginRequiredMixin, View):
    template_name = 'user/list.html'

    def get(self, request):
        query = request.GET.get('q', '')
        list = User.objects.filter(username__icontains=query).filter(is_superuser=False)
        paginate_by = 10

        # Initialize the paginator with the retrieved users and the number of users per page
        paginator = Paginator(list, paginate_by)

        # Get the current page number from the request, or use 1 if the request doesn't contain a valid page number
        page = request.GET.get('page')

        try:
            users = paginator.page(page)
        except PageNotAnInteger:
            # If the request contains an invalid page number, use the first page
            users = paginator.page(1)
        except EmptyPage:
            # If the request contains a page number that doesn't exist, use the last page
            users = paginator.page(paginator.num_pages)

        # Render the template with the current page of users
        return render(request, self.template_name, {'list': users, 'query': query})  
  
def delete_user(request):
    if request.method == 'POST':
        user_id = request.POST.get('user_id')
        try:
            user = User.objects.get(id=user_id)
            user.delete()
            return JsonResponse({'status': 'success'})
        except User.DoesNotExist:
            return JsonResponse({'status': 'error'})

def upload_image(request):
    if request.method == 'POST':
        uploaded_file = request.FILES['image']
        fs = FileSystemStorage()
        filename = fs.save(uploaded_file.name, uploaded_file)
        uploaded_file_url = fs.url(filename)
        return render(request, 'upload_complete.html', {'uploaded_file_url': uploaded_file_url})
    return render(request, 'upload_image.html')

class CreateCategoryView(LoginRequiredMixin, View):
    template_name = 'category/create.html'

    def get(self, request):
        categories = Category.objects.filter(parent_category=None)
        return render(request, self.template_name, {'categories': categories})  

    def post(self, request):
        name = request.POST.get('name')
        parent_category = request.POST.get('parent_category')

        if Category.objects.filter(name=name).exists():
            messages.error(request, "Name already exists.")

        image = request.FILES['image']
        fss = FileSystemStorage()
        file = fss.save(image.name, image)
        file_url = fss.url(file)


        category = Category.objects.create(
            name=name,
            image=file_url,
            parent_category=parent_category
        )

        messages.success(request, 'Category created successfully')
        return redirect('listcategory')
    
class UpdateCategoryView(LoginRequiredMixin, View):
    template_name = 'category/update.html'

    def get(self, request,id):
        category = Category.objects.get(id=id)
        categories = Category.objects.all()
        return render(request, self.template_name, {'category': category, 'categories': categories})  

    def post(self, request, id):
        category = Category.objects.get(id=id)
        category.name = request.POST.get('name')
        category.parent_category = request.POST.get('parent_category')
        
        if Category.objects.filter(name=request.POST.get('name')).exists():
            messages.error(request, "Name already exists.")

        image = request.FILES.get('image', None)

        if image is not None: 
            fss = FileSystemStorage()
            file = fss.save(image.name, image)
            file_url = fss.url(file)
            category.image = file_url


        category.save()

        messages.success(request, 'Category updatded successfully')
        return redirect('listcategory')

class ListCategoryView(LoginRequiredMixin, View):
    template_name = 'category/list.html'

    def get(self, request):
        query = request.GET.get('q', '')
        list = Category.objects.filter(name__icontains=query)
        paginate_by = 10

        # Initialize the paginator with the retrieved users and the number of users per page
        paginator = Paginator(list, paginate_by)

        # Get the current page number from the request, or use 1 if the request doesn't contain a valid page number
        page = request.GET.get('page')

        try:
            categoreis = paginator.page(page)
        except PageNotAnInteger:
            # If the request contains an invalid page number, use the first page
            categoreis = paginator.page(1)
        except EmptyPage:
            # If the request contains a page number that doesn't exist, use the last page
            categoreis = paginator.page(paginator.num_pages)

        # Render the template with the current page of users
        return render(request, self.template_name, {'list': categoreis, 'query': query})  

def delete_category(request):
    if request.method == 'POST':
        cate_id = request.POST.get('cateId')
        try:
            cate = Category.objects.get(id=cate_id)
            cate.delete()
            return JsonResponse({'status': 'success'})
        except User.DoesNotExist:
            return JsonResponse({'status': 'error'})

class CreateProductView(LoginRequiredMixin, View):
    template_name = 'product/create.html'

    def get(self, request):
        list = Category.objects.filter(parent_category__isnull=False).order_by('name')
        size = Size.objects.all()
        return render(request, self.template_name, {'categories': list, 'sizes': size})  

    def post(self, request):
        name = request.POST.get('name')
        content = request.POST.get('content')
        price = request.POST.get('price')
        discount_price = request.POST.get('discount_price') or 0
        note = request.POST.get('note')
        category_id = request.POST.get('category_id')
        sizeL = request.POST.get('L')
        sizeM = request.POST.get('M')
        sizeS = request.POST.get('S')
        size = Size.objects.all()

        if Product.objects.filter(name=name).exists():
            messages.error(request, "Name already exists.")

        image = request.FILES['image']
        fss = FileSystemStorage()
        file = fss.save(image.name, image)
        file_url = fss.url(file)

        product = Product.objects.create(
            name=name,
            image=file_url,
            content = content,
            price = price,
            discount_price = discount_price,
            note = note,
            category_id = category_id,
        )
        # for s in size:
        #     if s.size_name == 'L':
        #         SanPhamSize.objects.create(
        #             price = sizeL,
        #             size = s,
        #             product = product
        #         )
        #     elif s.size_name == 'M':
        #         SanPhamSize.objects.create(
        #             price = sizeM,
        #             size = s,
        #             product = product
        #         )
        #     else: 
        #         SanPhamSize.objects.create(
        #             price = sizeS,
        #             size = s,
        #             product = product
        #         )

        messages.success(request, 'Product created successfully')
        return redirect('listproduct')

class UpdateProductView(LoginRequiredMixin, View):
    template_name = 'product/update.html'

    def get(self, request, id):
        list = Category.objects.filter(parent_category__isnull=False).order_by('name')
        
        product = Product.objects.get(id=id)

        sizes = Size.objects.all()

        # Assuming getProductSize is a method that takes an argument
        processed_sizes = [(size, size.getProductSize(size.id, id)) for size in sizes]

        
        return render(request, self.template_name, {'categories': list, 'sizes': processed_sizes, 'product': product})  

    def post(self, request, id):
        product = Product.objects.get(id=id)
        product.name = request.POST.get('name')
        product.content = request.POST.get('content')
        product.price = request.POST.get('price') or 0
        product.discount_price = request.POST.get('discount_price') or 0
        product.note = request.POST.get('note')
        product.category_id = request.POST.get('category_id')
        sizeL = request.POST.get('L')
        sizeM = request.POST.get('M')
        sizeS = request.POST.get('S')

        size = Size.objects.all()
    
        image = request.FILES.get('image', None)

        if image is not None:
            fss = FileSystemStorage()
            file = fss.save(image.name, image)
            file_url = fss.url(file)
            product.image = file_url

        product.save()

        # for s in size:
        #     if s.size_name == 'L':
        #         SanPhamSize.objects.filter(size_id=s.id, product_id = id).update(price=sizeL)
        #     elif s.size_name == 'M':
        #         SanPhamSize.objects.filter(size_id=s.id, product_id = id).update(price=sizeM)
        #     else: 
        #         SanPhamSize.objects.filter(size_id=s.id, product_id = id).update(price=sizeS)

        messages.success(request, 'Product updated successfully')
        return redirect('listproduct')
    

class ListProductView(LoginRequiredMixin, View):
    template_name = 'product/list.html'

    def get(self, request):
        query = request.GET.get('q', '')
        list = Product.objects.filter(name__icontains=query)
        paginate_by = 10

        # Initialize the paginator with the retrieved users and the number of users per page
        paginator = Paginator(list, paginate_by)

        # Get the current page number from the request, or use 1 if the request doesn't contain a valid page number
        page = request.GET.get('page')

        try:
            products = paginator.page(page)
        except PageNotAnInteger:
            # If the request contains an invalid page number, use the first page
            products = paginator.page(1)
        except EmptyPage:
            # If the request contains a page number that doesn't exist, use the last page
            products = paginator.page(paginator.num_pages)

        # Render the template with the current page of users
        return render(request, self.template_name, {'list': products, 'query': query})  

class CreateOrderView(View): 

    def post(self, request):
        
        name = request.POST.get('name')
        phone = request.POST.get('phone_number')
        total = request.POST.get('total')
        note = request.POST.get('note')
        paymentType = request.POST.get('paymentType')
              
        # parameters send to MoMo get get payUrl
        endpoint = "https://test-payment.momo.vn/v2/gateway/api/create"
        partnerCode = "MOMO"
        accessKey = "F8BBA842ECF85"
        secretKey = "K951B6PE1waDMi640xX08PD3vg6EkVlz"
        orderInfo = "pay with MoMo"
        redirectUrl = "http://localhost:8000/payment_success"
        ipnUrl = "https://webhook.site/b3088a6a-2d17-4f8d-a383-71389a6c600b"
        amount = total
        orderId = str(uuid.uuid4())
        requestId = str(uuid.uuid4())
        requestType = "payWithATM"
        extraData = ""  # pass empty value or Encode base64 JsonString

        # before sign HMAC SHA256 with format: accessKey=$accessKey&amount=$amount&extraData=$extraData&ipnUrl=$ipnUrl
        # &orderId=$orderId&orderInfo=$orderInfo&partnerCode=$partnerCode&redirectUrl=$redirectUrl&requestId=$requestId
        # &requestType=$requestType
        rawSignature = "accessKey=" + accessKey + "&amount=" + str(amount) + "&extraData=" + extraData + "&ipnUrl=" + ipnUrl + "&orderId=" + orderId + "&orderInfo=" + orderInfo + "&partnerCode=" + partnerCode + "&redirectUrl=" + redirectUrl + "&requestId=" + requestId + "&requestType=" + requestType

        # puts raw signature
        print("--------------------RAW SIGNATURE----------------")
        print(rawSignature)
        # signature
        h = hmac.new(bytes(secretKey, 'ascii'), bytes(rawSignature, 'ascii'), hashlib.sha256)
        signature = h.hexdigest()
        print("--------------------SIGNATURE----------------")
        print(signature)

        # json object send to MoMo endpoint

        data = {
            'partnerCode': partnerCode,
            'partnerName': "Test",
            'storeId': "MomoTestStore",
            'requestId': requestId,
            'amount': amount,
            'orderId': orderId,
            'orderInfo': orderInfo,
            'redirectUrl': redirectUrl,
            'ipnUrl': ipnUrl,
            'lang': "vi",
            'extraData': extraData,
            'requestType': requestType,
            'signature': signature
        }
        print("--------------------JSON REQUEST----------------\n")
        data = json.dumps(data)
        print(data)

        clen = len(data)
        response = requests.post(endpoint, data=data, headers={'Content-Type': 'application/json', 'Content-Length': str(clen)})

        # f.close()
        print("--------------------JSON response----------------\n")
        print(response.json())

        print(response.json()['payUrl'])

        cart = Cart(request)
        order = Order.objects.create(
            username=name,
            phone=phone,
            total_price = total,
            note = note,
            paymentType = paymentType,
            orderPartnerId = orderId,
            paymentStatus= 'CREATED'
        )

        for item in cart.cart.values():
            ProductOrder.objects.create(
                order=order,
                size=item['size'],
                product_id = item['product_id'],
                quantity = item['quantity'],
                name= item['name'],
            )
        cart.clear()

        return JsonResponse({'status': 'success', 'message': 'Order created successfully', 'link': response.json()['payUrl']})
        
class ListOrderView(LoginRequiredMixin, View):
    template_name = 'order/list.html'

    def get(self, request):
        query = request.GET.get('q', '')
        list = Order.objects.filter(
            Q(username__icontains=query) |
            Q(phone__icontains=query) |
            Q(note__icontains=query)
        )
        paginate_by = 10

        today = timezone.now().date()

        # Lấy ngày đầu tiên của tuần
        start_of_week = today - timezone.timedelta(days=today.weekday())

        # Lấy ngày đầu tiên của tháng
        start_of_month = today.replace(day=1)

        # Lấy ngày đầu tiên của năm
        start_of_year = today.replace(month=1, day=1)

        # Thống kê tiền theo ngày hôm nay
        total_today = Order.objects.filter(created__date=today).filter(paymentStatus="SUCCESS").aggregate(Sum('total_price'))['total_price__sum'] or 0
        
        # Thống kê tiền theo tuần này
        total_this_week = Order.objects.filter(created__date__gte=start_of_week).filter(paymentStatus="SUCCESS").aggregate(Sum('total_price'))['total_price__sum'] or 0

        # Thống kê tiền theo tháng này
        total_this_month = Order.objects.filter(created__date__gte=start_of_month).filter(paymentStatus="SUCCESS").aggregate(Sum('total_price'))['total_price__sum'] or 0

        # Thống kê tiền theo năm này
        total_this_year = Order.objects.filter(created__date__gte=start_of_year).filter(paymentStatus="SUCCESS").aggregate(Sum('total_price'))['total_price__sum'] or 0
        # Initialize the paginator with the retrieved users and the number of users per page
        paginator = Paginator(list, paginate_by)

        # Get the current page number from the request, or use 1 if the request doesn't contain a valid page number
        page = request.GET.get('page')

        try:
            orders = paginator.page(page)
        except PageNotAnInteger:
            # If the request contains an invalid page number, use the first page
            orders = paginator.page(1)
        except EmptyPage:
            # If the request contains a page number that doesn't exist, use the last page
            orders = paginator.page(paginator.num_pages)

        # Render the template with the current page of users
        return render(request, self.template_name, {'list': orders, 'query': query})  

class ListInvoiceView(LoginRequiredMixin, View):
    template_name = 'invoice/list.html'

    def get(self, request):
        

        today = timezone.now().date()

        # Lấy ngày đầu tiên của tuần
        start_of_week = today - timezone.timedelta(days=today.weekday())

        # Lấy ngày đầu tiên của tháng
        start_of_month = today.replace(day=1)

        # Lấy ngày đầu tiên của năm
        start_of_year = today.replace(month=1, day=1)

        # Thống kê tiền theo ngày hôm nay
        total_today = Order.objects.filter(created__date=today).filter(paymentStatus="SUCCESS").aggregate(Sum('total_price'))['total_price__sum'] or 0
        
        # Thống kê tiền theo tuần này
        total_this_week = Order.objects.filter(created__date__gte=start_of_week).filter(paymentStatus="SUCCESS").aggregate(Sum('total_price'))['total_price__sum'] or 0
        
        # Thống kê tiền theo tháng này
        total_this_month = Order.objects.filter(created__date__gte=start_of_month).filter(paymentStatus="SUCCESS").aggregate(Sum('total_price'))['total_price__sum'] or 0

        # Thống kê tiền theo năm này
        total_this_year = Order.objects.filter(created__date__gte=start_of_year).filter(paymentStatus="SUCCESS").aggregate(Sum('total_price'))['total_price__sum'] or 0
        
        current_datetime = datetime.now()

        current_month = current_datetime.month
        current_year = current_datetime.year
        result = Order.get_product_percentage_sold(year=current_year, month=current_month)
        print(result, 'result')
    
        return render(request, self.template_name, {'today': total_today, 'week': total_this_week, 'month': total_this_month, 'year': total_this_year, 'result': result})  

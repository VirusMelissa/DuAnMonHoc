from decimal import Decimal
from django.http import JsonResponse
from django.shortcuts import render, redirect
from django.contrib.auth import authenticate, login, logout
from django.contrib import messages
from cms.models import Category, Order, Product
from website.Cart import Cart
from random import sample
from website.forms import SignUpForm



def home(request):
    total_products_count = Product.objects.count()
    random_indices = sample(range(total_products_count), min(18, total_products_count))
    product = Product.objects.filter(pk__in=random_indices)
    return render(request, 'home.html', {'product': product})


def logout_user(request):
    logout(request)
    messages.success(request, "You have been logged out")
    return redirect('home')


def register_user(request):
    if request.method == 'POST':
        form = SignUpForm(request.POST)
        if form.is_valid():
            form.save()
            # Authenticate and login
            username = form.cleaned_data['username']
            password = form.cleaned_data['password1']
            user = authenticate(username=username, password=password)
            login(request, user)
            messages.success(request, "You have successfully register! Welcome")
            return redirect('home')
    else:
        form = SignUpForm()
        return render(request, 'register.html', {'form': form})
    return render(request, 'register.html', {'form': form})

def get_category_hierarchy():
    # Fetch all categories from the database
    categories = Category.objects.all()

    # Organize categories in a hierarchical structure
    category_hierarchy = {}

    for category in categories:
        category_id = category.id
        parent_id = category.parent_category
    
        if parent_id is None:
            category_hierarchy[category_id] = {'category': category, 'children': [], 'parent_id': ''}
        else:
            # If the parent_id doesn't exist in the hierarchy, create an empty entry
            if parent_id not in category_hierarchy:
                category_hierarchy[parent_id] = {'category': None, 'children': [], 'parent_id': ''}
            
            # Add the current category as a child of its parent
            category_hierarchy[parent_id]['children'].append({'category': category, 'children': [], 'parent_id': parent_id})

    return category_hierarchy.values()

def getAllProductbyCategory(id=None, isParent=None):
    if id is None and isParent is None: 
        all_products = Product.objects.all()
    elif id and isParent == 0:
        category_ids = Category.objects.filter(parent_category=id).values_list('id', flat=True)
        all_category = list(category_ids)
        all_products = Product.objects.filter(category_id__in=all_category)
    else:
        all_products = Product.objects.filter(category_id=id)
    # Organize products by category name
    grouped_data = {}
    for product in all_products:
        category_name = product.category.name
        if category_name is not None:
            # If the category is not in the dictionary, add it with an empty list
            if category_name not in grouped_data:
                grouped_data[category_name] = {'products': []}

            # Append the current product to the list of products for the category
            grouped_data[category_name]['products'].append(product)
    
    return grouped_data

def danhsach(request):
    categories = Category.objects.filter(parent_category__isnull=True)
    categories12 = get_category_hierarchy()
    parent = 0
    category = request.GET.get('category', '')
    if category == 'all':
        products = getAllProductbyCategory()
    else:
        check_parent = Category.objects.get(id=category) or 0
        parent = check_parent.parent_category or 0
        products = getAllProductbyCategory(category, parent)
    
    return render(request, 'collections.html', {'categories': categories, 'products': products, 'category': category, 'check_parent': str(parent) or 0, 'categories12': categories12})

def product(request,id):
    product = Product.objects.get(id=id)
    return render(request, 'product.html', { 'product': product })

def add_to_cart(request):
    if request.method == 'POST':
        id = request.POST.get('id')
        try:
            cart = Cart(request)
            product = Product.objects.get(id=id)
            cart.add(
                variant=product,
                quantity=1,
                size="Vừa"
            )
            print(cart.cart, 'cart')
            return JsonResponse({'status': 'success'})
        except Product.DoesNotExist:
            return JsonResponse({'status': 'error'})
        
def clear_cart(request):
    if request.method == 'POST':
        try:
            cart = Cart(request)
            cart.clear()
            print(cart.cart, 'cart')
            return JsonResponse({'status': 'success'})
        except Product.DoesNotExist:
            return JsonResponse({'status': 'error'})
        
def order(request):
    cart = Cart(request)
    # cart.add(
    #     variant=product,
    #     quantity=1,
    # )
    # print(cart.cart, 'cart')
    total = Decimal(0)
    for item in cart.cart.values():
        total += Decimal(item['quantity']) * Decimal(item['price'])

    return render(request, 'order.html', {'cart': cart.cart, 'total': total})

def header_view(request):
    # Assuming you have a function or method to retrieve the user's cart
    cart = Cart(request)  # Replace with your logic

    # Pass the cart information to the template
    return render(request, 'header_template.html', {'user_cart': cart.cart})

def payment_success(request):
    # Assuming you have a function or method to retrieve the user's cart
    cart = Cart(request)  # Replace with your logic
    cart.clear()

    orderId = request.GET.get('orderId', '')

    Order.objects.filter(orderPartnerId=orderId).update(paymentStatus="SUCCESS")
    print(orderId, 'query')
    # Pass the cart information to the template
    return render(request, 'payment_success.html', {'user_cart': cart.cart})
from cms.models import Product
from coffee.settings import CART_SESSION_ID


class Cart:
    def __init__(self, request):
        self.session = request.session
        cart = self.session.get(CART_SESSION_ID)
        if not cart:
            cart = self.session[CART_SESSION_ID] = {}
        self.cart = cart
            
    def add(self, variant, quantity, size):
        variant_id = str(variant.id)
        if variant_id not in self.cart:
            self.cart[variant_id] = {'quantity': 0, 'price': str(variant.price), 'size': size, 'name': variant.name, 'product_id': variant.id}
        self.cart[variant_id]['quantity'] += quantity
        self.save()

    def clear(self):
        self.session[CART_SESSION_ID] = {}
        self.session.modified = True


    def save(self):
        self.session.modified = True
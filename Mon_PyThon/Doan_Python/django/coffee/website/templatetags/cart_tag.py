from django import template
from website import Cart


register = template.Library()

@register.simple_tag
def cart_total_items(request):
    # Assuming you have a function or method to retrieve the user's cart total items
    cart = Cart(request) # Replace with your logic
    return len(cart.cart)
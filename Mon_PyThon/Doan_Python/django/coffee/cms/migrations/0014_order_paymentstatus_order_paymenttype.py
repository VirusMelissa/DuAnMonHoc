# Generated by Django 5.0 on 2024-01-09 03:52

from django.db import migrations, models


class Migration(migrations.Migration):
    dependencies = [
        ("cms", "0013_order_created_order_updated"),
    ]

    operations = [
        migrations.AddField(
            model_name="order",
            name="paymentStatus",
            field=models.CharField(max_length=100, null=True),
        ),
        migrations.AddField(
            model_name="order",
            name="paymentType",
            field=models.CharField(max_length=100, null=True),
        ),
    ]

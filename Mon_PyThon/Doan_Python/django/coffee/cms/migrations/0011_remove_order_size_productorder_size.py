# Generated by Django 5.0 on 2023-12-31 17:22

from django.db import migrations, models


class Migration(migrations.Migration):
    dependencies = [
        ("cms", "0010_order_productorder"),
    ]

    operations = [
        migrations.RemoveField(
            model_name="order",
            name="size",
        ),
        migrations.AddField(
            model_name="productorder",
            name="size",
            field=models.CharField(max_length=100, null=True),
        ),
    ]
# Generated by Django 5.0 on 2023-12-30 06:26

import django.db.models.deletion
from django.db import migrations, models


class Migration(migrations.Migration):
    dependencies = [
        ("cms", "0008_size_alter_product_content_sanphamsize"),
    ]

    operations = [
        migrations.AlterField(
            model_name="product",
            name="category",
            field=models.ForeignKey(
                on_delete=django.db.models.deletion.CASCADE, to="cms.category"
            ),
        ),
        migrations.AlterField(
            model_name="sanphamsize",
            name="product",
            field=models.ForeignKey(
                on_delete=django.db.models.deletion.CASCADE, to="cms.product"
            ),
        ),
        migrations.AlterField(
            model_name="sanphamsize",
            name="size",
            field=models.ForeignKey(
                on_delete=django.db.models.deletion.CASCADE, to="cms.size"
            ),
        ),
    ]

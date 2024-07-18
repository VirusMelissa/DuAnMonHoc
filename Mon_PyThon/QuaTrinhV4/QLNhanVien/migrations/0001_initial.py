# Generated by Django 5.0 on 2024-01-01 07:31

import django.db.models.deletion
from django.db import migrations, models


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='LoaiNV',
            fields=[
                ('LoaiNV_id', models.AutoField(primary_key=True, serialize=False)),
                ('Name', models.CharField(max_length=50)),
            ],
        ),
        migrations.CreateModel(
            name='NhanVien',
            fields=[
                ('MaNV', models.TextField(primary_key=True, serialize=False)),
                ('SoNgayLam', models.IntegerField()),
                ('SoSanPham', models.IntegerField()),
                ('Hoten', models.TextField(max_length=50)),
                ('Luongcoban', models.BigIntegerField()),
                ('Luonghangthang', models.BigIntegerField(blank=True, default=0, null=True)),
                ('LoaiNV_id', models.ForeignKey(default=None, on_delete=django.db.models.deletion.CASCADE, to='QLNhanVien.loainv')),
            ],
        ),
    ]

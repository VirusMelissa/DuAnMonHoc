# Generated by Django 5.0 on 2023-12-28 14:09

from django.db import migrations, models


class Migration(migrations.Migration):
    dependencies = [
        ("cms", "0002_account_gender_alter_account_role"),
    ]

    operations = [
        migrations.AddField(
            model_name="account",
            name="avatar",
            field=models.ImageField(blank=True, null=True, upload_to="avatars/"),
        ),
    ]

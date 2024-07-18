/*DÙNG DATA QLBH_1004_TEST*/
--1. Cho biết masp, tensp được sản xuất tại vn hoặc trung quốc
select masp, tensp
from SANPHAM
where NUOCSX in ('Viet Nam','Trung Quoc')
--2. Cho biết thông tin khách hàng có doanh số lớn nhất
select *
from KHACHHANG
where DOANHSO = (SELECT MAX(DOANHSO) FROM KHACHHANG)
--3. Cho biết thông tin khách hàng có 5 hóa đơn trở lên
select *
from KHACHHANG
where MAKH IN ( SELECT MAKH FROM HOADON GROUP BY MAKH HAVING COUNT(SOHD) >= 5)
--4. Cho biết thông tin nhân viên có nhiều hóa đơn nhất
select *
from NHANVIEN
where MANV IN (SELECT MANV FROM HOADON GROUP BY MANV HAVING COUNT(SOHD) >= ALL(SELECT COUNT(SOHD) FROM HOADON GROUP BY MANV))
--5. Cho biết thông tin khách hàng sở hữu hóa đơn có trị giá lớn nhất
select *
from KHACHHANG
where MAKH IN(select MAKH FROM HOADON GROUP BY MAKH HAVING MAX(TRIGIA) >= ALL(SELECT MAX(TRIGIA) FROM HOADON GROUP BY MAKH))
--6. Cho biết thông tin nhân viên thực hiện trên 5 hóa đơn
select *
from NHANVIEN
where MANV IN(SELECT MANV FROM HOADON GROUP BY MANV HAVING COUNT(MANV) > 5)


--a. viết thủ tục thêm 1 mẫu tin vào bảng cthd có kiểm tra ràng buộc sohd,masp
CREATE PROCEDURE P_THEM
@sohd nchar(10),
@masp nchar(10),
@sl int
as
begin
	if(@sohd not in (select SOHD FROM HOADON) OR @masp not in (select MASP FROM SANPHAM))
	begin
		print 'khong them duoc'
	end

	else
	begin
		insert into CTHD
		values(@sohd,@masp,@sl)
		print 'them thanh cong'
	end
end

exec P_THEM '1001','BB01',10

--b. viết hàm tính tổng giá trị của tất cả các hóa đơn của 1 khách hàng bất kì, tham số đầu vào là MAKH
CREATE FUNCTION F_TINH(@MAKH NCHAR(10))
RETURNS FLOAT
AS
BEGIN
	RETURN(select SUM(TRIGIA) from HOADON WHERE MAKH = @MAKH GROUP BY MAKH)
END

select dbo.F_TINH('KH01')
--c. tạo view CTBH: SOHD, MASP, TENSP, DVT, SL, GIA, THANHTIEN
CREATE TRIGGER V_THEM
ON ABC INSTEAD OF INSERT
AS
BEGIN
	IF(EXISTS(SELECT SOHD FROM inserted)
	BEGIN TRAN THEM
	BEGIN
		IF(EXISTS(SELECT SOHD FROM INSERTED WHERE SOHD NOT IN (SELECT SOHD FROM HOADON)))
		BEGIN
			ROLLBACK TRAN THEM
		END
		IF(EXISTS(SELECT MASP FROM INSERTED WHERE MASP NOT IN (SELECT MASP FROM SANPHAM)))
		BEGIN
			ROLLBACK TRAN THEM
		END
	END

	IF @@ERROR > 0
	BEGIN
		ROLLBACK TRAN THEM
	END
	ELSE
	BEGIN
		INSERT INTO CTHD
		SELECT SOHD,MASP,SL FROM inserted
		COMMIT TRAN THEM
		PRINT 'DA THEM VAO CTHD'
	END
END


/*DÙNG DATA NHANVIEN*/
--DUAN(MADA,TENDA,DIADIEM)
--PHANCONG(MANV,MADA,TGTHAMGIA)
--NHANVIEN(MANV,HOTEN,NGAYSINH,DIACHI,DIENTHOAI,MAPHONG,LUONG)
--PHONG(MAPHONG,TENPHONG,SLNV,TONGLUONG)

--1. CHO BIẾT CÁC NHÂN VIÊN CÓ LƯƠNG TỪ 6TR ĐẾN 9TR
select *
from NHANVIEN
where LUONG BETWEEN 6000000 AND 9000000
--2. CHO BIẾT THÔNG TIN NHÂN VIÊN THAM GIA NHIỀU DỰ ÁN NHẤT
select *
from NHANVIEN
where MANV IN(SELECT MANV FROM THAMGIA GROUP BY MANV HAVING COUNT(MADA) >= ALL(SELECT COUNT(MADA) FROM THAMGIA GROUP BY MANV))
--3. CHO BIẾT THÔNG TIN DỰ ÁN CÓ NHIỀU NHÂN VIÊN THAM GIA NHẤT
SELECT *
FROM DUAN
WHERE MADA IN(SELECT MADA FROM THAMGIA GROUP BY MADA HAVING COUNT(MANV) >= ALL(SELECT COUNT(MANV) FROM THAMGIA GROUP BY MADA))
--4. CHO BIẾT THÔNG TIN NHÂN VIÊN CHƯA THAM GIA DỰ ÁN NÀO
select *
from NHANVIEN
WHERE MANV NOT IN(SELECT MANV FROM THAMGIA)
--5. CHO BIẾT MANV, HOTEN, MAPHONG CỦA NHÂN VIÊN CÓ SỐ NGÀY THAM GIA DỰ ÁN LỚN NHẤT
select MANV,HOTEN,MAPHG
FROM NHANVIEN
WHERE MANV IN(SELECT MANV FROM THAMGIA GROUP BY MANV HAVING SUM(TGTHAMGIA) >= ALL(SELECT SUM(TGTHAMGIA) FROM THAMGIA GROUP BY MANV))
--6. CHO BIẾT TỔNG SỐ DỰ ÁN THAM GIA CỦA MỖI PHÒNG
select MAPHG,COUNT(MADA) AS SODUAN
FROM NHANVIEN,THAMGIA
WHERE NHANVIEN.MANV = THAMGIA.MANV
GROUP BY MAPHG

--a. viết thủ tục thêm 1 mẫu tin vào bảng THAMGIA ( KIỂM TRA MANV VÀ MADA TRONG BẢNG NHANVIEN VÀ BẢNG DUAN)
CREATE PROCEDURE P_THEM
@manv nchar(10),
@mada nchar(10),
@tgthamgia int
as
begin
	if(@manv not in (select MANV FROM NHANVIEN) OR @mada NOT IN (SELECT MADA FROM DUAN))
	begin
		print 'Khong them duoc'
	end
	
	else
	begin
		insert into THAMGIA
		values(@manv,@mada,@tgthamgia)
		print 'Them thanh cong'
	end
end

--b. viết hàm cho biết số lượng dự án mà 1 nhân viên bất kỳ tham gia, manv là tham số
CREATE FUNCTION F_TINH(@MANV NCHAR(10))
RETURNS INT
AS
BEGIN
	RETURN(SELECT count(MADA) from THAMGIA WHERE MANV = @MANV GROUP BY MANV)
END

SELECT dbo.F_TINH('02')
--c. viết trigger thêm xóa 1 nhân viên trong bảng NHANVIEN thì số slnv và tongluong trong bảng PHONGBAN sẽ được cập nhật
CREATE TRIGGER TR_THEMXOA
ON NHANVIEN
FOR INSERT,DELETE
AS
BEGIN
	IF((SELECT MANV FROM inserted) IS NOT NULL)
	BEGIN
		UPDATE PHONGBAN
		SET
			SOLUONGNV = SOLUONGNV + 1,
			TONGLUONG = TONGLUONG + (SELECT LUONG FROM inserted)
		WHERE MAPHG = (SELECT MAPHG FROM inserted)
	END

	IF((SELECT MANV FROM deleted) IS NOT NULL)
	BEGIN
		UPDATE PHONGBAN
		SET
			SOLUONGNV = SOLUONGNV - 1,
			TONGLUONG = TONGLUONG - (SELECT LUONG FROM deleted)
		WHERE MAPHG = (SELECT MAPHG FROM deleted)
	END
END
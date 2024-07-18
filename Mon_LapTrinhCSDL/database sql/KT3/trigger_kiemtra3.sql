CREATE TRIGGER TG_THEMGIANGVIEN2
ON GIANGVIEN
--nhan manh thao tac gi
FOR INSERT
AS
	-- Nếu xuất hiện mẫu tin trong bảng inserted
	IF((SELECT MAKHOA FROM inserted) IS NOT NULL)
	BEGIN
		UPDATE KHOA
		SET
			-- inserted là bảng giả nhưng có cột như bảng PHANCONG
			SLGV = SLGV + 1,
			TONGLUONG = TONGLUONG + ((SELECT LUONGCB FROM inserted)*(SELECT HESO FROM inserted))
		WHERE MAKHOA = (SELECT MAKHOA FROM inserted)

		PRINT 'DA CAP NHAT KHOA SAU KHI THEM GIANGVIEN!!!'
	END


-------------------------------------------------------------------------
INSERT INTO GIANGVIEN(MAGV,MAKHOA,HOTEN,NGAYSINH,LUONGCB,HESO,DUONGDANANH,ANH)
SELECT 'GV01','K01','NGUYEN 1','01/01/1990',3000000,2,'D:\Phuc\LT CSDL NC\image\Luu\Web\web dong\h1.jpg', bulkcolumn 
from openrowset (bulk 'D:\Phuc\LT CSDL NC\image\Luu\Web\web dong\h1.jpg', single_blob) as picture   
INSERT INTO PHANCONG
VALUES('GV01','MH02','L01',30)   
INSERT INTO PHANCONG
VALUES('GV02','MH02','L01',30)


 

 -------------------------------------------------------------------------
CREATE TRIGGER TG_XOAGIANGVIEN2
ON GIANGVIEN
--nhan manh thao tac gi
FOR DELETE
AS
	BEGIN
		UPDATE KHOA
			SET
				SLGV = SLGV - 1,
			TONGLUONG = TONGLUONG - ((SELECT LUONGCB FROM deleted)*(SELECT HESO FROM deleted))
			WHERE MAKHOA = (SELECT MAKHOA FROM deleted)

			PRINT 'DA CAP NHAT KHOA SAU KHI XOA GIANGVIEN!!!'
	END


 -------------------------------------------------------------------------
DELETE FROM GIANGVIEN
WHERE MAGV = 'GV01' AND MAKHOA = 'K01'



 -------------------------------------------------------------------------
CREATE TRIGGER TR_CAPNHATGIANGVIEN2
ON GIANGVIEN
--nhan manh thao tac gi
FOR UPDATE
AS
	BEGIN
		UPDATE KHOA
		SET
			TONGLUONG = TONGLUONG - ((SELECT LUONGCB FROM deleted)*(SELECT HESO FROM deleted)) + ((SELECT LUONGCB FROM inserted)*(SELECT HESO FROM inserted))
		WHERE MAKHOA = (SELECT MAKHOA FROM deleted)

		PRINT 'DA CAP NHAT KHOA SAU KHI CAP NHAT GIANGVIEN!!!'
	END




CREATE TRIGGER TG_THEMPHANCONG2
ON PHANCONG
--nhan manh thao tac gi
FOR INSERT
AS
BEGIN
	    -- Nếu xuất hiện mẫu tin trong bảng inserted
		IF (EXISTS (SELECT MAMH FROM inserted))
		BEGIN TRAN THEM
			IF(EXISTS(SELECT MAMH FROM inserted WHERE SOTIETDADAY > (SELECT SOTIET FROM MONHOC WHERE MAMH = (SELECT MAMH FROM inserted))))
			BEGIN
				ROLLBACK TRAN THEM

				PRINT 'KHONG THEM DUOC PHAN CONG VI SOTIETDADAY KHONG DUNG!!!'
			END	
END


SELECT * FROM PHANCONG
-------------------------------------------------------------------------
INSERT INTO PHANCONG
VALUES('GV01','MH01',90) 
delete from PHANCONG
where MAGV = 'GV01' AND MAMH = 'MH01'
INSERT INTO PHANCONG
VALUES('GV02','MH02','L01',30)


 -------------------------------------------------------------------------
CREATE TRIGGER TR_CAPNHATPHANCONG2
ON PHANCONG
--nhan manh thao tac gi
FOR UPDATE
AS
BEGIN
	    -- Nếu xuất hiện mẫu tin trong bảng inserted
		IF (EXISTS (SELECT MAMH FROM inserted))
		BEGIN TRAN THEM
			IF(EXISTS(SELECT MAMH FROM inserted WHERE SOTIETDADAY > (SELECT SOTIET FROM MONHOC WHERE MAMH = (SELECT MAMH FROM inserted))))
			BEGIN
				ROLLBACK TRAN THEM

				PRINT 'KHONG THEM DUOC PHAN CONG VI SOTIETDADAY KHONG DUNG!!!'

			END	
END

update PHANCONG
SET SOTIETDADAY = 110
WHERE MAGV = 'GV01' AND MAMH = 'MH01'


CREATE VIEW ABC
AS
SELECT GIANGVIEN.MAGV, HOTEN, MONHOC.MAMH, TENMH, SOTIET,SOTIETDADAY
FROM GIANGVIEN, MONHOC, PHANCONG
WHERE GIANGVIEN.MAGV = PHANCONG.MAGV
AND MONHOC.MAMH = PHANCONG.MAMH

 -------------------------------------------------------------------------
SELECT * FROM ABC





CREATE TRIGGER TR_THEMTRONGVIEWS
ON ABC INSTEAD OF INSERT
AS
BEGIN
	IF EXISTS (SELECT MAGV FROM inserted)
	BEGIN TRAN THEM
	BEGIN
		--ton tai mau tin nao do trong bang inserted nhưng khong co MAGV nam trong bang GIANGVIEN
		IF(EXISTS(SELECT MAGV FROM inserted WHERE MAGV NOT IN(SELECT MAGV FROM GIANGVIEN)))
		BEGIN
			--quay lai
			ROLLBACK TRAN THEM
		END
		--ton tai mau tin nao do trong bang inserted nhưng khong co MAMH nam trong bang MONHOC
		IF(EXISTS(SELECT MAMH FROM inserted WHERE MAMH NOT IN(SELECT MAMH FROM MONHOC)))
		BEGIN
			--quay lai
			ROLLBACK TRAN THEM
		END
	END

	--nếu bị 1 lỗi thì sẽ ko thêm được
	IF @@ERROR=1
	BEGIN
		ROLLBACK TRAN THEM
	END
	--ngược lại thì sẽ thêm được
	ELSE
	BEGIN
		INSERT INTO PHANCONG
		SELECT MAGV,MAMH,SOTIETDADAY FROM inserted
		COMMIT TRAN THEM
		PRINT 'DA THEM VAO BANG PHANCONG'
	END
END

 -------------------------------------------------------------------------
INSERT INTO ABC(MAGV,MAMH,SOTIETDADAY)
VALUES('GV01','MH01',100)


 -------------------------------------------------------------------------
CREATE TRIGGER TR_XOATRONGVIEWS
ON ABC INSTEAD OF DELETE
AS
BEGIN	
	IF EXISTS(SELECT MAMH FROM deleted)
	BEGIN
		DELETE FROM PHANCONG
		WHERE MAGV = (SELECT MAGV FROM deleted)
		AND MAMH = (SELECT MAMH FROM deleted)
		PRINT 'DA XOA VAO BANG PHANCONG'
	END
END



delete from ABC
where MAGV = 'GV01' AND MAMH = 'MH02'
 -------------------------------------------------------------------------
CREATE TRIGGER TR_SUATRONGVIEWS
ON ABC INSTEAD OF UPDATE
AS
BEGIN
	IF EXISTS(SELECT MAMH FROM inserted)
	BEGIN
		UPDATE PHANCONG
		SET SOTIETDADAY = (SELECT SOTIETDADAY FROM inserted)
		WHERE MAGV = (SELECT MAGV FROM inserted)
		AND MAMH = (SELECT MAMH FROM inserted)

		PRINT 'DA SUA VAO BANG PHANCONG'
	END
END


 -------------------------------------------------------------------------
UPDATE ABC
SET
	SOGIODAY = 100
WHERE MAGV = 'GV01'
AND MAMH = 'MH01'
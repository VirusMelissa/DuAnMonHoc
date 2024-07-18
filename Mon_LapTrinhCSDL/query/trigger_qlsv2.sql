CREATE TRIGGER TG_THEMSINHVIEN2
ON SINHVIEN
--nhan manh thao tac gi
FOR INSERT
AS
	-- Nếu xuất hiện mẫu tin trong bảng inserted
	IF((SELECT MALOP FROM inserted) IS NOT NULL)
	BEGIN
		UPDATE LOP
		SET
			-- inserted là bảng giả nhưng có cột như bảng PHANCONG
			TONGSO = TONGSO + 1,
			TONGHB = TONGHB + (SELECT HOCBONG FROM inserted)
		WHERE MALOP = (SELECT MALOP FROM inserted)

		PRINT 'DA CAP NHAT KHOA SAU KHI THEM SINHVIEN!!!'
	END


-------------------------------------------------------------------------
INSERT INTO SINHVIEN(MASV,MALOP,HOTEN,HOTEN,NGAYSINH,HOCBONG,DUONGDANANH,ANH)
SELECT 'SV01','L01','NGUYEN 1','01/01/1990',300000,'D:\Phuc\LT CSDL NC\image\Luu\Web\web dong\h1.jpg', bulkcolumn 
from openrowset (bulk 'D:\Phuc\LT CSDL NC\image\Luu\Web\web dong\h1.jpg', single_blob) as picture   


 -------------------------------------------------------------------------
CREATE TRIGGER TG_XOASINHVIEN2
ON SINHVIEN
--nhan manh thao tac gi
FOR DELETE
AS
	BEGIN
		UPDATE LOP
			SET
				TONGSO = TONGSO - 1,
			TONGHB = TONGHB - (SELECT HOCBONG FROM deleted)
			WHERE MALOP = (SELECT MALOP FROM deleted)

			PRINT 'DA CAP NHAT KHOA SAU KHI XOA SINHVIEN!!!'
	END


 -------------------------------------------------------------------------
DELETE FROM SINHVIEN
WHERE MASV = 'SV01' AND MALOP = 'L01'



 -------------------------------------------------------------------------
CREATE TRIGGER TR_CAPNHATSINHVIEN2
ON SINHVIEN
--nhan manh thao tac gi
FOR UPDATE
AS
	BEGIN
		UPDATE LOP
		SET
			TONGHB = TONGHB - (SELECT HOCBONG FROM deleted) + (SELECT HOCBONG FROM inserted)
		WHERE MALOP = (SELECT MALOP FROM deleted)

		PRINT 'DA CAP NHAT KHOA SAU KHI CAP NHAT SINHVIEN!!!'
	END



CREATE VIEW ABC
AS
SELECT SINHVIEN.MASV, HOTEN,MALOP,MONHOC.MAMH, TENMH, SOTC,DIEM
FROM SINHVIEN, MONHOC, KETQUA
WHERE SINHVIEN.MASV = KETQUA.MASV
AND MONHOC.MAMH = KETQUA.MAMH

 -------------------------------------------------------------------------
SELECT * FROM ABC





CREATE TRIGGER TR_THEMTRONGVIEWS
ON ABC INSTEAD OF INSERT
AS
BEGIN
	IF EXISTS (SELECT MASV FROM inserted)
	BEGIN TRAN THEM
	BEGIN
		--ton tai mau tin nao do trong bang inserted nhưng khong co MAGV nam trong bang GIANGVIEN
		IF(EXISTS(SELECT MASV FROM inserted WHERE MASV NOT IN(SELECT MASV FROM SINHVIEN)))
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
		--ton tai mau tin nao do trong bang inserted nhưng khong co MAMH nam trong bang MONHOC
		IF(EXISTS(SELECT MALOP FROM inserted WHERE MALOP NOT IN(SELECT MALOP FROM LOP)))
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
		INSERT INTO KETQUA
		SELECT MASV,MAMH,DIEM FROM inserted
		COMMIT TRAN THEM
		PRINT 'DA THEM VAO BANG KETQUA'
	END
END

 -------------------------------------------------------------------------
INSERT INTO ABC(MAGV,MAMH,MALOP,DIEM)
VALUES('GV01','MH01','L01',10)


 -------------------------------------------------------------------------
CREATE TRIGGER TR_XOATRONGVIEWS
ON ABC INSTEAD OF DELETE
AS
BEGIN	
	IF EXISTS(SELECT MAMH FROM deleted)
	BEGIN
		DELETE FROM KETQUA
		WHERE MASV = (SELECT MASV FROM deleted)
		AND MAMH = (SELECT MAMH FROM deleted)
		PRINT 'DA XOA VAO BANG KETQUA'
	END
END



delete from ABC
where MAGV = 'SV01' AND MAMH = 'MH01'
 -------------------------------------------------------------------------
CREATE TRIGGER TR_SUATRONGVIEWS
ON ABC INSTEAD OF UPDATE
AS
BEGIN
	IF EXISTS(SELECT MAMH FROM inserted)
	BEGIN
		UPDATE KETQUA
		SET DIEM = (SELECT DIEM FROM inserted)
		WHERE MASV = (SELECT MASV FROM inserted)
		AND MAMH = (SELECT MAMH FROM inserted)

		PRINT 'DA SUA VAO BANG KETQUA'
	END
END


 -------------------------------------------------------------------------
UPDATE ABC
SET
	DIEM = 9
WHERE MASV = 'SV01'
AND MAMH = 'MH01'
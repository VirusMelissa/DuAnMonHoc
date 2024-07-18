CREATE VIEW ABC
AS
SELECT HOADON.SOHD,MAKH,SANPHAM.MASP,GIA,SL,GIA*SL AS THANHTIEN
FROM HOADON,CTHD,SANPHAM
WHERE HOADON.SOHD = CTHD.SOHD
AND SANPHAM.MASP = CTHD.MASP

 -------------------------------------------------------------------------
SELECT * FROM ABC


CREATE TRIGGER TG_THEMTRONGVIEWS
ON ABC INSTEAD OF INSERT
AS
BEGIN
	IF EXISTS (SELECT SOHD FROM inserted)
	BEGIN TRAN THEM
	BEGIN
		--ton tai mau tin nao do trong bang inserted nhưng khong co SOHD nam trong bang HOADON
		IF(EXISTS(SELECT SOHD FROM inserted WHERE SOHD NOT IN(SELECT SOHD FROM HOADON)))
		BEGIN
			--quay lai
			ROLLBACK TRAN THEM
		END
		--ton tai mau tin nao do trong bang inserted nhưng khong co MAKH nam trong bang KHACHHANG
		IF(EXISTS(SELECT MAKH FROM inserted WHERE MAKH NOT IN(SELECT MAKH FROM KHACHHANG)))
		BEGIN
			--quay lai
			ROLLBACK TRAN THEM
		END
		--ton tai mau tin nao do trong bang inserted nhưng khong co MASP nam trong bang SANPHAM
		IF(EXISTS(SELECT MASP FROM inserted WHERE MASP NOT IN(SELECT MASP FROM SANPHAM)))
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
		INSERT INTO CTHD
		SELECT SOHD,MASP,SL FROM inserted
		COMMIT TRAN THEM
		PRINT 'DA THEM VAO BANG CTHD'
	END
END

 -------------------------------------------------------------------------
INSERT INTO ABC(MAGV,MAMH,SOTIETDADAY)
VALUES('GV01','MH01',100)


 -------------------------------------------------------------------------
CREATE TRIGGER TG_XOATRONGVIEWS
ON ABC INSTEAD OF DELETE
AS
BEGIN	
	IF EXISTS(SELECT MASP FROM deleted)
	BEGIN
		DELETE FROM CTHD
		WHERE SOHD = (SELECT SOHD FROM deleted)
		AND MASP = (SELECT MASP FROM deleted)
		PRINT 'DA XOA VAO BANG CTHD'
	END
END



delete from ABC
where MAGV = 'GV01' AND MAMH = 'MH02'
 -------------------------------------------------------------------------
CREATE TRIGGER TG_SUATRONGVIEWS
ON ABC INSTEAD OF UPDATE
AS
BEGIN
	IF EXISTS(SELECT MASP FROM inserted)
	BEGIN
		UPDATE CTHD
		SET SL = (SELECT SL FROM inserted)
		WHERE SOHD = (SELECT SOHD FROM inserted)
		AND MASP = (SELECT MASP FROM inserted)

		PRINT 'DA SUA VAO BANG CTHD'
	END
END


 -------------------------------------------------------------------------
UPDATE ABC
SET
	SOGIODAY = 100
WHERE MAGV = 'GV01'
AND MAMH = 'MH01'



CREATE VIEW KH_HD
AS
SELECT KHACHHANG.MAKH,HOTEN,DCHI,SODT,SOHD,NGHD,MANV,TRIGIA
FROM KHACHHANG,HOADON
WHERE KHACHHANG.MAKH=HOADON.MAKH

SELECT *FROM KH_HD
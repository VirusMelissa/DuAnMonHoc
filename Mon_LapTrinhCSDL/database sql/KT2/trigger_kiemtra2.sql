CREATE TRIGGER TR_THEMPHANCONG
ON PHANCONG
--nhan manh thao tac gi
FOR INSERT
AS
	-- Nếu xuất hiện mẫu tin trong bảng inserted
	IF((SELECT MAGV FROM inserted) IS NOT NULL)
	BEGIN
		UPDATE GIANGVIEN
		SET
			-- inserted là bảng giả nhưng có cột như bảng PHANCONG
			TSGIO = TSGIO + (SELECT SOGIODAY FROM inserted)
		WHERE MAGV = (SELECT MAGV FROM inserted)

		PRINT 'DA CAP NHAT GIANGVIEN SAU KHI THEM!!!'
	END


-------------------------------------------------------------------------
INSERT INTO PHANCONG
VALUES('GV01','MH01','L01',30)   
INSERT INTO PHANCONG
VALUES('GV01','MH02','L01',30)   
INSERT INTO PHANCONG
VALUES('GV02','MH02','L01',30)


 

 -------------------------------------------------------------------------
CREATE TRIGGER TR_XOAPHANCONG
ON PHANCONG
--nhan manh thao tac gi
FOR DELETE
AS
	BEGIN
		UPDATE GIANGVIEN
			SET
				-- deleted là bảng giả nhưng có cột như bảng PHANCONG
				TSGIO = TSGIO - (SELECT SOGIODAY FROM deleted)
			WHERE MAGV = (SELECT MAGV FROM deleted)

			PRINT 'DA CAP NHAT GIANGVIEN SAU KHI XOA!!!'
	END


 -------------------------------------------------------------------------
DELETE FROM PHANCONG
WHERE MAGV = 'GV01' AND MAMH = 'MH01' AND MALOP = 'L01'



 -------------------------------------------------------------------------
CREATE TRIGGER TR_CAPNHATPHANCONG
ON PHANCONG
--nhan manh thao tac gi
FOR UPDATE
AS
	BEGIN
		UPDATE GIANGVIEN
		SET
			-- deleted là bảng giả nhưng có cột như bảng PHANCONG
			--xóa tổng số giờ cũ sau đó thêm tổng số giờ mới
			TSGIO = TSGIO - (SELECT SOGIODAY FROM deleted) + (SELECT SOGIODAY FROM inserted)
		WHERE MAGV = (SELECT MAGV FROM inserted)

		PRINT 'DA CAP NHAT GIANGVIEN SAU KHI CAP NHAT!!!'
	END


 -------------------------------------------------------------------------
CREATE VIEW ABC
AS
SELECT GIANGVIEN.MAGV, HOTEN, MONHOC.MAMH, TENMH, LOP.MALOP, TENLOP, SOGIODAY
FROM GIANGVIEN, MONHOC, LOP,PHANCONG
WHERE GIANGVIEN.MAGV = PHANCONG.MAGV
AND MONHOC.MAMH = PHANCONG.MAMH
AND LOP.MALOP = PHANCONG.MALOP

 -------------------------------------------------------------------------
SELECT * FROM ABC


 -------------------------------------------------------------------------
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
		--ton tai mau tin nao do trong bang inserted nhưng khong co MALOP nam trong bang LOP
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
		INSERT INTO PHANCONG
		SELECT MAGV,MAMH,MALOP,SOGIODAY FROM inserted
		COMMIT TRAN THEM
		PRINT 'DA THEM VAO BANG PHANCONG'
	END
END

 -------------------------------------------------------------------------
INSERT INTO ABC(MAGV,MAMH,MALOP,SOGIODAY)
VALUES('GV01','MH01','L01',30)


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
		AND MALOP = (SELECT MALOP FROM deleted)
		PRINT 'DA XOA VAO BANG PHANCONG'
	END
END


 -------------------------------------------------------------------------
CREATE TRIGGER TR_SUATRONGVIEWS
ON ABC INSTEAD OF UPDATE
AS
BEGIN
	IF EXISTS(SELECT MAMH FROM inserted)
	BEGIN
		UPDATE PHANCONG
		SET SOGIODAY = (SELECT SOGIODAY FROM inserted)
		WHERE MAGV = (SELECT MAGV FROM inserted)
		AND MAMH = (SELECT MAMH FROM inserted)
		AND MALOP = (SELECT MALOP FROM inserted)

		PRINT 'DA SUA VAO BANG PHANCONG'
	END
END


 -------------------------------------------------------------------------
UPDATE ABC
SET
	SOGIODAY = 10
WHERE MAGV = 'GV01'
AND MAMH = 'MH01'
AND MALOP = 'L01'
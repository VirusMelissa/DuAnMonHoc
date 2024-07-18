CREATE TRIGGER TR_THEMNV
ON NHANVIEN
--nhan manh thao tac gi
FOR INSERT
AS
	-- Nếu xuất hiện mẫu tin trong bảng inserted
	IF((SELECT MAPHG FROM inserted) IS NOT NULL)
	BEGIN
		UPDATE PHONG
		SET
			SL = SL + 1,
			-- inserted là bảng giả nhưng có cột như bảng CTHD
			TONGLUONG = TONGLUONG + ((SELECT LUONGCB FROM inserted)+(SELECT PHUCAP FROM inserted))
		WHERE MAPHG = (SELECT MAPHG FROM inserted)

		PRINT 'DA CAP NHAT SAU KHI THEM!!!'
	END


-------------------------------------------------------------------------
INSERT INTO NHANVIEN
VALUES('NV01','NGUYEN 1',300000,0,'P01')
INSERT INTO NHANVIEN
VALUES('NV02','NGUYEN 2',200000,0,'P01')
INSERT INTO NHANVIEN
VALUES('NV03','NGUYEN 3',100000,0,'P02')


 

 -------------------------------------------------------------------------
CREATE TRIGGER TR_XOANV
ON NHANVIEN
--nhan manh thao tac gi
FOR DELETE
AS
	BEGIN
		UPDATE PHONG
			SET
				SL = SL - 1,
				-- inserted là bảng giả nhưng có cột như bảng CTHD
				TONGLUONG = TONGLUONG - ((SELECT LUONGCB FROM deleted)+(SELECT PHUCAP FROM deleted))
			WHERE MAPHG = (SELECT MAPHG FROM deleted)

			PRINT 'DA CAP NHAT SAU KHI XOA!!!'
	END


 -------------------------------------------------------------------------
DELETE FROM NHANVIEN
WHERE MANV = 'NV01'
DELETE FROM NHANVIEN
WHERE MANV = 'NV02'
DELETE FROM NHANVIEN
WHERE MANV = 'NV03'



 -------------------------------------------------------------------------
CREATE TRIGGER TR_CAPNHATNV
ON NHANVIEN
--nhan manh thao tac gi
FOR UPDATE
AS
	BEGIN
		UPDATE PHONG
		SET
			-- deleted là bảng giả nhưng có cột như bảng NHANVIEN
			--xóa học bổng cũ sau đó thêm học bổng mới
			TONGLUONG = TONGLUONG - ((SELECT LUONGCB FROM deleted)+(SELECT PHUCAP FROM deleted)) + ((SELECT LUONGCB FROM inserted)+(SELECT PHUCAP FROM inserted))
		WHERE MAPHG = (SELECT MAPHG FROM inserted)

		PRINT 'DA CAP NHAT SAU KHI CAP NHAT NHANVIEN!!!'
	END


 -------------------------------------------------------------------------
UPDATE NHANVIEN
SET LUONGCB = 150000,
	PHUCAP  = 20
WHERE MANV = 'NV01'


-------------------------------------------------------------------------
CREATE TRIGGER TR_THEMTHAMGIA
ON THAMGIA
--nhan manh thao tac gi
FOR INSERT
AS
	BEGIN
		UPDATE NHANVIEN
		SET
			-- inserted là bảng giả nhưng có cột như bảng CTHD
			PHUCAP = PHUCAP + ((SELECT TGIAN FROM inserted)*((SELECT LUONGCB FROM NHANVIEN WHERE MANV = (SELECT MANV FROM inserted))*0.01))
		WHERE MANV = (SELECT MANV FROM inserted)

		PRINT 'DA CAP NHAT SAU KHI THEM!!!'
	END


INSERT INTO THAMGIA
VALUES('NV01','DA01',10)
INSERT INTO NHANVIEN
VALUES('NV02','NGUYEN 2',200000,10,'P01')
INSERT INTO NHANVIEN
VALUES('NV03','NGUYEN 3',100000,10,'P02')



-------------------------------------------------------------------------
CREATE VIEW V_NHANVIEN
AS
SELECT NHANVIEN.MANV,DUAN.MADA,HOTEN,LUONGCB,TGIAN,0.01*LUONGCB*TGIAN AS PHUCAP
FROM NHANVIEN,DUAN,THAMGIA
WHERE NHANVIEN.MANV=THAMGIA.MANV 
AND DUAN.MADA=THAMGIA.MADA



-------------------------------------------------------------------------
SELECT * FROM V_NHANVIEN




-------------------------------------------------------------------------
CREATE TRIGGER TR_THEMTRONGVIEWS
ON V_NHANVIEN INSTEAD OF INSERT
AS
BEGIN
	IF EXISTS (SELECT MANV FROM inserted)
	BEGIN TRAN THEM
	BEGIN
		--ton tai mau tin nao do trong bang inserted nhưng khong co MANV nam trong bang HOADON
		IF(EXISTS(SELECT MANV FROM inserted WHERE MANV NOT IN(SELECT MANV FROM NHANVIEN)))
		BEGIN
			--quay lai
			ROLLBACK TRAN THEM
		END
		--ton tai mau tin nao do trong bang inserted nhưng khong co MADA nam trong bang SANPHA,
		IF(EXISTS(SELECT MADA FROM inserted WHERE MADA NOT IN(SELECT MADA FROM DUAN)))
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
		INSERT INTO THAMGIA
		SELECT MANV,MADA,TGIAN FROM inserted
		COMMIT TRAN THEM
		PRINT 'DA THEM VAO BANG THAMGIA'
	END
END



-------------------------------------------------------------------------
INSERT INTO THAMGIA(MANV,MADA,TGIAN)
VALUES('NV01','DA01',10)
INSERT INTO THAMGIA(MANV,MADA,TGIAN)
VALUES('NV01','DA02',5)
INSERT INTO THAMGIA(MANV,MADA,TGIAN)
VALUES('NV02','DA01',10)






-------------------------------------------------------------------------
CREATE TRIGGER TR_XOATRONGVIEWS
ON V_NHANVIEN INSTEAD OF DELETE
AS
BEGIN
	IF EXISTS (SELECT MANV FROM deleted)
	BEGIN TRAN XOA
	BEGIN
		--ton tai mau tin nao do trong bang inserted nhưng khong co MANV nam trong bang HOADON
		IF(EXISTS(SELECT MANV FROM deleted WHERE MANV NOT IN(SELECT MANV FROM NHANVIEN)))
		BEGIN
			--quay lai
			ROLLBACK TRAN XOA
		END
		--ton tai mau tin nao do trong bang inserted nhưng khong co MADA nam trong bang SANPHAM
		IF(EXISTS(SELECT MADA FROM deleted WHERE MADA NOT IN(SELECT MADA FROM DUAN)))
		BEGIN
			--quay lai
			ROLLBACK TRAN XOA
		END
	END

	--nếu bị 1 lỗi thì sẽ ko thêm được
	IF @@ERROR=1
	BEGIN
		ROLLBACK TRAN XOA
	END
	--ngược lại thì sẽ thêm được
	ELSE
	BEGIN
		DELETE FROM THAMGIA
		WHERE MANV = (SELECT MANV FROM deleted)
		AND MADA = (SELECT MADA FROM deleted)
		COMMIT TRAN XOA
		PRINT 'DA XOA VAO BANG THAMGIA'
	END
END



-------------------------------------------------------------------------
DELETE FROM V_NHANVIEN
WHERE MANV = 'NV01' AND MADA = 'DA01'
DELETE FROM V_NHANVIEN
WHERE MANV = 'NV01' AND MADA = 'DA02'
DELETE FROM V_NHANVIEN
WHERE MANV = 'NV02' AND MADA = 'DA01'




-------------------------------------------------------------------------
CREATE TRIGGER TR_SUATRONGVIEWS
ON V_NHANVIEN INSTEAD OF UPDATE
AS
BEGIN
	--nếu bị 1 lỗi thì sẽ ko thêm được
	IF @@ERROR=1
	BEGIN
		ROLLBACK TRAN XOA
	END
	--ngược lại thì sẽ thêm được
	ELSE
	BEGIN
		UPDATE NHANVIEN
		SET
			-- deleted là bảng giả nhưng có cột như bảng NHANVIEN
			--xóa học bổng cũ sau đó thêm học bổng mới
			PHUCAP = PHUCAP - ((SELECT TGIAN FROM deleted)*((SELECT LUONGCB FROM NHANVIEN WHERE MANV = (SELECT MANV FROM deleted))*0.01)) +
			((SELECT TGIAN FROM inserted)*((SELECT LUONGCB FROM NHANVIEN WHERE MANV = (SELECT MANV FROM inserted))*0.01))
		WHERE MANV = (SELECT MANV FROM inserted)

		PRINT 'DA CAP NHAT NHANVIEN SAU KHI CAP NHAT VIEW!!!'


		UPDATE THAMGIA
		SET
			TGIAN = (SELECT TGIAN FROM inserted)
		WHERE MANV = (SELECT MANV FROM inserted)
		AND MADA = (SELECT MADA FROM inserted)

		PRINT 'DA CAP NHAT THAMGIA SAU KHI CAP NHAT VIEW!!!'
	END
END



-------------------------------------------------------------------------
UPDATE V_NHANVIEN
SET TGIAN = 10
WHERE MANV = 'NV01' AND MADA='DA02'
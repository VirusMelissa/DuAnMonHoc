CREATE TRIGGER TR_THEMCTHD
ON CTHD
--nhan manh thao tac gi
FOR INSERT
AS
	-- Nếu xuất hiện mẫu tin trong bảng inserted
	IF((SELECT SOHD FROM inserted) IS NOT NULL)
	BEGIN
		UPDATE HOADON
		SET
			-- inserted là bảng giả nhưng có cột như bảng CTHD
			TONGTHANHTIEN = TONGTHANHTIEN + (SELECT SL FROM inserted)*(SELECT GIA FROM SANPHAM WHERE MASP = (SELECT MASP FROM inserted))
		WHERE SOHD = (SELECT SOHD FROM inserted)

		PRINT 'DA CAP NHAT SAU KHI THEM!!!'
	END


-------------------------------------------------------------------------
INSERT INTO CTHD
VALUES('HD01','SP01',10)   
INSERT INTO CTHD
VALUES('HD01','SP02',10)     


 

 -------------------------------------------------------------------------
CREATE TRIGGER TR_XOACTHD
ON CTHD
--nhan manh thao tac gi
FOR DELETE
AS
	BEGIN
		UPDATE HOADON
			SET
				-- inserted là bảng giả nhưng có cột như bảng CTHD
				TONGTHANHTIEN = TONGTHANHTIEN - (SELECT SL FROM deleted)*(SELECT GIA FROM SANPHAM WHERE MASP = (SELECT MASP FROM deleted))
			WHERE SOHD = (SELECT SOHD FROM deleted)

			PRINT 'DA CAP NHAT SAU KHI XOA!!!'
	END


 -------------------------------------------------------------------------
DELETE FROM CTHD
WHERE SOHD = 'HD01' AND MASP = 'SP01'



 -------------------------------------------------------------------------
CREATE TRIGGER TR_CAPNHATCTHD
ON CTHD
--nhan manh thao tac gi
FOR UPDATE
AS
	BEGIN
		--xóa những dòng có mã hs trong bảng deleted của bảng KETQUA
		UPDATE HOADON
		SET
			-- deleted là bảng giả nhưng có cột như bảng HOCSINH
			--xóa học bổng cũ sau đó thêm học bổng mới
			TONGTHANHTIEN = TONGTHANHTIEN - ((SELECT SL FROM deleted)*(SELECT GIA FROM SANPHAM WHERE MASP = (SELECT MASP FROM deleted))) + 
			((SELECT SL FROM inserted)*(SELECT GIA FROM SANPHAM WHERE MASP = (SELECT MASP FROM inserted)))
		WHERE SOHD = (SELECT SOHD FROM inserted)

		PRINT 'DA CAP NHAT SAU KHI CAP NHAT!!!'
	END



 -------------------------------------------------------------------------
	UPDATE CTHD
	SET SL = 5
	WHERE SOHD = 'HD01' AND MASP='SP02'



 -------------------------------------------------------------------------
CREATE VIEW V_TTHOADON
AS
	SELECT HOADON.SOHD, SANPHAM.MASP, TENSP, GIA, SL, GIA*SL AS THANHTIEN
	FROM SANPHAM,HOADON,CTHD
	WHERE SANPHAM.MASP = CTHD.MASP
	AND HOADON.SOHD = CTHD.SOHD

 -------------------------------------------------------------------------
SELECT * FROM V_TTHOADON



 -------------------------------------------------------------------------
CREATE TRIGGER TR_THEMTRONGVIEWS
ON V_TTHOADON INSTEAD OF INSERT
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
		--ton tai mau tin nao do trong bang inserted nhưng khong co MASP nam trong bang SANPHA,
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
--trường hợp mã sản phẩm có nhưng số hóa đơn ko có sẽ ko chạy được
INSERT INTO V_TTHOADON(SOHD,MASP,SL)
VALUES('HD04','SP01',4)
--trường hợp cả 2 đều có chạy được
INSERT INTO V_TTHOADON(SOHD,MASP,SL)
VALUES('HD01','SP01',4)

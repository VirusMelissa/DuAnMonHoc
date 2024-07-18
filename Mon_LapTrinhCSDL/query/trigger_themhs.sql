--thêm đi số lượng và tienhocbong khi học sinh được thêm trong bảng LOP 
CREATE TRIGGER TR_THEMHS
ON HOCSINH
--nhan manh thao tac gi
FOR INSERT
AS
	-- Nếu xuất hiện mẫu tin trong bảng inserted
	IF((SELECT MALOP FROM inserted) IS NOT NULL)
	BEGIN
		UPDATE LOP
		SET
			TONGSO = TONGSO + 1,
			-- inserted là bảng giả nhưng có cột như bảng nhân viên
			TIENHOCBONG = TIENHOCBONG + (SELECT HOCBONG FROM inserted)
		WHERE MALOP = (SELECT MALOP FROM inserted)

		PRINT 'DA CAP NHAT SAU KHI THEM!!!'
	END


---------------------------------------------------------------------------
--THÊM THỬ HỌC SINH
INSERT INTO HOCSINH
VALUES('HS01','NGUYEN VAN A',500000,'L01')
INSERT INTO HOCSINH
VALUES('HS02','NGUYEN VAN B',500000,'L01')
INSERT INTO HOCSINH
VALUES('HS03','NGUYEN VAN C',300000,'L01')
INSERT INTO HOCSINH
VALUES('HS04','NGUYEN VAN D',400000,'L02')
INSERT INTO HOCSINH
VALUES('HS05','NGUYEN VAN E',300000,'L02')



---------------------------------------------------------------------------
--xóa đi số lượng và tienhocbong khi học sinh được xóa trong bảng LOP 
CREATE TRIGGER TR_XOAHS
ON HOCSINH
--nhan manh thao tac gi
FOR DELETE
AS
	-- Nếu xuất hiện mẫu tin trong bảng inserted
	IF((SELECT MALOP FROM deleted) IS NOT NULL)
	BEGIN
		UPDATE LOP
		SET
			TONGSO = TONGSO - 1,
			-- inserted là bảng giả nhưng có cột như bảng nhân viên
			TIENHOCBONG = TIENHOCBONG - (SELECT HOCBONG FROM deleted)
		WHERE MALOP = (SELECT MALOP FROM deleted)

		PRINT 'DA CAP NHAT SAU KHI XOA!!!'
	END


---------------------------------------------------------------------------
--xóa những gì liên quan đến học sinh cần xóa trong bảng LOP và KETQUA
CREATE TRIGGER TR_XOAHS
ON HOCSINH
--nhan manh thao tac gi
FOR DELETE
AS
	-- Nếu xuất hiện mẫu tin trong bảng deleted
	IF((SELECT MAHS FROM deleted) IS NOT NULL)
	BEGIN
		--xóa những dòng có mã hs trong bảng deleted của bảng KETQUA
		DELETE FROM KETQUA
		WHERE MAHS = (SELECT MAHS FROM deleted)

		--cập nhật lại bảng LOP
		UPDATE LOP
		SET
			TONGSO = TONGSO - 1,
			-- deleted là bảng giả nhưng có cột như bảng HOCSINH
			TIENHOCBONG = TIENHOCBONG - (SELECT HOCBONG FROM deleted)
		WHERE MALOP = (SELECT MALOP FROM deleted)

		PRINT 'DA CAP NHAT SAU KHI XOA!!!'
	END



---------------------------------------------------------------------------
--sửa học bổng nhưng số lượng vẫn giữ nguyên
CREATE TRIGGER TR_CAPNHATHS
ON HOCSINH
--nhan manh thao tac gi
FOR UPDATE
AS
	-- Nếu xuất hiện mẫu tin trong bảng deleted
	IF(UPDATE(HOCBONG))
	BEGIN
		--xóa những dòng có mã hs trong bảng deleted của bảng KETQUA
		UPDATE LOP
		SET
			-- deleted là bảng giả nhưng có cột như bảng HOCSINH
			--xóa học bổng cũ sau đó thêm học bổng mới
			TIENHOCBONG = TIENHOCBONG - (SELECT HOCBONG FROM deleted) + (SELECT HOCBONG FROM inserted)
		WHERE MALOP = (SELECT MALOP FROM inserted)

		PRINT 'DA CAP NHAT SAU KHI CAP NHAT!!!'
	END


---------------------------------------------------------------------------
--view
CREATE VIEW V_HOCSINH
AS
	SELECT HOCSINH.MAHS, HOTEN, HOCBONG, LOP.MALOP, TENLOP, MONHOC.MAMH, TENMH, SOTC, LANTHI, DIEM
	FROM HOCSINH, LOP, MONHOC, KETQUA
	WHERE HOCSINH.MALOP = LOP.MALOP
	AND MONHOC.MAMH = KETQUA.MAMH
	AND HOCSINH.MAHS = KETQUA.MAHS



---------------------------------------------------------------------------
	--MỞ THỬ VIEW
	SELECT * FROM V_HOCSINH



---------------------------------------------------------------------------
CREATE TRIGGER TR_THEMTRONGVIEWS
ON V_HOCSINH INSTEAD OF INSERT
AS
BEGIN
	--Neu MAHS ko co trong HOCSINH thi se duoc them vao
	IF(NOT EXISTS(SELECT MAHS FROM inserted WHERE MAHS IN(SELECT MAHS FROM HOCSINH)))
	BEGIN
		INSERT INTO HOCSINH
		SELECT MAHS, HOTEN, HOCBONG, MALOP FROM inserted

		PRINT '1 hoc sinh da duoc them vao bang HOCSINH!!!'
	END

	--Neu MAMH ko co trong MONHOC thi se duoc them vao
	IF(NOT EXISTS(SELECT MAMH FROM inserted WHERE MAMH IN(SELECT MAMH FROM MONHOC)))
	BEGIN
		INSERT INTO MONHOC
		SELECT MAMH, TENMH, SOTC FROM inserted

		PRINT '1 mon hoc da duoc them vao bang MONHOC!!!'
	END

	--them vao KETQUA
	IF(EXISTS(SELECT MAMH FROM inserted WHERE MAMH IN(SELECT MAMH FROM KETQUA)) OR NOT EXISTS(SELECT MAHS FROM inserted WHERE MAHS IN(SELECT MAHS FROM KETQUA)))
	BEGIN
		INSERT INTO KETQUA
		SELECT MAHS,MAMH,LANTHI,DIEM FROM inserted

		PRINT '1 dong da duoc them vao bang KETQUA!!!'
	END
END

---------------------------------------------------------------------------
--thêm thử
INSERT INTO V_HOCSINH
VALUES('HS07','NGUYEN VAN K',100000,'L01','CNTT','MH06','THIET KE WEB', 4, 1, 9)
INSERT INTO V_HOCSINH
VALUES('HS05','NGUYEN VAN E',100000,'L02','DIEN','MH06','THIET KE WEB', 4, 1, 9)
INSERT INTO V_HOCSINH
VALUES('HS09','NGUYEN VAN K',100000,'L02','DIEN','MH04','LAP RAP CAI DAT', 4, 1, 8)
INSERT INTO V_HOCSINH
VALUES('HS07','NGUYEN VAN K',100000,'L01','CNTT','MH05','LAP RAP CAI DAT', 4, 1, 10)


---------------------------------------------------------------------------
--xóa những gì liên quan đến học sinh cần xóa trong bảng LOP và KETQUA
CREATE TRIGGER TR_XOATRONGVIEWS
ON V_HOCSINH INSTEAD OF DELETE
AS
	-- Nếu xuất hiện mẫu tin trong bảng deleted
	IF((SELECT MAHS FROM deleted) IS NOT NULL)
	BEGIN
		--xóa những dòng có mã hs trong bảng deleted của bảng KETQUA
		DELETE FROM KETQUA
		WHERE MAHS = (SELECT MAHS FROM deleted)

		PRINT 'Da xoa ma hoc sinh trong bang KETQUA!!!'

		--xóa những dòng có mã hs trong bảng deleted của bảng HOCSINH
		DELETE FROM HOCSINH
		WHERE MAHS = (SELECT MAHS FROM deleted)

		PRINT 'Da xoa ma hoc sinh trong bang HOCSINH!!!'
	END


---------------------------------------------------------------------------
--xóa thử
DELETE FROM V_HOCSINH
WHERE MAHS = 'HS08'
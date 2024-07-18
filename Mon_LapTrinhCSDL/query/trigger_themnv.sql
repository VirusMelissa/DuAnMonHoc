CREATE TRIGGER TR_THEMNV
ON NHANVIEN
--nhan manh thao tac gi
FOR INSERT
AS
	-- Nếu xuất hiện mẫu tin trong bảng inserted
	IF((SELECT MAPHG FROM inserted) IS NOT NULL)
	BEGIN
		UPDATE PHONGBAN
		SET
			SOLUONGNV = SOLUONGNV + 1,
			-- inserted là bảng giả nhưng có cột như bảng nhân viên
			TONGLUONG = TONGLUONG + (SELECT LUONG FROM inserted)
		WHERE MAPHG = (SELECT MAPHG FROM inserted)

		PRINT 'DA CAP NHAT SLNV VA TONG LUONG!!!'
	END

----------------------------------------------------
--thêm nv thử
INSERT INTO NHANVIEN
VALUES('01','NGUYEN VAN A',5000000,'P1')
INSERT INTO NHANVIEN
VALUES('02','NGUYEN VAN B',6000000,'P1')
INSERT INTO NHANVIEN
VALUES('03','NGUYEN VAN C',12000000,'P2')
INSERT INTO NHANVIEN
VALUES('04','NGUYEN VAN D',15000000,'P2')
INSERT INTO NHANVIEN
VALUES('05','NGUYEN VAN E',15000000,'P2')

----------------------------------------------------
CREATE TRIGGER TR_XOANV
ON NHANVIEN
--nhan manh thao tac gi
FOR DELETE
AS
	-- Nếu xuất hiện mẫu tin trong bảng inserted
	IF((SELECT MAPHG FROM deleted) IS NOT NULL)
	BEGIN
		UPDATE PHONGBAN
		SET
			SOLUONGNV = SOLUONGNV - 1,
			-- inserted là bảng giả nhưng có cột như bảng nhân viên
			TONGLUONG = TONGLUONG - (SELECT LUONG FROM deleted)
		WHERE MAPHG = (SELECT MAPHG FROM deleted)

		PRINT 'DA CAP NHAT SAU KHI XOA!!!'
	END


----------------------------------------------------
CREATE TRIGGER TR_XOANV
ON NHANVIEN
--nhan manh thao tac gi
FOR DELETE
AS
	-- Nếu xuất hiện mẫu tin trong bảng inserted
	IF((SELECT MANV FROM deleted) IS NOT NULL)
	BEGIN
		DELETE FROM THAMGIA
		WHERE MANV = (SELECT MANV FROM deleted)

		UPDATE PHONGBAN
		SET
			SOLUONGNV = SOLUONGNV - 1,
			TONGLUONG = TONGLUONG - (SELECT LUONG FROM deleted)
		WHERE MAPHG = (SELECT MAPHG FROM deleted)

		PRINT 'DA CAP NHAT SAU KHI XOA!!!'
	END


----------------------------------------------------
--XÓA NHÂN VIÊN
DELETE FROM NHANVIEN
WHERE MANV = '01'

----------------------------------------------------
CREATE VIEW V_TTNVDA
AS
	SELECT PHONGBAN.MAPHG, NHANVIEN.MANV, HOTEN, LUONG, MADA, TGTHAMGIA
	FROM PHONGBAN, NHANVIEN, THAMGIA
	WHERE PHONGBAN.MAPHG = NHANVIEN.MAPHG
	AND NHANVIEN.MANV = THAMGIA.MANV

----------------------------------------------------
SELECT * FROM V_TTNVDA


----------------------------------------------------
CREATE TRIGGER TR_THEMNHANVIEN
ON V_TTNVDA INSTEAD OF INSERT
AS
BEGIN
	INSERT INTO NHANVIEN
	SELECT MANV,HOTEN,LUONG,MAPHG
	FROM INSERTED

	INSERT INTO THAMGIA
	SELECT MANV, MADA, TGTHAMGIA
	FROM INSERTED
END


INSERT INTO V_TTNVDA
VALUES('P2','01','NGO',7000000,'DA02', 12)
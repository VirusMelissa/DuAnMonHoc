create view vw_trigiaHD
as
select CTHD.SOHD, SUM(CTHD.SL*SANPHAM.GIA) as TONG
from CTHD, SANPHAM
where CTHD.MASP = SANPHAM.MASP
GROUP BY CTHD.SOHD

select * from vw_trigiaHD
where TONG between 300000 and 1000000
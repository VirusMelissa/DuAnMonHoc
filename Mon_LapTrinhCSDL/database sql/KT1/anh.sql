insert into THUCUNG (MATC,TENTC, IMPATH,ANH)
	select '01','THUOC 1','D:\Phuc\LT CSDL NC\image\Luu\Web\web dong\h1.jpg',bulkcolumn
	from openrowset (bulk 'D:\Phuc\LT CSDL NC\image\Luu\Web\web dong\h1.jpg', single_blob) as picture

insert into THUCUNG (MATC,TENTC, IMPATH,ANH)
	select '02','THUOC 2','D:\Phuc\LT CSDL NC\image\Luu\Web\web dong\h2.jpg',bulkcolumn
	from openrowset (bulk 'D:\Phuc\LT CSDL NC\image\Luu\Web\web dong\h2.jpg', single_blob) as picture
--tìm tất cả sản phẩm có cat id  =1
select * from Products
where CategoryID = 1
-- tim sảm pham có ten chưa chữ 'chai'
select * from Products
where ProductName like '%chai%'
-- tìm các sản phẩm bat đầu bằng "Ch"
select * from Products
where ProductName like 'ch%'
-- tìm các sản phẩm kết thúc bằng "ng"
select * from Products
where ProductName like '%ng'
-- tìm sản phẩm có giá > 20
select * from Products
where UnitPrice > 20
-- tìm sản phẩm có giá từ 20 - 40
select * from Products
where UnitPrice > 20 and UnitPrice < 40 order by UnitPrice desc
--  tìm sản phẩm có giá từ 20 - 40
select * from Products
where UnitPrice between 20 and 40
-- tìm giá lớn nhất
select * from Products 
where UnitPrice =(select top(1) UnitPrice from Products 
order by UnitPrice DESC)
-- lấy danh sách Danh Muc sản phẩm trong bảng Sản Phẩm
select CategoryID,COUNT(*) as SoSanPham from Products
group by CategoryID

-- lấy thông tin bảng sản phảm và dnah muc
select p.*,c.CategoryName from Products as p,Categories as c
where p.CategoryID = c.CategoryID
-- lấy thông tin bảng sản phảm là sea food
select p.*,c.CategoryName from Products as p,Categories as c
where p.CategoryID = c.CategoryID 
and c.CategoryName like '%seafood%'

INSERT INTO Categories
(CategoryName
,Description 
)
values(
N'Tiếng Việt',N'Tiếng Việt'
) 

select * from Categories
update Categories 
set Picture = null
-- tang 10 % 
update Products
set UnitPrice = UnitPrice * 1.1
select * from Products order by UnitPrice 

update Products
set SalePrice = UnitPrice * 0.8





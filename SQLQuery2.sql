-- Select
--Asagıdaki de bir tablodur.Bunu yapmak Fake bir tablo oluşturur
--Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers
Select *from Customers

Select *from Customers where City = 'Berlin'

Select *from Products where categoryId=1 or categoryId=3

Select *from Products where categoryId=1 and UnitPrice>=10

-- Kategorisi 1 olan ürünleri yüksek fiyattan düşüge doğru filtrele
--descing(desc) yuksekten düşüge , ascendind(asc)düşükten yükseğe sıralar
Select *from Products where CategoryID=1 order by UnitPrice desc

--Bütün products tablosunda kaç kolon oldugunu belirler
--Adet onun takma adıdır oluşan tabloda 'adet' diye yazar 
Select count(*) Adet from Products

-- group by her bir categoryID satırlarını getirir ve count ile her kategoride kac adet oldugunu soyler 
-- having kümülatiflere uygulanır. sart kosmamızı saglar yani adedi 10dan kucuk olanları getırır
--Önce where calısır.Where datadan fiyatı 20den buyuk olanları getırır ve onlar içinden adedi 10dan kucuk olanları tabloda gosterir
Select categoryID,count(*) Adet from products where UnitPrice>20  group by CategoryID having count(*)<10

-- join (birlestırmek) tabloları bır araya getirir
-- Asagıdaki 4 satır kısacası fiyatı 10dan buyuk olan urunlerı kategorisi ile beraber bize getirecek sorgudur.
Select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
--inner join ile kategori ve ürünlerin bir arada oldugu tablo olusturulur
 from Products inner join Categories
-- birlestirme kosulu on ıle yapılır
--on => Ürünler tablosundaki categoryID ile kategori tablosundaki categoryID birbirine esitse onları  yan yana getirir
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

-- inner join sadece 2 tabloda da eslesenleri getirir.Eslesmeyen data varsa onu getırmez 
Select *from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

--left join => solda olup sagda olmayanlarıda getir.Yani hiç alışveris yapmayan musterileri tablolar
Select *from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null
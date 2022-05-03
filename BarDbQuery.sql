
create database BarDb
use BarDb 
go

create table Producto (
idProducto int identity(1,1) NOT NULL PRIMARY KEY,
nomProd varchar(50) not null,
descripcion varchar(100) not null,
precio decimal(5,2) not null,
cantidad int,
estado int,
);

insert into Producto values ('Cubata','Guaraná',0.90, 40, 1);
insert into Producto values ('Chamaco','250 ml',3.00, 50, 1);
insert into Producto values ('Agua','mineral',1.5, 100, 1);
insert into Producto values ('Powerade','Limón',1.50, 40, 1);
insert into Producto values ('Tequila','250 ml',45.00, 0, 0);


select * from Producto

Create proc LeerProductos
as 
select *from Producto
go

/*exec MostrarProductos*/

create proc InsertarProductos
@nomprod varchar(50),
@descripcion varchar(100),
@precio decimal(5,2),
@cantidad int,
@estado int
as 
insert into Producto values (@nomprod, @descripcion, @precio, @cantidad, @estado)
go

exec InsetarProductos 'Pepsi','250 ml',45.00, 0, 0

create proc ActualizarProductos
@idproducto int,
@nomprod varchar(50),
@descripcion varchar(100),
@precio decimal(5,2),
@cantidad int,
@estado int
as 
update Producto set NomProd=@nomprod, descripcion=@descripcion, precio=@precio, cantidad=@cantidad, estado=@estado where idProducto=@idproducto
go

Id int identity (1,1) primary key,
Nombre varchar (100),
Descripcion varchar (100),
Precio float,
Cantidad int,
Estado int

create proc EliminarProductos
@idprod int
as
delete from Producto where idProducto=@idprod

Exec EliminarProductos 7

-- Base de datos, proyecto farmacia EPDVC

create database BaseFarmacia;
use BaseFarmacia;

--////////////////////////////////////////////////// TABLAS //////////////////////////////////////////////////////

create table Rol(
rol varchar(30) primary key not null
);

insert into Rol
Values('Farmaceutico'),
('Auxiliar');

create table Sexo (
	codigoSexo char(1) primary key not null,
	descripcion char(9)
);
insert into Sexo values('F','Fememino'),('M','Masculino');


create table Empleados(
	idEmpleado nvarchar(13) primary key not null,
	Nombres varchar(30) not null,
	Apellidos varchar(30) not null,
	FechaNacimiento date not null,
	Tel varchar(9) unique not null,
	Sexo char(1) not null, 
	rol varchar(30) not null,
	Estado varchar(20) not null,
	contrasenia nvarchar(30) not null,

	CONSTRAINT FK_ROL foreign key (rol) references Rol(rol),	
	CONSTRAINT FK_SEXO foreign key (Sexo) references Sexo(codigoSexo)
);

create table cliente(
    idcliente int identity(1,1) Primary key not null, 
	nombre varchar(50) not null,
	apellidos varchar(50) not null,
	direccion varchar(100) null,
	telefono varchar(9) null unique,
	dni nvarchar(13) null unique
);


create table categoria(
    idcategoria int identity(1,1) Primary key,
	nombre_categoria varchar(50) not null
);

create table producto(
idproducto int identity(1,1) Primary key,
idcategoria int not null,
nombre varchar (50) not null,
descripcion varchar (50) not null,
stock decimal (18,2),
precio_compra decimal (18,2) not null,
precio_venta decimal (18,2) not null,
fecha_vencimiento date not null,
imagen image 

constraint FK_IDcategoria foreign key (idcategoria) references categoria(idcategoria)
);

create table venta(
idventa int identity(1,1) Primary key,
idcliente int not null,
fecha_venta date not null,
tipo_documento varchar(50) not null,
num_documento varchar(50) not null,
idEmpleado nvarchar(13)

constraint FK_IDempleado foreign key (idEmpleado) references Empleados(idEmpleado),
constraint FK_IDcliente foreign key (idcliente) references cliente(idcliente)
);

create table detalle_venta(
iddetalle_venta int identity(1,1) Primary key,
idventa int not null,
idproducto int not null,
cantidad decimal (18,2) not null,
precio_unitario decimal (18,2) not null

constraint FK_IDventa foreign key (idventa) references venta(idventa),
constraint FK_IDproducto foreign key (idproducto) references producto(idproducto)
);

create table Proveedores(
	idProveedor int identity(1,1) primary key not null,
	P_descripProv varchar(20) unique not null,
	P_ciudad varchar(30) not null,
	P_Tel int unique not null,
);

create table Compra(
    idCompra int identity(1,1) primary key not null,
    idProveedor int,
    idproducto int not null,
    P_precio_compra decimal (18,2) not null,
    P_cantidad int not null,
	fecha_compra date not null

	constraint FK_IDproductoDos foreign key (idproducto) references producto(idproducto),
	constraint FK_IDProveedor foreign key (idProveedor) references Proveedores(idProveedor)
);


--////////////////////////////////////////////// PROCEDIMIENTOS ALMACENADOS //////////////////////////////////////////////////

-- EMPLEADO
-- Validar el empleado
create procedure validarUsuario
@userName nvarchar(13),
@psw varchar(15),
@rol varchar(30)
as begin
if exists(select Estado from Empleados where idEmpleado = @userName and contrasenia = @psw and rol = @rol and Estado = 'Activo')
          select * from empleados;
		else
        raiserror('El usuario no existe',16,1)
end


-- Insertar Empleado
create procedure insertar_Empleado
    @idEmpleado as nvarchar(13),
	@Nombres as varchar(30),
	@Apellidos as varchar(30),
	@FechaNacimiento as date,
	@Tel as varchar(9),
	@Sexo as char(1), 
	@rol as varchar(30),
	@Estado as varchar(20),
	@contrasenia as nvarchar(30)
	as begin
	     if exists (select idEmpleado, Tel from Empleados where idEmpleado=@idEmpleado and Tel=@Tel and Estado='activo')
		raiserror ('Ya existe un registro con estos datos, porfavor ingrese uno nuevo',16,1)
		else
		insert into Empleados values(@idEmpleado, @Nombres, @Apellidos, @FechaNacimiento, @Tel, @Sexo, @rol, @Estado, @contrasenia) 
end

--Editar Empleado
create procedure editar_Empleado
    @idEmpleado as nvarchar(13),
	@Nombres as varchar(30),
	@Apellidos as varchar(30),
	@FechaNacimiento as date,
	@Tel as varchar(9),
	@Sexo as char(1), 
	@rol as varchar(30),
	@Estado as varchar(20),
	@contrasenia as nvarchar(30)       
	as 
	   update Empleados set idEmpleado=@idEmpleado, Nombres=@Nombres, Apellidos=@Apellidos, FechaNacimiento=@FechaNacimiento, tel=@Tel, Sexo=@Sexo, rol=@rol, estado=@Estado, contrasenia=@contrasenia
	   where idEmpleado=@idEmpleado

-- Despedir Empleado
create procedure eliminar_Empleado
@idEmpleado as nvarchar(13),
@rol as varchar(30)
as begin
      if exists (select rol from Empleados where @rol = 'Farmaceutico')
	    raiserror('El usuario Farmaceutico no puede ser despedido',16,1)
	   else
	   update Empleados set Estado = 'Despedido'
	   where idEmpleado = @idEmpleado and rol <> 'Farmaceutico'
end

-- Mostrar Empleado
create procedure Mostrar_Empleado
as
select idempleado as 'Codigo', Nombres as 'Nombres',Apellidos as 'Apellidos', FechaNacimiento AS 'Fecha de Nacimiento', tel As 'Telefono', Sexo as 'Sexo', rol as 'Rol', estado as 'Estado'
	   From Empleados 
	   order by  idEmpleado desc
go
-- Mostrar Empleados activos
create procedure Mostrar_EmpleadoActivo
as
select idempleado as 'Codigo', Nombres as 'Nombres',Apellidos as 'Apellidos', FechaNacimiento AS 'Fecha de Nacimiento', tel As 'Telefono', Sexo as 'Sexo', rol as 'Rol', estado as 'Estado'
	   From Empleados 
	   where Estado = 'Activo'
go

-- BUSQUEDA
create procedure buscarEmpleado
@UserName varchar(25)
as
select idempleado as 'Codigo', Nombres as 'Nombres',Apellidos as 'Apellidos', FechaNacimiento AS 'Fecha de Nacimiento', tel As 'Telefono', Sexo as 'Sexo', rol as 'Rol', estado as 'Estado'
	   From Empleados 
where CONCAT(Nombres, '',Apellidos) like '%' +@UserName+ '%'


-- CLIENTE
-- Mostrar Cliente
create procedure mostrar_cliente
as
select idcliente as 'Codigo',nombre as 'Nombre Cliente', apellidos as 'Apellidos Cliente',telefono as 'Telefono',dni as 'Identidad' from cliente order by idcliente desc
go

-- insertar cliente
create procedure insertar_cliente 
	@nombre varchar(50),
	@apellidos varchar(50),
	@direccion varchar(100),
	@telefono varchar(9),
	@dni nvarchar(13)
	as begin
		if exists (select dni,telefono from cliente where dni=@dni and telefono=@telefono)
		raiserror ('Ya existe un registro con ese DNI, porfavor ingrese uno nuevo',16,1)
		else
		insert into cliente values(@nombre,@apellidos,@direccion,@telefono,@dni) 
end

--Editar cliente
create procedure editar_cliente
    @idcliente int, 
	@nombre as varchar(50),
	@apellidos varchar(50),
	@direccion varchar(100),
	@telefono varchar(9),
	@dni nvarchar(13)
	as
	   update cliente set nombre = @nombre, apellidos = @apellidos, direccion = @direccion, telefono = @telefono,dni = @dni
	   where idcliente = @idcliente
go

-- Buscar cliente
create procedure buscarCliente
@dni nvarchar(13)
as
select idcliente as 'Codigo',nombre as 'Nombre Cliente', apellidos as 'Apellidos Cliente',telefono as 'Telefono',dni as 'Identidad' 
from cliente
where dni like '%' +@dni+ '%'

-- CATEGORIA
-- Mostrar Cargar categoria
create procedure mostrar_categoria
as
select idcategoria as 'Codigo Categoria',nombre_categoria as 'Nombre Categoria' from categoria order by idcategoria desc
go

-- insertar categoria
create procedure insertar_categoria
	@nombre_categoria varchar(50)
	as begin
		if exists (select nombre_categoria from categoria where nombre_categoria=@nombre_categoria )
		raiserror ('Ya existe esa categoria, porfavor ingrese uno nuevo',16,1)
		else
		insert into categoria values(@nombre_categoria) 
end

-- modificar categoria
create procedure editar_categoria
    @idcategoria int,
	@nombre_categoria varchar(50)
	as
    UPDATE categoria set nombre_categoria = @nombre_categoria
     where idcategoria = @idcategoria
go

-- Buscar categoria
create procedure buscarCategoria
@nombre_categoria varchar(50)
as
select idcategoria as 'Codigo Categoria',nombre_categoria as 'Nombre Categoria' from categoria
where nombre_categoria like '%' +@nombre_categoria+ '%'

--PRODUCTO
--mostrar productos
create procedure mostrar_producto
as
select pro.idproducto as 'Codigo producto', pro.idcategoria as 'Codigo categoria', cat.nombre_categoria as 'Categoria', pro.nombre as 'Producto',pro.descripcion as 'Descripcion',pro.stock as 'Stock',pro.precio_compra as 'Precio de compra',pro.precio_venta as 'Precio de venta',pro.fecha_vencimiento as 'Fecha de vencimiento',pro.imagen as 'Imagen'
from producto as pro inner join categoria as cat on pro.idcategoria = cat.idcategoria
order by pro.idproducto desc
go

-- Insertar producto
create procedure insertar_producto
@idcategoria int,
@nombre varchar (50),
@descripcion varchar (50),
@stock decimal (18,2),
@precio_compra decimal (18,2),
@precio_venta decimal (18,2),
@fecha_vencimiento date,
@imagen image
as
		insert into producto values(@idcategoria,@nombre,@descripcion,@stock,@precio_compra,@precio_venta,@fecha_vencimiento,@imagen) 
go

-- editar producto
create procedure editar_producto
@idproducto int,
@idcategoria int,
@nombre varchar (50),
@descripcion varchar (50),
@stock decimal (18,2),
@precio_compra decimal (18,2),
@precio_venta decimal (18,2),
@fecha_vencimiento date,
@imagen image
as
update producto	set idcategoria=@idcategoria, nombre=@nombre, descripcion=@descripcion, stock=@stock, precio_compra=@precio_compra,	precio_venta=@precio_venta, fecha_vencimiento=@fecha_vencimiento, imagen=@imagen
where idproducto=@idproducto
go

-- Buscar producto
create procedure buscarProducto
@nombre varchar (50)
as
select pro.idproducto as 'Codigo producto', pro.idcategoria as 'Codigo categoria', cat.nombre_categoria as 'Categoria', pro.nombre as 'Producto',pro.descripcion as 'Descripcion',pro.stock as 'Stock',pro.precio_compra as 'Precio de compra',pro.precio_venta as 'Precio de venta',pro.fecha_vencimiento as 'Fecha de vencimiento',pro.imagen as 'Imagen'
from producto as pro inner join categoria as cat on pro.idcategoria = cat.idcategoria
where pro.nombre like '%' +@nombre+ '%'

-- VENTA
-- insertar venta
create procedure insertar_venta
@idcliente as int,
@fecha_venta as date,
@tipo_documento as varchar(50),
@num_documento as varchar(50),
@idEmpleado as nvarchar(13)
as
insert into venta values(@idcliente,@fecha_venta,@tipo_documento,@num_documento,@idEmpleado)
go

--editar
create procedure editar_venta
@idventa as int,
@idcliente as int,
@fecha_venta as date,
@tipo_documento as varchar(50),
@num_documento as varchar(50),
@idEmpleado as nvarchar(13)
as
update venta set idcliente=@idcliente,fecha_venta=@fecha_venta,tipo_documento=@tipo_documento,num_documento=@num_documento, idEmpleado=@idEmpleado
where idventa=@idventa
go

-- mostrar venta
create procedure mostrar_venta
as
SELECT   dbo.venta.idventa as 'Codigo Venta', dbo.venta.idcliente 'Codigo Cliente', dbo.cliente.nombre as 'Nombre Cliente', dbo.cliente.apellidos as 'Apellidos Cliente', dbo.cliente.dni as 'Identidad Cliente', dbo.venta.fecha_venta as 'Fecha de la venta', dbo.venta.num_documento as 'Numero de Documento', dbo.Empleados.Nombres as 'Nombre Empleado', dbo.Empleados.Apellidos as 'Apellidos Empleado'
FROM     dbo.venta INNER JOIN
             dbo.cliente ON dbo.venta.idcliente = dbo.cliente.idcliente
			 inner join 
			 dbo.Empleados ON dbo.venta.idEmpleado = dbo.Empleados.idEmpleado
			 order by dbo.venta.idventa desc
			 go

-- Buscar Venta
create procedure buscarVenta
@num_documento as varchar(50)
as
SELECT   dbo.venta.idventa as 'Codigo Venta', dbo.venta.idcliente 'Codigo Cliente', dbo.cliente.nombre as 'Nombre Cliente', dbo.cliente.apellidos as 'Apellidos Cliente', dbo.cliente.dni as 'Identidad Cliente', dbo.venta.fecha_venta as 'Fecha de la venta', dbo.venta.num_documento as 'Numero de Documento', dbo.Empleados.Nombres as 'Nombre Empleado', dbo.Empleados.Apellidos as 'Apellidos Empleado'
FROM     dbo.venta INNER JOIN
             dbo.cliente ON dbo.venta.idcliente = dbo.cliente.idcliente
			 inner join 
			 dbo.Empleados ON dbo.venta.idEmpleado = dbo.Empleados.idEmpleado
where num_documento like '%' +@num_documento+ '%'

-- DETALLES DE VENTA

-- insertar detalles venta
create procedure insertar_detalles_venta
@idventa as int,
@idproducto as int,
@cantidad as decimal (18,2),
@precio_unitario as decimal (18,2)
as
insert into detalle_venta values(@idventa,@idproducto,@cantidad,@precio_unitario)
go

-- editar detalles venta
create procedure editar_detalles_venta
@iddetalle_venta as int,
@idventa as int,
@idproducto as int,
@cantidad as decimal (18,2),
@precio_unitario as decimal (18,2)
as
update detalle_venta set idventa=@idventa,idproducto=@idproducto,cantidad=@cantidad,precio_unitario=@precio_unitario
where iddetalle_venta=@iddetalle_venta
go

-- mostrar detalles venta

create procedure mostrar_detalle_venta
as
SELECT        dbo.detalle_venta.iddetalle_venta as 'Codigo Venta', dbo.detalle_venta.idventa as 'Cod Venta', dbo.detalle_venta.idproducto as 'Codigo Producto', dbo.producto.nombre as 'Producto', dbo.detalle_venta.cantidad as 'Cantidad', dbo.detalle_venta.precio_unitario as 'Precio Unitario'
FROM            dbo.detalle_venta INNER JOIN
                         dbo.producto ON dbo.detalle_venta.idproducto = dbo.producto.idproducto 
						 order by  dbo.detalle_venta.iddetalle_venta desc
go

-- STOCK
-- AUMENTAR STOCK
create procedure aumentar_stock
@idproducto as int,
@cantidad as decimal (18,2)
as
update producto set stock = stock+@cantidad 
where idproducto=@idproducto
go

-- DISMINUID STOCK
create procedure disminuir_stock
@idproducto as int,
@cantidad as decimal (18,2)
as
update producto set stock = stock-@cantidad 
where idproducto=@idproducto
go

-- PROVEEDORE
--Mostrar Proveedor
create procedure mostrar_proveedor
	as
	select
	      idProveedor as 'Codigo Proveedor', P_descripProv as 'Descripcion del Proveedor', P_ciudad as 'Ciudad', P_Tel as 'Telefono'
    from Proveedores 
	order by  idProveedor desc
go

-- Insertar Proveedor
create procedure insertar_Proveedor
	@P_descripProv varchar(20),
	@P_ciudad varchar(30),
	@P_Tel int

	as begin
		if exists (select P_Tel from Proveedores where P_Tel=@P_Tel)
		raiserror ('Ya existe un Proveedor con este telefono, porfavor ingrese uno nuevo',16,1)
		else
		insert into Proveedores values(@P_descripProv,@P_ciudad,@P_Tel) 
end

-- Editar Proveedor
create procedure editar_Proveedor
    @idProveedor int,
	@P_descripProv varchar(20),
	@P_ciudad varchar(30),
	@P_Tel int
	as
	   update Proveedores set P_descripProv=@P_descripProv, P_ciudad=@P_ciudad, P_Tel=@P_Tel
	   where idProveedor = @idProveedor
go

-- Buscar proveedor
create procedure buscarProveedor
@P_descripProv varchar(20)
as
	select
	      idProveedor as 'Codigo Proveedor', P_descripProv as 'Descripcion del Proveedor', P_ciudad as 'Ciudad', P_Tel as 'Telefono'
    from Proveedores
where P_descripProv like '%' +@P_descripProv+ '%'


--CompraProveedor

-- Insertar CompraProveedor
create procedure insertar_CompraProveedor
	@idProveedor int,
	@idproducto int,
	@P_precio_compra decimal (18,2),
	@P_cantidad int,
	@fecha_compra date

	as begin
		insert into Compra values(@idProveedor,@idproducto,@P_precio_compra,@P_cantidad,@fecha_compra) 
end


-- MostrarCompraProveedor

create procedure mostrar_CompraProveedor
as
SELECT dbo.Compra.idCompra as 'Codigo Compra', dbo.Proveedores.idProveedor as 'Codigo Proveedor', dbo.producto.idproducto as 'Codigo Producto', dbo.Proveedores.P_descripProv as 'Descripcion Proveedor', dbo.producto.nombre as 'Producto', dbo.Compra.P_cantidad as 'Cantidad', dbo.Compra.P_precio_compra as 'Precio de Compra', dbo.Compra.fecha_compra as 'Fecha de Compra'
FROM   dbo.producto INNER JOIN
             dbo.Compra ON dbo.producto.idproducto = dbo.Compra.idproducto INNER JOIN
             dbo.Proveedores ON dbo.Compra.idProveedor = dbo.Proveedores.idProveedor
			 order by dbo.Compra.idCompra desc


-- REPORTE PARA LA FACTURA
create procedure reporteVenta
@idventa as int
as
begin
	   if exists (select idventa from venta where idventa = '')
		raiserror ('No existe el reporte de esta venta',16,1)
		else

SELECT dbo.venta.idventa as 'No Venta', dbo.cliente.nombre as 'Nombre Cliente', dbo.cliente.apellidos as 'Apellidos Cliente', dbo.venta.fecha_venta as 'Fecha de Venta', dbo.venta.tipo_documento as 'Tipo de documento', dbo.venta.num_documento as 'Numero de documento', dbo.producto.nombre as 'Producto', dbo.detalle_venta.cantidad as 'Cantidad', dbo.detalle_venta.precio_unitario as 'Precio Unitario', (dbo.detalle_venta.precio_unitario * dbo.detalle_venta.cantidad) as 'Total x producto'
FROM   dbo.detalle_venta INNER JOIN
             dbo.venta ON dbo.detalle_venta.idventa = dbo.venta.idventa INNER JOIN
             dbo.producto ON dbo.detalle_venta.idproducto = dbo.producto.idproducto INNER JOIN
             dbo.Empleados ON dbo.venta.idEmpleado = dbo.Empleados.idEmpleado INNER JOIN
             dbo.cliente ON dbo.venta.idcliente = dbo.cliente.idcliente
			 where dbo.venta.idventa = @idventa
end


-- Procedimiento para la suma total de las ventas
create procedure SumaTotal
@idventa as int
as
select idventa, sum(precio_unitario*cantidad) as 'Total de la compra' 
from detalle_venta 
where idventa = @idventa
Group by idventa;
go


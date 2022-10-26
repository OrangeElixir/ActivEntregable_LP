--- PROCEDIMIENTOS ALMACENADOS PARA LA TABLA ALUMNOS -----

---- PROCEDIMIENTO PARA LISTAR ALUMNOS ------
create procedure alumnos_listar
as
select concat(a.primer_nombre,' ', a.segundo_nombre, ' ', a.primer_apellido, ' ', a.segundo_apellido) Nombre_Completo,
	a.telefono, a.celular, a.direccion, a.email, a.fecha_de_nacimiento as Fecha_de_Nacimiento,
	a.observaciones
	from Alumnos a
	order by a.primer_apellido desc
go

---- PROCEDIMIENTO PARA BUSCAR ALUMNOS ------
create procedure alumnos_buscar
@valor varchar(50)
as
select a.id_alumno, concat(a.primer_nombre,' ', a.segundo_nombre, ' ', a.primer_apellido, ' ', a.segundo_apellido) Nombre_Completo,
	a. telefono, a.celular, a.direccion, a.fecha_de_nacimiento
	from Alumnos a
	where concat(a.primer_nombre,' ', a.segundo_nombre, ' ', a.primer_apellido, ' ', a.segundo_apellido) like '%' + @valor + '%' or
	a.direccion like '%' + @valor + '%' or a.fecha_de_nacimiento like '%' + @valor + '%'
	order by a.primer_apellido desc
go

---- PROCEDIMIENTO PARA INSERTAR ALUMNOS ------
create procedure alumnos_insertar
@primer_nombre varchar(50),
@segundo_nombre varchar(50),
@primer_apellido varchar(50),
@segundo_apellido varchar(50),
@telefono varchar(11),
@celular varchar(11),
@direccion varchar(80),
@email varchar(50),
@fecha_de_nacimiento date,
@observaciones varchar(100)
as 
insert into Alumnos(primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, telefono,
	celular, direccion, email, fecha_de_nacimiento, observaciones) values (@primer_nombre,@segundo_nombre,
	@primer_apellido, @segundo_apellido, @telefono, @celular, @direccion, @email, @fecha_de_nacimiento, @observaciones)
go

---- PROCEDIMIENTO PARA MODIFICAR ALUMNOS ------
create procedure alumnos_modificar
@id_alumno int,
@primer_nombre varchar(50),
@segundo_nombre varchar(50),
@primer_apellido varchar(50),
@segundo_apellido varchar(50),
@telefono varchar(11),
@celular varchar(11),
@direccion varchar(80),
@email varchar(50),
@fecha_de_nacimiento date,
@observaciones varchar(100)
as
update Alumnos set primer_nombre=@primer_nombre, segundo_nombre=@segundo_nombre, primer_apellido=@primer_apellido,
	segundo_apellido=@segundo_apellido, telefono=@telefono, celular=@celular, direccion=@direccion, email=@email,
	fecha_de_nacimiento=@fecha_de_nacimiento, observaciones=@observaciones
	where id_alumno=@id_alumno
go

---- PROCEDIMIENTO PARA ELIMINAR ALUMNOS ------
create procedure alumnos_eliminar
@id_alumno int
as 
delete from Alumnos where id_alumno=@id_alumno
go

---- PROCEDIMIENTO PARA SELECCIONAR ALUMNOS ------

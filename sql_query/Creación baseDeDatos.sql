use master
go

---Creación de la base de datos-----
if db_id('db_lp_activEntregable') is not null
	create database db_lp_activEntregable
go

create database db_lp_activEntregable
go

----- Creación de la tabla Alumnos ----
use db_lp_activEntregable

create table Alumnos(
	id_alumno integer primary key identity,
	primer_nombre varchar(50) not null,
	segundo_nombre varchar(50) not null,
	primer_apellido varchar(50) not null,
	segundo_apellido varchar(50) not null,
	telefono varchar(11),
	celular varchar(11),
	direccion varchar(80) not null,
	email varchar(50),
	fecha_de_nacimiento date not null,
	observaciones varchar(100) 
)
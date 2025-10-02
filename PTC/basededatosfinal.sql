create database ClinicaDental
go

use ClinicaDental
go

CREATE TABLE Configuracion(
idConfig int identity (1,1) primary key,
nombreClinica varchar(100) NOT NULL,
direccion varchar(200) NOT NULL,
telefono varchar(10) NOT NULL,
email varchar(50) NOT NULL,
pimerUsuarioCreado BIT NOT NULL DEFAULT 0,
FechaConfiguracion datetime NOT NULL DEFAULT GETDATE(),
configurado bit NOT NULL DEFAULT 0,
id_Usuario int null , 
foreign key (id_Usuario) references Usuario(idUsuario) 
)
go

select *from Usuario

select *from Configuracion

drop table Configuracion
truncate table Usuario

create table Producto (
idProducto int identity (1,1) primary key,
nombrePro varchar (50),
precio decimal (5,2)
);
go

select idProducto, nombrePro from Producto

create table Venta (
idVenta int identity (1,1) primary key,
cantidad int,
id_Producto int, 
foreign key (id_Producto) references Producto (idProducto)
);
go  

create table Rol( 
idRol int identity (1,1) primary key,
nombreRol varchar (50) not null
);
go

create table Especialidad (
idEspecialidad int primary key identity(1,1),
nombreEspecialidad varchar(50),
);
go


create table Usuario (
idUsuario int identity (1,1) primary key,
nombreUsu varchar(50),
apellidoUsu varchar(50),
fechaNaciUsu date,
duiUsu varchar(20) unique,
telefonoUsu varchar(25),
correoUsu varchar(50),
contrasena varchar(255),
estadoVerificado BIT NOT NULL DEFAULT 0,
id_Rol int,
id_Especialidad int,
id_Venta int,
foreign key (id_Rol) references Rol (idRol),
foreign key (id_Especialidad) references Especialidad (idEspecialidad), 
foreign key (id_Venta) references Venta (idVenta)
);
go

SELECT *FROM Usuario

create table Enfermedades (
idEnfermedades int identity (1,1) primary key,
 nombreEnfer varchar(50)
);
go

create table Alergias (
 idAlergias int identity (1,1) primary key,
 nombreAl varchar(50)
);
go

delete from Configuracion
delete from Usuario

create table Expediente (
idExpediente int primary key identity(1,1),
nombrePa varchar (50),
apellidoPa varchar (50),
fechaNacimiento date,
telefonoPa varchar (25),
direccionPa varchar (90),
correoPa varchar (50),
dui varchar (20) Unique,
id_Enfermedades int,
id_Alergias int,
foreign key (id_Enfermedades) references Enfermedades (idEnfermedades),
foreign key (id_Alergias) references Alergias (idAlergias)
);
go

create table Paciente (
idPaciente int identity (1,1) primary key,
id_Expediente int,
foreign key (id_Expediente) references Expediente (idExpediente)
);
go

create table Doctor (
idDoctor int identity (1,1) primary key,
id_Especialidad int,
id_Paciente int
foreign key (id_Especialidad) references Especialidad (idEspecialidad), 
foreign key (id_Paciente) references Paciente (idPaciente)
);
go


create table Cita (
idCita int identity (1,1) primary key,
razonCita varchar (100),
fechaHoraCita datetime,
id_Paciente int
foreign key (id_Paciente) references Paciente (idPaciente)
);
go 

create table EstadoDiente (
    idEstado int primary key identity(1,1),
    nombre_estado varchar(30) NOT NULL  
);
go

create table Diente (
    idDiente int primary key identity(1,1),
    codigo varchar(10) NOT NULL,     
    descripcion varchar(50)         
);
go

create table HistorialDental (
    idHistorial int primary key identity(1,1),
    id_Paciente int,
    id_Diente int,
    id_Estado int,
    fecha date,
    observaciones varchar(50),
    foreign key  (id_Paciente) references Paciente(idPaciente),
    foreign key (id_Diente) references Diente(idDiente),
    foreign key (id_Estado) references EstadoDiente(idEstado)
);
go

insert Producto values ('Par de cepillos dentales - Crayola', 4),
('Hilo dental',3),
('Cepillo dental de viaje', 2.75),
('Limpieza para ortodoncia', 2.25),
('Desensibilizante', 2.45),
('Fluor infantil',2.50),
('Biflúor', 2.95),
('Cepillo de ortodoncia', 3.50),
('Limpiador de lengua', 3.20),
('Proxabrush', 3.40),
('Perio-Gard', 3.20),
('Cepillo interdental', 2.90),
('Enjuague bucal', 4.75),
('Cepillo dental - Sunstar', 2.30)
GO

INSERT INTO Diente (codigo, descripcion) VALUES

('11', 'Incisivo central superior derecho'),
('12', 'Incisivo lateral superior derecho'),
('13', 'Canino superior derecho'),
('14', 'Primer premolar superior derecho'),
('15', 'Segundo premolar superior derecho'),
('16', 'Primer molar superior derecho'),
('17', 'Segundo molar superior derecho'),
('18', 'Tercer molar superior derecho'),

('21', 'Incisivo central superior izquierdo'),
('22', 'Incisivo lateral superior izquierdo'),
('23', 'Canino superior izquierdo'),
('24', 'Primer premolar superior izquierdo'),
('25', 'Segundo premolar superior izquierdo'),
('26', 'Primer molar superior izquierdo'),
('27', 'Segundo molar superior izquierdo'),
('28', 'Tercer molar superior izquierdo'),

('31', 'Incisivo central inferior izquierdo'),
('32', 'Incisivo lateral inferior izquierdo'),
('33', 'Canino inferior izquierdo'),
('34', 'Primer premolar inferior izquierdo'),
('35', 'Segundo premolar inferior izquierdo'),
('36', 'Primer molar inferior izquierdo'),
('37', 'Segundo molar inferior izquierdo'),
('38', 'Tercer molar inferior izquierdo'),

('41', 'Incisivo central inferior derecho'),
('42', 'Incisivo lateral inferior derecho'),
('43', 'Canino inferior derecho'),
('44', 'Primer premolar inferior derecho'),
('45', 'Segundo premolar inferior derecho'),
('46', 'Primer molar inferior derecho'),
('47', 'Segundo molar inferior derecho'),
('48', 'Tercer molar inferior derecho');
go


INSERT INTO EstadoDiente (nombre_estado) VALUES
('Limpio'),
('Caries'),
('Restaurado'),
('Ausente'),
('Endodoncia'),
('Fracturado'),
('Obturado'),
('Corona'),
('Prótesis'),
('Manchado');
go



insert into Rol values ('Administrador'),
('Asistente'),
('Dentista')
go


insert into Especialidad values ('Ninguno'),
('Cirujinao dental'),
('Endodoncista'),
('Ortodoncista'),
('Maxilofacial')
go

insert into Alergias values ('Ninguna'),
('latex'),
('metales'),
('anestesia local')
go

insert into Enfermedades values ('Ninguna'),
('diabetes'),
('infecciones'),
('Hepatitis')
go

insert into Expediente (nombrePa, apellidoPa, fechaNacimiento, telefonoPa, direccionPa, correoPa, dui, id_Enfermedades, id_Alergias) VALUES 
('María', 'González', '1985-03-15', '2222-3333', 'Colonia Escalón, San Salvador', 'maria@email.com', '12345678-9', 1, 2),
('Carlos', 'Rodríguez', '1990-07-22', '2555-4444', 'Santa Tecla, La Libertad', 'carlos@email.com', '23456789-0', 2, 1),
('Ana', 'Martínez', '1978-11-30', '2666-7777', 'Soyapango, San Salvador', 'ana@email.com', '34567890-1', 3, 3),
('Luis', 'Hernández', '1982-05-18', '2777-8888', 'Mejicanos, San Salvador', 'luis@email.com', '45678901-2', 4, 4),
('Sofia', 'López', '1995-09-08', '2888-9999', 'San Miguel', 'sofia@email.com', '56789012-3', 5, 5),
('Jorge', 'Díaz', '1988-12-25', '2999-0000', 'Ahuachapán', 'jorge@email.com', '67890123-4', 6, 6),
('Elena', 'Torres', '1975-02-14', '2333-2222', 'Santa Ana', 'elena@email.com', '78901234-5', 7, 7),
('Miguel', 'Ramírez', '1992-06-30', '2444-3333', 'Sonsonate', 'miguel@email.com', '89012345-6', 8, 8),
('Carmen', 'Flores', '1980-08-17', '2555-4444', 'La Unión', 'carmen@email.com', '90123456-7', 9, 9),
('Roberto', 'Castro', '1970-04-12', '2666-5555', 'Chalatenango', 'roberto@email.com', '01234567-8', 10, 10);

select *from Paciente
select *from Rol
select *from Especialidad
select *from Expediente
select *from Venta
select *from Cita
select *from Usuario
select *from Enfermedades
select *from Alergias
select *from ConfiguracionNegocio
select *from Producto
go

create view VerExpediente as
select idExpediente as Expediente, nombrePa as [Nombre del Paciente], apellidoPa as [Apellido del paciente], fechaNacimiento as [Fecha de nacimiento], telefonoPa as Telefono, direccionPa as [Direccion] ,correoPa as [Correo del paciente], dui as DUI ,nombreEnfer as Enfermedades, nombreAl as Alergias
from Expediente E
left join
Alergias C on C.idAlergias=E.id_Alergias
left join
Enfermedades F on F.idEnfermedades=E.id_Enfermedades
go

create view DatosCita as
select idCita as Cita,idPaciente as Paciente, nombrePa as [Nombre del paciente], apellidoPa as [Apellido del paciente], razonCita as [Razón de la cita],correoPa as [Correo del paciente] ,fechaHoraCita as [Fecha y hora]
from Cita C
left join
Paciente P on P.idPaciente=C.id_Paciente
left Join
Expediente E on E.idExpediente=P.id_Expediente
go

create view CrearUsuario as
SELECT idUsuario as Usuario, nombreUsu as Nombre, apellidoUsu as Apellido, fechaNaciUsu as [Fecha de nacimiento], 
       duiUsu as DUI, telefonoUsu as Telefono, correoUsu as Correo, nombreRol AS Rol, nombreEspecialidad AS Especialidad FROM Usuario 
LEFT JOIN 
Rol ON Rol.idRol = Usuario.id_Rol 
LEFT JOIN 
Especialidad ON Especialidad.idEspecialidad= Usuario.id_Especialidad
go

drop view Ventas

create view Ventas as
select  idVenta as Venta, nombrePro as Producto, precio as Precio, cantidad as [Cantidad vendida] from Venta V
left join
Producto P on P.idProducto=V.id_Producto

create trigger InsertarPaciente
on Expediente
for insert
as 
insert into Paciente (id_Expediente)
select idExpediente from inserted;
go


create proc EliminarPaciente 
(
@id int
)
as 
begin 
delete Paciente where idPaciente = @id
delete Expediente where idExpediente = @id
end;
go

create Proc FechaHistorial
(
@idPaciente int
)
as
begin 
SELECT DISTINCT CONVERT(date, h.fecha) AS Fecha
FROM HistorialDental h
WHERE h.id_Paciente = @idPaciente
ORDER BY Fecha DESC
end;
go


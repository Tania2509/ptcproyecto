create database ClinicaDental
go

use ClinicaDental
go

create table Venta (
idVenta int identity (1,1) primary key,
nombreVen varchar(50),
precio decimal (8,2),
cantidad int
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
id_Rol int,
id_Especialidad int,
id_Venta int,
foreign key (id_Rol) references Rol (idRol),
foreign key (id_Especialidad) references Especialidad (idEspecialidad), 
foreign key (id_Venta) references Venta (idVenta)
);
go



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

select *from Expediente

update Expediente set idExpediente = , nombrePa = , apellidoPa = , fechaNacimiento = , telefonoPa = , direccionPa = , correoPa = , id_Enfermedades = , id_Alergias = where idExpediente =

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

insert into Rol values ('Dentista'),
('Asistente'),
('Administrador')
go

insert into Especialidad values ('Ninguno'),
('Cirujinao dental'),
('Endodoncista'),
('Ortodoncista'),
('Maxilofacial')
go

select *From Usuario

INSERT INTO Usuario 
VALUES 
('Carlos', 'Mendoza', '1985-03-15', '12345678-9', '7777-8888', 'carlos@clinica.com', '$2a$11$I5eCzCRIm0cGGzotIgA4O.dAdM3Hxnpsiuj0.HzWvb1K0RN3dJRfO', 3, 1, NULL)

Update Usuario set nombreUsu = @Nombre, apellidoUsu = @Apellido, correoUsu

SELECT r.nombreRol FROM Usuario U

INNER JOIN Rol r ON u.id_Rol = r.idRol
WHERE correoUsu = 'carlos@clinica.com' AND contrasena = 'pass123'

/*
insert into Expediente values ('Diabetes', 'Anestesia'),
('Enfermedades cardiacas', 'Antibioticos'),
('Ninguna', 'Latex'),
('Leucemia','Acrilicos'),
(null, 'formaldehido')


insert into Cita values ('Limpieza', '2025/09/01 12:30', 4),
('Limpieza', '2025/10/29 12:50', 5),
('Brackets', '2025/11/29 12:30', 6),
('Limpieza', '2025/09/23 12:50', 7),
('Relleno', '2025/09/20 12:45', 8),
('Relleno', '2025/09/19 12:30', 9),
('Brackets', '2025/09/15 12:30', 10),
('Limpieza', '2025/08/01 12:45', 11),
('Brackets', '2025/09/01 12:50', 12),
('Limpieza', '2025/7/04 12:45', 13),
('Brackets', '2025/10/13 12:50', 14),
('Relleno', '2025/08/09 12:35', 15),
('Brackets', '2025/09/02 12:30', 16),
('Relleno', '2025/09/10 12:45', 17),
('Relleno', '2025/09/05 12:30', 18)

insert into Paciente values ('René', 'Morales', '1985-05-20', '7201-2244','Villa Heroes pasaje 3' ,'rene.morales@clinicadental.com', '015487239',1),
('Carla', 'Medina', '1990-08-11', '7745-3310', 'Ayutuxepeque pasaje 3 avenida San miguel' ,'carla.medina@clinicadental.com', '027543810',2),
('Esteban', 'Velásquez', '1987-03-09', '7310-9988', 'Calle La Reforma' ,'esteban.velasquez@clinicadental.com', '038712945',1),
('Silvia', 'Martínez', '1992-11-02', '7154-1109','Residencial Altavista' ,'silvia.martinez@clinicadental.com', '047521893',4),
('Oscar', 'Navarro', '1983-12-18', '7520-6631', 'Calle el Almendro' ,'oscar.navarro@clinicadental.com', '051239478',2),
('Iliana', 'Escobar', '1986-01-23', '7680-4455','Av. Los heroes' ,'iliana.escobar@clinicadental.com', '042358719',1),
('Rodrigo', 'Pineda', '1991-06-07', '7077-8822','Calle El Paraiso' ,'rodrigo.pineda@clinicadental.com', '036789452',3),
('Marcela', 'Trujillo', '1989-04-29', '7930-2155', 'Zacatecoluca','marcela.trujillo@clinicadental.com', '059814237',3),
('Álvaro', 'Reyes', '1993-09-16', '7230-1998','Zacatecoluca' ,'alvaro.reyes@clinicadental.com', '026748391',1),
('Norma', 'Cáceres', '1984-07-05', '7901-3350','Av.Morazan' ,'norma.caceres@clinicadental.com', '019384751',5),
('Mauricio', 'Delgado', '1988-02-14', '7822-9076', 'Calle 5 de noviembre','mauricio.delgado@clinicadental.com', '062149378',1),
('Karina', 'Figueroa', '1995-10-30', '7644-1101','Calle el Almendro' ,'karina.figueroa@clinicadental.com', '073521894',3),
('Ernesto', 'Aguilar', '1982-08-08', '7755-4210','Pasaje Los Cipreses' ,'ernesto.aguilar@clinicadental.com', '084713569',5),
('Pamela', 'Lara', '1994-03-12', '7922-3300','Av.Morazan' ,'pamela.lara@clinicadental.com', '098123745',6),
('Víctor', 'Rosales', '1986-06-25', '7811-6644','Calle el Almendro' ,'victor.rosales@clinicadental.com', '048293175',2);


select *from Paciente

insert into Venta values ('Cepillo', 3.45, 1),
('Paquete de cepillos', 5, 2),
('Pasta dental', 2.50, 1),
('Enjuague bucal', 7, 2),
('Hilo dental', 2.10, 3),
('Enjuague bucal de menta', 4, 1),
('Cepillo', 3.45, 1),
('Hilo dental', 2.10, 4),
('Cepillo', 3.45, 4),
('Enjuague bucal', 7, 3),
('Cepillo', 3.45, 1),
('Hilo dental', 2.10, 1),
('Paquete de cepillos', 5, 3),
('Enjuague bucal', 7, 1),
('Paquete de cepillos', 5, 1),
('Enjuague bucal de menta', 4, 2)



insert into Expediente values ('Diabetes', 'Latex'),
('Ninguna', 'Ninguno'),
('Enfermedades cardíacas','Resinas'),
('Leucemia', 'Acrilicos'),
('Enfermedades renales','Antibióticos'),
(null, 'Clorhexidina') */

insert into Alergias values ('Latex');
insert into Enfermedades values ('Anemia');

select *from Paciente
select *from Rol
select *from Especialidad
select *from Expediente
select *from Venta
select *from Cita
select *from Usuario
select *from Enfermedades
select *from Alergias
go



create view VerExpediente as
select idExpediente as ID, nombrePa as [Nombre del Paciente], apellidoPa as [Apellido del paciente], fechaNacimiento as [Fecha de nacimiento], telefonoPa as Telefono, direccionPa as [Direccion] ,correoPa as [Correo del paciente], dui as DUI ,nombreEnfer as Enfermedades, nombreAl as Alergias
from Expediente E
left join
Alergias C on C.idAlergias=E.id_Alergias
left join
Enfermedades F on F.idEnfermedades=E.id_Enfermedades
go

drop view DatosCita

create view DatosCita as
select idCita as ID, nombrePa as [Nombre del paciente], apellidoPa as [Apellido del paciente], razonCita as [Razón de la cita],correoPa as [Correo del paciente] ,fechaHoraCita as [Fecha y hora]
from Cita C
left join
Paciente P on P.idPaciente=C.id_Paciente
left Join
Expediente E on E.idExpediente=P.id_Expediente
go

create view CrearUsuario as
SELECT idUsuario as ID, nombreUsu as Nombre, apellidoUsu as Apellido, fechaNaciUsu as [Fecha de nacimiento], 
       duiUsu as DUI, telefonoUsu as Telefono, correoUsu as Correo, nombreRol AS Rol, nombreEspecialidad AS Especialidad, contrasena FROM Usuario 
LEFT JOIN 
Rol ON Rol.idRol = Usuario.id_Rol 
LEFT JOIN 
Especialidad ON Especialidad.idEspecialidad= Usuario.id_Especialidad
go

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

select *From Alergias
select *from Paciente
select *from Expediente


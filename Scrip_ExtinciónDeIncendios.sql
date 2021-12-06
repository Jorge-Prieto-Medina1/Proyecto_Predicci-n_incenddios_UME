CREATE DATABASE prediccion_incendios;

Go

USE prediccion_incendios;

DROP TABLE IF EXISTS Usuario;
CREATE TABLE usuario (
idUsuario int IDENTITY(1, 1),
nombreUsuario VARCHAR (80),
correoUsuario VARCHAR (80),
contrasenaUsuario VARCHAR (80),
activo VARCHAR (80),
PRIMARY KEY (correoUsuario)
);

GO

DROP TABLE IF EXISTS Provincia;
CREATE TABLE provincia (
idProvincia int IDENTITY(1, 1),
nombreProvincia VARCHAR (80),
PRIMARY KEY (idProvincia)
);

GO

DROP TABLE IF EXISTS Localidad;
CREATE TABLE localidad (
idLocalidad int IDENTITY(1, 1),
idProvincia int not null,
nombreLocalidad VARCHAR (80),
temperaturaMediaPrimavera int,
humedadMediaPrimavera int,
temperaturaMediaVerano int,
humedadMediaVerano int,
temperaturaMediaOtoño int,
humedadMediaOtoño int,
temperaturaMediaInvierno int,
humedadMediaInvierno int,
PRIMARY KEY (idLocalidad),
FOREIGN KEY (idProvincia) REFERENCES Provincia(idProvincia)
);

GO

DROP TABLE IF EXISTS DatoMeteorologico;
CREATE TABLE datoMeteorologico (
idDato int IDENTITY(1, 1),
idLocalidad int not null,
temperaturaMedia int,
humedadMedia int,
fechaDeInicio date,
fechaDeFinalizacion date,
PRIMARY KEY (idDato),
FOREIGN KEY (idLocalidad) REFERENCES Localidad(idLocalidad),
);

GO

DROP TABLE IF EXISTS Incendio;
CREATE TABLE Incendio (
idIncendio int IDENTITY(1, 1),
idLocalidad int not null,
hectareasQuemadas int,
temperaturaMedia int,
humedadMedia int,
fechaDeInicio date,
fechaDeExtinción date,
PRIMARY KEY (idIncendio),
FOREIGN KEY (idLocalidad) REFERENCES Localidad(idLocalidad),
);

GO

INSERT INTO provincia VALUES ('Albacete');
INSERT INTO provincia VALUES ('Alicante');
INSERT INTO provincia VALUES ('Almería');
INSERT INTO provincia VALUES ('Álava');
INSERT INTO provincia VALUES ('Asturias');
INSERT INTO provincia VALUES ('Badajoz');
INSERT INTO provincia VALUES ('Baleares');
INSERT INTO provincia VALUES ('Barcelona');
INSERT INTO provincia VALUES ('Burgos');
INSERT INTO provincia VALUES ('Cáceres');
INSERT INTO provincia VALUES ('Cádiz');
INSERT INTO provincia VALUES ('Cantabria');
INSERT INTO provincia VALUES ('Castellón');
INSERT INTO provincia VALUES ('Ciudad Real');
INSERT INTO provincia VALUES ('Córdoba');
INSERT INTO provincia VALUES ('Coruña');
INSERT INTO provincia VALUES ('Cuenca');
INSERT INTO provincia VALUES ('Gipuzkoa');
INSERT INTO provincia VALUES ('Gerona');
INSERT INTO provincia VALUES ('Granada');
INSERT INTO provincia VALUES ('Guadalajara');
INSERT INTO provincia VALUES ('Huelva');
INSERT INTO provincia VALUES ('Huesca');
INSERT INTO provincia VALUES ('Jaén');
INSERT INTO provincia VALUES ('La Rioja');
INSERT INTO provincia VALUES ('Las Palmas');
INSERT INTO provincia VALUES ('León');
INSERT INTO provincia VALUES ('Lérida');
INSERT INTO provincia VALUES ('Lugo');
INSERT INTO provincia VALUES ('Madrid');
INSERT INTO provincia VALUES ('Málaga');
INSERT INTO provincia VALUES ('Murcia');
INSERT INTO provincia VALUES ('Navarra');
INSERT INTO provincia VALUES ('Ourense');
INSERT INTO provincia VALUES ('Palencia');
INSERT INTO provincia VALUES ('Pontevedra');
INSERT INTO provincia VALUES ('Salamanca');
INSERT INTO provincia VALUES ('Santa Cruz de Tenerife');
INSERT INTO provincia VALUES ('Segovia');
INSERT INTO provincia VALUES ('Sevilla');
INSERT INTO provincia VALUES ('Soria');
INSERT INTO provincia VALUES ('Tarragona');
INSERT INTO provincia VALUES ('Teruel');
INSERT INTO provincia VALUES ('Toledo');
INSERT INTO provincia VALUES ('Valencia');
INSERT INTO provincia VALUES ('Valladolid');
INSERT INTO provincia VALUES ('Vizcaya');
INSERT INTO provincia VALUES ('Zamora');
INSERT INTO provincia VALUES ('Zaragoza');
INSERT INTO provincia VALUES ('Ceuta');
INSERT INTO provincia VALUES ('Melilla');


INSERT INTO localidad Values ( 1, 'Alcalá del Júcar','15', '20', '30', '10', '10', '30', '0', '30');
INSERT INTO localidad Values ( 2, 'Denia','17', '22', '30', '14', '14', '32', '5', '20');
go

INSERT INTO datoMeteorologico Values ( 2, '17', '22', '18-06-12 10:34:09 PM', '18-06-12 10:34:09 PM');
go

INSERT INTO Usuario VALUES ('jorge', 'jorge@hotmail.com', '1234', 'Activo');
INSERT INTO Usuario VALUES ('123', '123', '123', 'Activo');

Go

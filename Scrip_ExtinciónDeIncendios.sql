CREATE DATABASE prediccion_incendios;

Go

USE prediccion_incendios;

DROP TABLE IF EXISTS Usuario;
CREATE TABLE usuario (
idUsuario int IDENTITY(1, 1),
nombreUsuario VARCHAR (80),
correoUsuario VARCHAR (80),
contrasenaUsuario VARCHAR (80),
activo Bit,
PRIMARY KEY (idUsuario)
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
fotoLocalidad image,
temperaturaMediaPrimavera float,
humedadMediaPrimavera float,
temperaturaMediaVerano float,
humedadMediaVerano float,
temperaturaMediaOtoño float,
humedadMediaOtoño float,
temperaturaMediaInvierno float,
humedadMediaInvierno float,
PRIMARY KEY (idLocalidad),
FOREIGN KEY (idProvincia) REFERENCES Provincia(idProvincia)
);

GO

DROP TABLE IF EXISTS DatoMeteorologico;
CREATE TABLE datoMeteorologico (
idDato int IDENTITY(1, 1),
idLocalidad int not null,
temperaturaMedia float,
humedadMedia float,
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
temperaturaMedia float,
humedadMedia float,
fechaDeInicio date,
fechaDeExtinción date,
PRIMARY KEY (idIncendio),
FOREIGN KEY (idLocalidad) REFERENCES Localidad(idLocalidad),
);

GO



INSERT INTO Usuario VALUES ('jorge', 'jorge@hotmail.com', '1234', 1);


Go

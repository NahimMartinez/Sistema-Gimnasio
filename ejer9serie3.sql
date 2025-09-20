
CREATE DATABASE gestion_colegios;
GO


USE gestion_colegios;
GO

CREATE TABLE directora
(
  dni INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(50) NOT NULL,
  apellido VARCHAR(50) NOT NULL
);


CREATE TABLE provincia
(
  id_provincia INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(50) NOT NULL
);


CREATE TABLE localidad
(
  id_localidad INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(50) NOT NULL,
  id_provincia INT NOT NULL,
  CONSTRAINT FK_localidad_provincia FOREIGN KEY (id_provincia) REFERENCES provincia(id_provincia)
);


CREATE TABLE direccion
(
  id_direccion INT IDENTITY(1,1) PRIMARY KEY,
  direccion VARCHAR(100) NOT NULL,
  id_localidad INT NOT NULL,
  CONSTRAINT FK_direccion_localidad FOREIGN KEY (id_localidad) REFERENCES localidad(id_localidad)
);


CREATE TABLE colegio
(
  id_colegio INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(100) NOT NULL,
  telefono VARCHAR(20) NOT NULL,
  poliza_nro INT NOT NULL,
  dni INT NOT NULL,
  id_direccion INT NOT NULL,
  FOREIGN KEY (dni) REFERENCES directora(dni),
  FOREIGN KEY (id_direccion) REFERENCES direccion(id_direccion)
);


CREATE TABLE division
(
  id_division INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(50) NOT NULL
);


CREATE TABLE turno
(
  id_turno INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(50) NOT NULL
);


CREATE TABLE sexo
(
  id_sexo INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(20) NOT NULL
);


CREATE TABLE alumno
(
  dni INT PRIMARY KEY,
  nombre VARCHAR(50) NOT NULL,
  apellido VARCHAR(50) NOT NULL,
  fecha_nac DATE NOT NULL,
  domicilio VARCHAR(100) NOT NULL,
  id_direccion INT NOT NULL,
  id_division INT NOT NULL,
  id_turno INT NOT NULL,
  id_sexo INT NOT NULL,
  FOREIGN KEY (id_direccion) REFERENCES direccion(id_direccion),
  FOREIGN KEY (id_division) REFERENCES division(id_division),
  FOREIGN KEY (id_turno) REFERENCES turno(id_turno),
  FOREIGN KEY (id_sexo) REFERENCES sexo(id_sexo)
);


CREATE TABLE grado
(
  id_grado INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(20) NOT NULL,
  id_division INT NOT NULL,
  FOREIGN KEY (id_division) REFERENCES division(id_division)
);


CREATE TABLE lugar_ocurrencia
(
  id_lugar INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(50) NOT NULL
);


CREATE TABLE forma_accidente
(
  id_forma INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(50) NOT NULL
);


CREATE TABLE lesiones
(
  id_lesion INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(50) NOT NULL
);


CREATE TABLE siniestro
(
  id_siniestro INT IDENTITY(1,1) PRIMARY KEY,
  fecha_hora DATETIME NOT NULL,
  id_lugar INT NOT NULL,
  id_forma INT NOT NULL,
  id_colegio INT NOT NULL,
  dni INT NOT NULL,
  FOREIGN KEY (id_lugar) REFERENCES lugar_ocurrencia(id_lugar),
  FOREIGN KEY (id_forma) REFERENCES forma_accidente(id_forma),
  FOREIGN KEY (id_colegio) REFERENCES colegio(id_colegio),
  FOREIGN KEY (dni) REFERENCES alumno(dni)
);


CREATE TABLE siniestro_lesion
(
  id_siniestro INT NOT NULL,
  id_lesion INT NOT NULL,
  PRIMARY KEY (id_siniestro, id_lesion),
  FOREIGN KEY (id_siniestro) REFERENCES siniestro(id_siniestro),
  FOREIGN KEY (id_lesion) REFERENCES lesiones(id_lesion)
);
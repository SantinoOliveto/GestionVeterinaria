-- Creación de la base de datos
CREATE DATABASE VeterinariaDB;
USE VeterinariaDB;

--Tabla Usuarios
CREATE TABLE Usuarios(
    UsuarioID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(50) NOT NULL,
    Clave VARCHAR(50) NOT NULL,
    );

--Tabla Clientes
CREATE TABLE Clientes(
    ClienteID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(50) NOT NULL,
    DNI INT NOT NULL UNIQUE,
    );

--Tabla Especie
CREATE TABLE Especies(
    EspecieID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(50) NOT NULL,
    EdadMadurez INT NOT NULL,
    PesoPromedio DECIMAL(10,2) NOT NULL,
    );

--Tabla Animal
CREATE TABLE Animales(
    AnimalID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(50) NOT NULL,
    Peso DECIMAL(10,2) NOT NULL,
    Edad INT NOT NULL,
    ClienteDNI INT NOT NULL,
    EspecieID INT NOT NULL,
    FOREIGN KEY (ClienteDNI) REFERENCES Clientes(DNI),
    FOREIGN KEY (EspecieID) REFERENCES Especies(EspecieID)
    );

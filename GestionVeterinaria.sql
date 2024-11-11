-- Creación de la base de datos
CREATE DATABASE VeterinariaDB;
USE VeterinariaDB;

-- Tabla Cliente
CREATE TABLE Cliente (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Dni VARCHAR(15) NOT NULL,
    Nombres NVARCHAR(100) NOT NULL
);

-- Tabla Especie
CREATE TABLE Especie (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombres NVARCHAR(50) NOT NULL,
    EdadesMadurez INT NOT NULL,
    PesosPromedio DECIMAL(10, 2) NOT NULL
);

-- Tabla Animal
CREATE TABLE Animal (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombres NVARCHAR(50) NOT NULL,
    Pesos DECIMAL(10, 2) NOT NULL,
    Edades INT NOT NULL,
    ClienteId INT NOT NULL,
    EspecieId INT NOT NULL,
    FOREIGN KEY (ClienteId) REFERENCES Cliente(Id),
    FOREIGN KEY (EspecieId) REFERENCES Especie(Id)
);

-- Tabla Usuario
CREATE TABLE Usuario (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombres NVARCHAR(100) NOT NULL,
    Claves NVARCHAR(256) NOT NULL -- Hash de la contraseña
);

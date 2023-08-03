CREATE DATABASE Exercicio_1_2
USE Exercicio_1_2

CREATE TABLE Empresa
(
IdEmpresa INT PRIMARY KEY IDENTITY,
Nome VARCHAR (20) NOT NULL,

)

CREATE TABLE Marca
(
 IdMarca INT PRIMARY KEY IDENTITY,
 Nome VARCHAR (20)


)

CREATE TABLE Cliente
(
 IdCliente	INT PRIMARY KEY IDENTITY,
 Nome VARCHAR (20),
 Cpf VARCHAR (11)

)

CREATE TABLE Modelo
(
 IdModelo INT PRIMARY KEY IDENTITY,
 Nome VARCHAR (20)

)

CREATE TABLE Veiculo
(
IdVeiculo INT PRIMARY KEY IDENTITY,
Placa VARCHAR (10),
IdMarca INT FOREIGN KEY REFERENCES Marca(IdMarca),
IdModelo INT FOREIGN KEY REFERENCES Modelo(IdModelo),
IdEmpresa INT FOREIGN KEY REFERENCES Empresa(IdEmpresa)


)

CREATE TABLE Aluguel
(
IdAluguel INT PRIMARY KEY IDENTITY,
IdVeiculo INT FOREIGN KEY REFERENCES Veiculo(IdVeiculo),
IdCliente INT FOREIGN KEY REFERENCES Cliente(IdCliente),
Valor SMALLMONEY
)

SELECT * FROM Veiculo


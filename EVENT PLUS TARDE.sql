--DDL - Data definition language

--criar o banco de dados
CREATE DATABASE [Event+_Tarde]
USE[Event+_Tarde]

--criar as tabelas
CREATE TABLE TiposDeUsuario
(
	IdTipoDeUsuario INT PRIMARY KEY IDENTITY,
	TituloTiposUsuario VARCHAR(50) NOT NULL UNIQUE
)

CREATE TABLE TiposDeEvento
(
	IdTipoDeEvento INT PRIMARY KEY IDENTITY,
	TituloTipoEvento VARCHAR(50) NOT NULL UNIQUE
)

CREATE TABLE Instituicao
(
	IdInstituicao INT PRIMARY KEY IDENTITY,
	CNPJ CHAR(14) NOT NULL UNIQUE,
	Endereco VARCHAR(200) NOT NULL,
	NomeFantasia VARCHAR (200) NOT NULL
)

CREATE TABLE Usuario 
(
	IdUsuario INT PRIMARY KEY IDENTITY,
	IdTipoDeUsuario INT FOREIGN KEY REFERENCES TiposDeUsuario(IdTipoDeUsuario) NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	Email VARCHAR(50) NOT NULL UNIQUE,
	Senha VARCHAR(50) NOT NULL
)

CREATE TABLE Evento
(
	IdEvento INT PRIMARY KEY IDENTITY,
	IdTipoDeEvento INT FOREIGN KEY REFERENCES TiposDeEvento (IdTipoDeEvento),
	IdInstituicao INT FOREIGN KEY REFERENCES Instituicao (IdInstituicao),
	Nome VARCHAR (100) NOT NULL,
	DataEvento DATE NOT NULL,
	HorarioEvento TIME NOT NULL
	
)

CREATE TABLE PresencasEvento
(
	IdPresencasEvento INT PRIMARY KEY IDENTITY,
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(idUsuario) NOT NULL,
	IdEvento INT FOREIGN KEY REFERENCES Evento(IdEvento) NOT NULL,
	Situacao BIT DEFAULT(0)
)


CREATE TABLE ComentarioEvento
(
	IdComentarioEvento INT PRIMARY KEY IDENTITY,
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(idUsuario) NOT NULL,
	IdEvento INT FOREIGN KEY REFERENCES Evento(IdEvento) NOT NULL,
	Descricao VARCHAR(200),
	Exibe BIT DEFAULT(0)
)

--criar script para consulta exibindo os seguintes dados 
-- Usar Join
--nome do usuario
--tipo do usuario
--data do evento
--local do evento 
--tipo do evento
--nome do evento
--descricao do evento
--situacao do evneto
--comentario do evento



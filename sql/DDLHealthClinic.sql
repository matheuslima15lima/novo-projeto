--DDL - Data definition language


--criar o banco de dados
CREATE DATABASE HealthClinic_Tarde

USE HealthClinic_Tarde



--criar as tabelas
 CREATE TABLE Clinica
 (
  IdClinica INT PRIMARY KEY IDENTITY,
  Endereco VARCHAR(50) NOT NULL,
  CNPJ VARCHAR(14) NOT NULL UNIQUE,
  RazaoSocial VARCHAR(20) NOT NULL UNIQUE,
  NomeFantasia VARCHAR(20) NOT NULL,
  HoraAbertura Time,
  HoraFechamento Time,
 )


 CREATE TABLE TipoDeUsuario
 (
  IdTipoDeUsuario INT PRIMARY KEY IDENTITY,
  TituloTipoDeUsuario VARCHAR(50) NOT NULL UNIQUE,
 )

 CREATE TABLE Usuario
 (
 IdUsuario INT PRIMARY KEY IDENTITY,
 IdTipoDeUsuario INT FOREIGN KEY REFERENCES TipoDeUsuario(IdTipoDeUsuario),
 Nome VARCHAR (50) NOT NULL,
 Email VARCHAR (50) NOT NULL UNIQUE,
 Senha VARCHAR (50) NOT NULL,
 Telefone VARCHAR (11)
 
 )
  CREATE TABLE Paciente
  (
  IdPaciente INT PRIMARY KEY IDENTITY,
  IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario)
  
  )
   
   --COMO ADICIONAR UMA COLUNA NA TABELA !!!!!!!!!!!!!!!
  ALTER TABLE Paciente
ADD RG VARCHAR(20)  NULL ;

  CREATE TABLE Especialidade
  (
  IdEspecialidade INT PRIMARY KEY IDENTITY,
  Titulo VARCHAR (20)
  
  )

  --ALTERANDO A QUANTIDADE DE CARACTERES
  ALTER TABLE Especialidade ALTER COLUMN Titulo VARCHAR(50)

  CREATE TABLE Medico
  (
  IdMedico INT PRIMARY KEY IDENTITY,
  IdClinica INT FOREIGN KEY REFERENCES Clinica(IdClinica),
  IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
  IdEspecialidade INT FOREIGN KEY REFERENCES Especialidade(IdEspecialidade)
  )
   ALTER TABLE Medico
ADD CRM VARCHAR(20) NOT NULL UNIQUE ;

  CREATE TABLE Situacao
  (
  IdSituacao INT PRIMARY KEY IDENTITY,
  Descricao BIT DEFAULT(0) 
  )

  CREATE TABLE Consulta
  (
	IdConsulta INT PRIMARY KEY IDENTITY,
	IdPaciente INT FOREIGN KEY REFERENCES Paciente(IdPaciente),
	IdMedico INT FOREIGN KEY REFERENCES Medico (IdMedico),
	IdSituacao INT FOREIGN KEY REFERENCES Situacao(IdSituacao),
	DataAgendamento DATETIME,
	Descricao VARCHAR(100)
  
  )

  CREATE TABLE Comentario
  (
   IdComentario INT PRIMARY KEY IDENTITY,
   IdConsulta INT FOREIGN KEY REFERENCES Consulta(IdConsulta),
   IdPaciente INT FOREIGN KEY REFERENCES Paciente (IdPaciente),
   Descricao VARCHAR(100),
   DataComentario DATE,
   Exibe BIT DEFAULT(0) 
  
  
  )


  select * from Clinica,Usuario,TipoDeUsuario,Paciente, Medico,Consulta,Comentario
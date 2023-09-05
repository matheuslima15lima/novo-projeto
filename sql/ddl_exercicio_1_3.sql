Create DATABASE exercicio_1_3
use exercicio_1_3

CREATE TABLE Clinica
(
 IdClinica INT PRIMARY KEY  IDENTITY,
 endereco VARCHAR(20)
)
 
 alter table Clinica alter column Endereco VARCHAR(50)
 


CREATE TABLE Veterinario 
(
IdVeterinario INT PRIMARY KEY IDENTITY,
IdClinica INT FOREIGN KEY REFERENCES Clinica(IdClinica),
Nome VARCHAR(20)
)

CREATE TABLE Dono
(
idDono INT PRIMARY KEY IDENTITY,
Nome VARCHAR (20)

)

CREATE TABLE Raca
(
IdRaca INT PRIMARY KEY IDENTITY,
Descricao VARCHAR (20)

)

CREATE TABLE TipoPet
(
IdTipoPet INT PRIMARY KEY IDENTITY,
Descricao VARCHAR (20)

)

CREATE TABLE Pet
(
IdPet INT PRIMARY KEY IDENTITY,
IdDono INT FOREIGN KEY REFERENCES Dono(IdDono),
IdRaca INT FOREIGN KEY REFERENCES Raca(IdRaca),
IdTipoPet INT FOREIGN KEY REFERENCES TipoPet(IdtipoPet),
Nome VARCHAR (20),
Nascimento DATE
)


CREATE TABLE Atendimento
(
IdAtendimento INT PRIMARY KEY IDENTITY,
IdVeterinario INT FOREIGN KEY REFERENCES Veterinario(IdVeterinario),
IdPet INT FOREIGN KEY REFERENCES Pet (IdPet),
Descricao VARCHAR (20),
 DataAtendimento DATE



)


SELECT * FROM Atendimento







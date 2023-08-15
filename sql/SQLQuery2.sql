
USE HealthClinic_Tarde

--DML DATA MANIPULATION LANGUAGE

--INSERINDO DADOS

INSERT INTO Clinica ( Endereco,CNPJ,RazaoSocial,NomeFantasia,HoraAbertura,HoraFechamento)
VALUES('Rua Niteroi, 180 São Caetano do sul','83094672000130','Health Clinic','HC','06:00:00','22:00:00')


INSERT INTO TipoDeUsuario ( TituloTipoDeUsuario)
VALUES ('Administrador')


INSERT INTO TipoDeUsuario ( TituloTipoDeUsuario)
VALUES ('Medico')

INSERT INTO TipoDeUsuario ( TituloTipoDeUsuario)
VALUES ('Paciente')



INSERT INTO Usuario (IdTipoDeUsuario, Nome, Email, Senha,Telefone)
VALUES ('1','Gerson','gerson@gmail.com','1234','40028744')

INSERT INTO Usuario (IdTipoDeUsuario, Nome, Email, Senha,Telefone)
VALUES ('2','Matheus','Matheus@gmail.com','1333','9034356')

INSERT INTO Usuario (IdTipoDeUsuario, Nome, Email, Senha,Telefone)
VALUES ('3','Willian','Will@gmail.com','345','996998545')

INSERT INTO Paciente(IdUsuario)
VALUES('3')


INSERT INTO Paciente(IdUsuario,RG)
VALUES('3','23355556')






update Paciente set RG = 1233455 where IdPaciente = 1



INSERT INTO Especialidade (Titulo)
VALUES ('Cardiologista')

INSERT INTO Especialidade (Titulo)
VALUES ('Otorrinolaringologista')

select * from Especialidade





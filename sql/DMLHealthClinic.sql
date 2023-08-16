
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
VALUES ('2','joao','joao@gmail.com','1223','70363996')


INSERT INTO Usuario (IdTipoDeUsuario, Nome, Email, Senha,Telefone)
VALUES ('2','Tiago','Tiago@gmail.com','1263','71383679')


INSERT INTO Usuario (IdTipoDeUsuario, Nome, Email, Senha,Telefone)
VALUES ('3','Willian','Will@gmail.com','345','996998545')


INSERT INTO Usuario (IdTipoDeUsuario, Nome, Email, Senha,Telefone)
VALUES ('3','OTAVIO','otavio@gmail','555','986688525')


INSERT INTO Usuario (IdTipoDeUsuario, Nome, Email, Senha,Telefone)
VALUES ('3','Ryan','RYAN@gmail.com','225','294998715')


INSERT INTO Usuario (IdTipoDeUsuario, Nome, Email, Senha,Telefone)
VALUES ('3','Ricardo','Ricardo@gmail.com','125','997897546')

INSERT INTO Paciente(IdUsuario)
VALUES('3')

select * from Paciente


INSERT INTO Paciente(IdUsuario,RG)
VALUES('3','23355556')

INSERT INTO Paciente(IdUsuario,RG)
VALUES('4','34377578')








update Paciente set RG = 1233455 where IdPaciente = 1



INSERT INTO Especialidade (Titulo)
VALUES ('Cardiologista')


INSERT INTO Especialidade (Titulo)
VALUES ('Nutricionista')

INSERT INTO Especialidade (Titulo)
VALUES ('Otorrinolaringologista')

select * from Especialidade

INSERT INTO Medico(IdUsuario, IdEspecialidade, CRM)
VALUES ('2','4','425617')

INSERT INTO Medico(IdUsuario, IdEspecialidade, CRM)
VALUES ('7','4','234784')


INSERT INTO Medico(IdUsuario, IdEspecialidade, CRM)
VALUES ('8','1','334795')


INSERT INTO Situacao(Descricao)
VALUES('1')

INSERT INTO Situacao(Descricao)
VALUES('0')

select * from Situacao

update Medico set IdClinica = 1 where IdMedico = 1

select * from Medico


select * from Usuario


INSERT INTO Consulta(IdPaciente, IdMedico, IdSituacao, DataAgendamento, Descricao)
VALUES('3','1','1','2023-09-11','Paciente deseja perder peso')

select * from Consulta

INSERT INTO Comentario (IdConsulta,IdPaciente,Descricao,DataComentario,Exibe)
VALUES ('5', '3','Gostei muito da consulta', '2023-09-11', '1')

select * from Comentario
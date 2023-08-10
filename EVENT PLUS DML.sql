 --USE[Event+_Tarde]
 --DML

--INSERT INTO TiposDeUsuario (TituloTiposUsuario) values('administrador');
--INSERT INTO  TiposDeUsuario (TituloTiposUsuario) values('Comum');

--INSERT INTO TiposDeEvento (TituloTipoEvento) VALUES ('SQL Server');


INSERT INTO TiposDeEvento (TituloTipoEvento) VALUES ('HTML para iniciantes');


--INSERT INTO Instituicao (CNPJ, Endereco, NomeFantasia)
--VALUES('83094672000130', 'Rua Niteroi, 180 São Caetano do sul', 'DevSchool')




 --INSERT INTO Usuario (IdTipoDeUsuario, Nome, Email, Senha)
 --VALUES ('1','Matheus','Matheus@gmail.com','12345')

  INSERT INTO Usuario (IdTipoDeUsuario, Nome, Email, Senha)
 VALUES ('2','Willian','Willian@gmail.com','215')

 INSERT INTO Evento (IdTipoDeEvento, IdInstituicao, Nome, Descricao, DataEvento, HorarioEvento)
 VALUES(
 
 
 1,1, 'Intensivao sql server', 'uma introducao ao sql server','2023-09-11','15:30:00'
 
 )

 INSERT INTO PresencasEvento(IdUsuario, IdEvento)
 VALUES(2,1);

 INSERT INTO ComentarioEvento(IdUsuario,IdEvento,Descricao, Exibe)
 VALUES (1,1, 'GOSTEI DESSE EVENTO !!!', 1);



 --para adicionar elementos na tabela
 
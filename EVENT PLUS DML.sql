 --USE[Event+_Tarde]
 --DML

INSERT INTO TiposDeUsuario (TituloTiposUsuario) values('adm');

INSERT INTO  TiposDeUsuario (TituloTiposUsuario) values('Comum');

INSERT INTO TiposDeEvento (TituloTipoEvento) VALUES ('SQL Server');


INSERT INTO TiposDeEvento (TituloTipoEvento) VALUES ('HTML para iniciantes');


INSERT INTO Instituicao (CNPJ, Endereco, NomeFantasia)
VALUES('83094672000130', 'Rua Niteroi, 180 São Caetano do sul', 'DevSchool')




 INSERT INTO Usuario (IdTipoDeUsuario, Nome, Email, Senha)
 VALUES ('1','Matheus','Matheus@gmail.com','12345')

  INSERT INTO Usuario  (IdTipoDeUsuario, Nome, Email, Senha) 
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

 select * from ComentarioEvento
 select * from Usuario
 select* from TiposDeUsuario
 select * from Evento
 select * from PresencasEvento
 select * from TiposDeEvento
 
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


 select
 Usuario.Nome, 
 TiposDeUsuario.TituloTiposUsuario, 
 Evento.DataEvento,
 Instituicao.NomeFantasia,
 TiposDeEvento.TituloTipoEvento,
 Evento.Nome,
 Evento.Descricao,
 PresencasEvento.Situacao ,CASE WHEN PresencasEvento.Situacao = 1 THEN  'CONFIRMADO' ELSE 'NÃO CONFIRMADO' END,
 ComentarioEvento.Descricao
 from Evento
	Inner join TiposDeEvento
	ON Evento.IdTipoDeEvento = TiposDeEvento.IdTipoDeEvento

	inner join Instituicao
	ON Evento.IdInstituicao = Instituicao.IdInstituicao

	INNER JOIN PresencasEvento
	ON Evento.IdEvento = PresencasEvento.IdEvento

	INNER JOIN Usuario
	ON  Usuario.IdUsuario = PresencasEvento.IdUsuario

	INNER JOIN TiposDeUsuario
	ON TiposDeUsuario.IdTipoDeUsuario = Usuario.IdTipoDeUsuario

	INNER JOIN ComentarioEvento
	ON ComentarioEvento.IdUsuario = Usuario.IdUsuario



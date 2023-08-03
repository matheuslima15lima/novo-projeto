--Listar as pessoas em ordem alfabetica reversa,mostrando seus telefones,email e cnhs
--SCRIPT SEM USAR JOIN

SELECT P.Nome AS Batata,
Telefone.Numero AS Telefone,
Email.Endereço AS Ecarta, 
P.CNH AS Volante
FROM 
Pessoa AS P,
Email AS Email,
Telefone
WHERE P.IdPessoa = Email.IdPessoa AND P.IdPessoa = Telefone.IdPessoa
order by Nome DESC

insert into Pessoa
values
('Gabriel','0987443'),
('Julio','12344fff')



insert into Pessoa values('artur','12344556')
insert into Email values(1,'artur@gmail.com')
insert into Telefone values(1,'1109456333')


insert into Pessoa values('joao','113828956')
insert into Email values(2,'jao@gmail.com')
insert into Telefone values(2,'1104456753')

insert into Pessoa values('matheus','133448958')
insert into Email values(3,'matheus@gmail.com')
insert into Telefone values(3,'1105556883')

select * from pessoa


/*DELETE FROM Pessoa WHERE IdPessoa = 11*/
USE Exercicio_1_2__DQL

INSERT INTO Empresa(Nome)
Values('eff')

INSERT INTO Empresa(Nome)
Values('gm')

INSERT INTO Empresa(Nome)
Values('unreal')

INSERT INTO Empresa(Nome)
Values('rtirib')

INSERT INTO Marca(Nome)
Values ('BMW')


INSERT INTO Marca(Nome)
Values ('Ferrari')

INSERT INTO Marca(Nome)
Values ('Fiat')

INSERT INTO Marca(Nome)
Values ('Mercedes')

INSERT INTO Cliente(Nome,Cpf)
VALUES ('Chris Bumstead','0000123323')

INSERT INTO Cliente(Nome,Cpf)
VALUES ('Alanzoka','0034rt3323')

INSERT INTO Cliente(Nome,Cpf)
VALUES ('Rafael','m3456567688')

INSERT INTO Modelo(Nome)
VALUES ('gtx')

INSERT INTO Modelo(Nome)
VALUES ('jk')

INSERT INTO Modelo(Nome)
VALUES ('spider')

INSERT INTO Modelo(Nome)
VALUES ('xj')

INSERT INTO Veiculo(Placa,idMarca,IdModelo,IdEmpresa)
VALUES('wir123','2','3','4')

INSERT INTO Veiculo(Placa,idMarca,IdModelo,IdEmpresa)
VALUES('w34tvnn3','3','2','1')


INSERT INTO Veiculo(Placa,idMarca,IdModelo,IdEmpresa)
VALUES('mrn8v98','1','1','2')

INSERT INTO Veiculo(Placa,idMarca,IdModelo,IdEmpresa)
VALUES('k45668','4','3','1')

INSERT INTO Aluguel (IdVeiculo,IdCliente,Valor,DataRetirada,DataDevolucao)
values('1','2','10000.00','10/04/2024','12/04/2024' )

INSERT INTO Aluguel (IdVeiculo,IdCliente)
values('2','3')

select * from Veiculo

select* from Cliente

select * from Marca

select * from Empresa

select * from Modelo

select * from Aluguel



SELECT
Nome,DataRetirada,DataDevolucao,Modelo.Modelo

FROM
Veiculo inner join Aluguel on Aluguel.IdVeiculo = Veiculo.IdVeiculo
inner join Cliente on Aluguel.IdCliente = Cliente.IdCliente
inner join Modelo on Veiculo.IdModelo = Modelo.IdModelo




SELECT
Nome,DataRetirada,DataDevolucao,Modelo.Modelo

FROM
Veiculo inner join Aluguel on Aluguel.IdVeiculo = Veiculo.IdVeiculo
inner join Cliente on Aluguel.IdCliente = Cliente.IdCliente
inner join Modelo on Veiculo.IdModelo = Modelo.IdModelo
where
Cliente.Nome like 'Rafael'







select 
Cliente.Nome where IdCliente = '1'

from
Cliente Left join Aluguel on Aluguel.IdCliente = Cliente.IdCliente

/*- listar todos os alugueis mostrando as datas de início e fim, o nome do cliente que alugou e nome do modelo do carro
/*- listar os alugueis de um determinado cliente mostrando seu nome, as datas de início e fim e o nome do modelo do carro

/*SELECT
Nome,Endereco,CNH
FROM
Pessoa right join Email on Pessoa.idPessoa = Email.idEmail



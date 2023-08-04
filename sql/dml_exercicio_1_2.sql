USE Exercicio_1_2;

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

INSERT INTO Aluguel (IdVeiculo,IdCliente)
values('1','1')

INSERT INTO Aluguel (IdVeiculo,IdCliente)
values('2','3')

select * from Veiculo

select* from Cliente

select * from Marca

select * from Empresa

select * from Modelo

select * from Aluguel


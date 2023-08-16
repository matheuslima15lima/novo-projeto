--DQL
--CONSULTA DE DADOS
--Criar script que exiba os seguintes dados:

-- Id Consulta
-- Data da Consulta
-- Horario da Consulta
-- Nome da Clinica
--Nome do Paciente
-- Nome do Medico
-- Especialidade do Medico
-- CRM
-- Prontuário ou Descricao
-- FeedBack(Comentario da consulta)

--Criar função para retornar os médicos de uma determinada especialidade

/*Criar procedure para retornar a idade de um determinado usuário específico*/

SELECT 
Consulta.IdConsulta,
Consulta.DataAgendamento,
Clinica.RazaoSocial,
UsuarioPaciente.Nome AS NomeP,
UsuarioMedico.Nome AS NomeM,
Paciente.IdUsuario,
Medico.IdUsuario,
--Medico.IdEspecialidade,    coloquei somente a especialidade e nao o id
Medico.CRM,
Consulta.Descricao,
Comentario.Descricao,
Especialidade.Titulo

from Consulta

INNER JOIN Medico ON Consulta.IdMedico = Medico.IdMedico
INNER JOIN Usuario AS UsuarioMedico ON Medico.IdUsuario = UsuarioMedico.IdUsuario

INNER JOIN Especialidade ON Medico.IdEspecialidade = Especialidade.IdEspecialidade


INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.IdPaciente
INNER JOIN Usuario AS UsuarioPaciente ON Paciente.IdUsuario = UsuarioPaciente.IdUsuario

INNER JOIN Clinica ON Medico.IdClinica = Clinica.IdClinica

INNER JOIN Comentario ON Consulta.IdConsulta = Comentario.IdConsulta

SELECT
Medico.IdMedico
from Medico



WHERE
Medico.IdEspecialidade Like '4'





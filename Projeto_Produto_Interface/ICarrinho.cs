using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto_Interface
{
    public interface ICarrinho
    {
        // regras do contrato
        // metodos que deverao aqui ser declarados apenas
        // CRUD : Create, Read, Update, Delete
        
        // padrao chamada de metodo
        // tipo nome(parametros)

        // Create

        void Adicionar(Produto _produto);

        // Read
        void Listar();

        // update
        void Atualizar(int _codigo, Produto _produto);

        // Delete
        void Remover(Produto _produto);
    }
}
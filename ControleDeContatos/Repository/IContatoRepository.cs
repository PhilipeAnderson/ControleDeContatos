using ControleDeContatos.Models;
using System.Collections.Generic;

namespace ControleDeContatos.Repository
{
    public interface IContatoRepository
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);


    }
}

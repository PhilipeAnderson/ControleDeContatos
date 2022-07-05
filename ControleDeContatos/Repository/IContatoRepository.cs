﻿using ControleDeContatos.Models;
using System.Collections.Generic;

namespace ControleDeContatos.Repository
{
    public interface IContatoRepository
    {
        ContatoModel ListarPorId(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);


    }
}

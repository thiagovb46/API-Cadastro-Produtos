﻿using Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CasosDeUso.Produtos
{
    public interface IListarProdutos
    {
        public IEnumerable<ProdutoViewModelOutput> ListarTodos();
    }
}
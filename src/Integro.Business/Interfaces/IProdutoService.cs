using Integro.Business.Models;
using System;
using System.Threading.Tasks;

namespace Integro.Business.Interfaces
{
    public interface IProdutoService
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}

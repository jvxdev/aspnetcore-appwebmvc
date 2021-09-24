using Integro.Business.Models;
using System;
using System.Threading.Tasks;

namespace Integro.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}

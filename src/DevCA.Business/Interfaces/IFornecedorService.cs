using DevCA.Business.Models;
using System;
using System.Threading.Tasks;

namespace DevCA.Business.Interfaces
{
    public interface IFornecedorService : IDisposable
    {
        Task<bool> Adicionar(Fornecedor fornecedor);

        Task<bool> Atualizar(Fornecedor fornecedor);

        Task<bool> Remover(Guid id);

        Task AtualizarEndereco(Endereco endereco);
    }
}

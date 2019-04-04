using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IProdutoService:IServicesBase<Produto>
    {
        IEnumerable<Produto> BuscarProdutoPorNome(string nome);
    }
}

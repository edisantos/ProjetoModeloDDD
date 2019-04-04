using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>,IProdutoRepository
    {
        public IEnumerable<Produto> buscarPorNome(string nome)
        {
            return db.Produto.Where(p => p.Nome == nome);
        }
    }
}

using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

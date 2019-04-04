using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>,IProdutoService
    {
        private readonly IProdutoRepository _produtorepository;

        public ProdutoService(IProdutoRepository produtorepository)
            :base(produtorepository)
        {
            _produtorepository = produtorepository;
        }

        public IEnumerable<Produto> BuscarProdutoPorNome(string nome)
        {
            return _produtorepository.buscarPorNome(nome);
        }
    }
}

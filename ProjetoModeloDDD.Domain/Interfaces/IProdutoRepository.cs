using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Interfaces
{
    public interface IProdutoRepository:IRepositoryBase<Produto>
    {
        IEnumerable<Produto> buscarPorNome(string nome);//Aqui criamos um metodo especifico para buscar por nome
    }
}

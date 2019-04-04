using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;

namespace infra.Data.Repositories
{
    public class ClienteRepository:RepositoryBase<Cliente>,IClienteRepository
    {
    }
}

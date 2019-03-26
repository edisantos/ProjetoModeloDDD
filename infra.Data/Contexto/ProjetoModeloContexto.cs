using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infra.Data.Contexto
{
    public class ProjetoModeloContexto : DbContext
    {
        public ProjetoModeloContexto()
            : base("ConexaoDbStr")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); // Para não pluraziar as tabelas
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); //Para nao deletar em cascata de muitos para muitos
           modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();//para nao deletar em cascate de um para um

            //Aqui forço o entity a usar chave primaria.
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
        }

        public override int SaveChanges()
        {
            foreach(var entry in ChangeTracker.Entries().Where(entry => entry.GetType().GetProperty("DataCadastro") != null))
            { 
                if(entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}

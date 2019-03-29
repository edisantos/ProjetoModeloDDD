using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace infra.Data.EntityConfig
{
    class ProdutoConfiguration:EntityTypeConfiguration<Produto>
    {
        //precisamos criar um construtor
        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId);
            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Valor)
                .IsRequired();

            //Aqui setamos nossa chave estrangeira
            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);
        }
    }
}

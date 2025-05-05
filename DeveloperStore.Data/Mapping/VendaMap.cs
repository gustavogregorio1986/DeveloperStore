using DeveloperStore.Dominio.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperStore.Data.Mapping
{
    public class VendaMap : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.ToTable("tb_Venda");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.NumeroVenda)
                .IsRequired()
                .HasColumnType("INT");

            builder.Property(x => x.DataTotalVenda)
                .IsRequired()
                .HasColumnType("DATETIME");

            builder.Property(x => x.Cliente)
                .IsRequired()
                .HasColumnType("varchar(40)");

            builder.Property(x => x.Produto)
                .IsRequired()
                .HasColumnType("varchar(40)");

            builder.Property(x => x.ValorTotalVenda)
                .IsRequired()
                .HasColumnType("decimal(10, 5)");

            builder.Property(x => x.FilialVenda)
                .IsRequired()
                .HasColumnType("varchar(40)");

            builder.Property(x => x.Produto)
                .IsRequired()
                .HasColumnType("varchar(40)");

            builder.Property(x => x.PrecoUnitario)
                .IsRequired()
                .HasColumnType("decimal(10,5)");

            builder.Property(x => x.Quantidade)
                .IsRequired()
                .HasColumnType("INT");

            builder.Property(x => x.Desconto)
                .IsRequired()
                .HasColumnType("double(10, 2)");

            builder.Property(x => x.Status)
                .IsRequired()
                .HasColumnType("INT");
        }
    }
}

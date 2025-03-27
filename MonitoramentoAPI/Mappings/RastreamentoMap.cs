using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoramentoAPI.Infra.Mappings
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MonitoramentoAPI.Domain.Entities;

    public class RastreamentoMap : IEntityTypeConfiguration<Rastreamento>
    {
        public void Configure(EntityTypeBuilder<Rastreamento> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Id)
            .ValueGeneratedOnAdd();

            builder.Property(r => r.DataAnalise)
                .IsRequired();

            builder.Property(r => r.CurvasOk)
                .IsRequired();
         
            // Associação com Funcionario 
            builder.HasOne(r => r.Funcionario)
                .WithMany(f => f.Rastreamentos)
                .HasForeignKey(r => r.FuncionarioId);
        }
    }

}

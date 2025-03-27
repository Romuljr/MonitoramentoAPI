using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonitoramentoAPI.Domain.Entities;

namespace MonitoramentoAPI.Infra.Mappings
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Nome)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(f => f.Cargo)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(f => f.Email)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(f => f.Senha)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(f => f.Departamento)
                .HasMaxLength(100)
                .IsRequired();

            // Armazena o enum Permissao como int no banco de dados
            builder.Property(f => f.PermissaoRastreamento)
                .HasConversion<int>()
                .IsRequired();

            builder.Property(f => f.DataCriacao)
                .IsRequired();

            builder.Property(f => f.DataAtualizacao)
                .IsRequired();

            // Relacionamento 1:N com Rastreamento 
            builder.HasMany(f => f.Rastreamentos)
                .WithOne(r => r.Funcionario)
                .HasForeignKey(r => r.FuncionarioId);
        }
    }
}

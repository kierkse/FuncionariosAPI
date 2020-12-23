using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FuncionariosAPI.Domain.Entities;

namespace FuncionariosAPI.Infra.Data.Mapping
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired();
            
            builder
                .HasMany(prop => prop.Subordinados)
                .WithOne();

            builder
                .HasOne(prop => prop.Gerente)
                .WithMany(prop => prop.Subordinados)
                .HasForeignKey(prop => prop.GerenteId);
        }
    }
}
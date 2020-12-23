using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FuncionariosAPI.Domain.Entities;
using FuncionariosAPI.Infra.Data.Mapping;

namespace FuncionariosAPI.Infra.Data.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost;Database=DefaultDb;uid=sa;password=admin123;Integrated Security=True;",
                builder => builder.EnableRetryOnFailure());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Funcionario>(new FuncionarioMap().Configure);

            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys());

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.SetNull;
        }
    }
}
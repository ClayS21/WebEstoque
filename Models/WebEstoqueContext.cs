using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebEstoque.Models
{
    public class WebEstoqueContext : DbContext
    {
        public DbSet<CategoriaModel> Categorias { get; set; }

        public WebEstoqueContext(DbContextOptions<WebEstoqueContext> options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriaModel>().ToTable("Categoria");
        }
    }
}
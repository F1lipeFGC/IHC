using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Validacao_Form.Models;

namespace webIHC.Data
{
    public class webIHCContext : DbContext
    {
        public webIHCContext (DbContextOptions<webIHCContext> options)
            : base(options)
        {
        }

        public DbSet<Validacao_Form.Models.Denuncia> Denuncia { get; set; } = default!;
        public DbSet<Validacao_Form.Models.Estabelecimento> Estabelecimento { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estabelecimento>()
                .HasKey(
                p=> new { p.CnpjBasico, p.CnpjOrdem, p.CnpjDv});
        }
    }
}

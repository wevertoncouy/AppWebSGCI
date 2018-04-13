using Microsoft.EntityFrameworkCore;
using SGCI.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCI.Infrastructure.Data
{
    public class GestaoCarteiraContext : DbContext
    {
        public GestaoCarteiraContext(DbContextOptions<GestaoCarteiraContext> options) : base(options)
        {

        }
        // mapeamento
        public DbSet<Carteira> Carteiras { get; set; }
        public DbSet<Conta> Contas { get; set; }

        ///Fluent Api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carteira>().ToTable("Carteira");
            modelBuilder.Entity<Conta>().ToTable("Conta");

            #region Configurations de Carteira

            modelBuilder.Entity<Carteira>().Property(e => e.Descricao)
               .HasColumnType("varchar(230)")
                .IsRequired();



            #endregion
            
            #region Configurations de Conta

            modelBuilder.Entity<Conta>().Property(e => e.Nome)
               .HasColumnType("varchar(150)")
                .IsRequired();
            #endregion


            #region Configurations Menu
            //modelBuilder.Entity<Menu>()
            // .HasMany(x => x.SubMenu)
            // .WithOne()
            // .HasForeignKey(x => x.MenuId);
            #endregion
        }




    }
}

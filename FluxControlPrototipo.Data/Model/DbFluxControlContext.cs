using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FluxControl.Data.Model;

public partial class DbFluxControlContext : DbContext
{
    public DbFluxControlContext()
    {
    }

    public DbFluxControlContext(DbContextOptions<DbFluxControlContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Entrada> Entrada { get; set; }

    public virtual DbSet<Estoque> Estoques { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    public virtual DbSet<Saida> Saida { get; set; }

    public virtual DbSet<TipoProduto> TipoProdutos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=FluxControl;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Entrada>(entity =>
        {
            entity.HasKey(e => e.IdEntradaProduto).HasName("PK__Entrada__7143DE393C722B4B");

            entity.Property(e => e.IdEntradaProduto).HasColumnName("idEntradaProduto");
            entity.Property(e => e.DataEntrada).HasColumnType("datetime");

           
            entity.Property(e => e.DescricaoEntrada)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ProdutoIdProduto).HasColumnName("Produto_idProduto");

            entity.HasOne(d => d.ProdutoIdProdutoNavigation).WithMany(p => p.Entrada)
                .HasForeignKey(d => d.ProdutoIdProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Entrada_Produto");
        });

        modelBuilder.Entity<Estoque>(entity =>
        {
            entity.HasKey(e => e.idEstoque).HasName("PK__Estoque__F90B4083C23E7389");

            entity.ToTable("Estoque");

            entity.Property(e => e.idEstoque).HasColumnName("idEstoque");
            entity.Property(e => e.DataValidadeEstoque).HasColumnType("datetime");
            entity.Property(e => e.Descricao)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProdutoIdProduto).HasColumnName("Produto_idProduto");

            entity.HasOne(d => d.ProdutoIdProdutoNavigation).WithMany(p => p.Estoques)
                .HasForeignKey(d => d.ProdutoIdProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Estoque_Produto");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.IdProduto).HasName("PK__Produto__5EEDF7C30A143479");

            entity.ToTable("Produto");

            entity.Property(e => e.IdProduto).HasColumnName("idProduto");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoProdutoIdTipoProduto).HasColumnName("TipoProduto_idTipoProduto");

            entity.HasOne(d => d.TipoProdutoIdTipoProdutoNavigation).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.TipoProdutoIdTipoProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Produto_TipoProduto");
        });

        modelBuilder.Entity<Saida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Saida__3214EC07F1429F42");

            entity.Property(e => e.DataSaida).HasColumnType("datetime");
            entity.Property(e => e.ProdutoIdProduto).HasColumnName("Produto_idProduto");

            entity.HasOne(d => d.ProdutoIdProdutoNavigation).WithMany(p => p.Saida)
                .HasForeignKey(d => d.ProdutoIdProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Saida_Produto");
        });

        modelBuilder.Entity<TipoProduto>(entity =>
        {
            entity.HasKey(e => e.IdTipoProduto).HasName("PK__TipoProd__DE38B032C6715DDC");

            entity.ToTable("TipoProduto");

            entity.Property(e => e.IdTipoProduto).HasColumnName("idTipoProduto");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__645723A60FEC11E9");

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Senha)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

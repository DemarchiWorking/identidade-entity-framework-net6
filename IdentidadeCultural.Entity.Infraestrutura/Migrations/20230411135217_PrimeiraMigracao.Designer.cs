﻿// <auto-generated />
using System;
using IdentidadeCultural.Entity.Infraestrutura;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IdentidadeCultural.Entity.Infraestrutura.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230411135217_PrimeiraMigracao")]
    partial class PrimeiraMigracao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IdentidadeCultural.Entity.Dominio.Model.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Criacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<Guid?>("Usuario_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("Id")
                        .HasName("ProdutoId");

                    b.HasIndex("Usuario_Id");

                    b.ToTable("Produtos", (string)null);
                });

            modelBuilder.Entity("IdentidadeCultural.Entity.Dominio.Model.ServicoTrabalho", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Criacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<Guid?>("Usuario_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id")
                        .HasName("ServicoId");

                    b.HasIndex("Usuario_Id");

                    b.ToTable("Servicos", (string)null);
                });

            modelBuilder.Entity("IdentidadeCultural.Entity.Dominio.Model.Usuario", b =>
                {
                    b.Property<Guid?>("Usuario_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Criacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Usuario_Id")
                        .HasName("UsuarioId");

                    b.ToTable("Usuarios", (string)null);
                });

            modelBuilder.Entity("IdentidadeCultural.Entity.Dominio.Model.Produto", b =>
                {
                    b.HasOne("IdentidadeCultural.Entity.Dominio.Model.Usuario", "Usuario")
                        .WithMany("Produtos")
                        .HasForeignKey("Usuario_Id");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("IdentidadeCultural.Entity.Dominio.Model.ServicoTrabalho", b =>
                {
                    b.HasOne("IdentidadeCultural.Entity.Dominio.Model.Usuario", "Usuario")
                        .WithMany("Servicos")
                        .HasForeignKey("Usuario_Id");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("IdentidadeCultural.Entity.Dominio.Model.Usuario", b =>
                {
                    b.Navigation("Produtos");

                    b.Navigation("Servicos");
                });
#pragma warning restore 612, 618
        }
    }
}
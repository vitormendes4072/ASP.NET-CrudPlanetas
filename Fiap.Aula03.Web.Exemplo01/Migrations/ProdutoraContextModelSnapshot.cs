﻿// <auto-generated />
using System;
using Fiap.Aula03.Web.Exemplo01.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fiap.Aula03.Web.Exemplo01.Migrations
{
    [DbContext(typeof(ProdutoraContext))]
    partial class ProdutoraContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fiap.Aula03.Web.Exemplo01.Models.Musica", b =>
                {
                    b.Property<int>("MusicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("date")
                        .HasColumnName("Dt_Lancamento");

                    b.Property<float?>("Duracao")
                        .HasColumnType("real");

                    b.Property<bool>("Explicita")
                        .HasColumnType("bit");

                    b.Property<int?>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("MusicaId");

                    b.ToTable("Tbl_Musica");
                });
#pragma warning restore 612, 618
        }
    }
}

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

            modelBuilder.Entity("Fiap.Aula03.Web.Exemplo01.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("date")
                        .HasColumnName("Dt_Nascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("AlbumId");

                    b.ToTable("Tbl_Album");
                });

            modelBuilder.Entity("Fiap.Aula03.Web.Exemplo01.Models.Artista", b =>
                {
                    b.Property<int>("ArtistaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("date")
                        .HasColumnName("Dt_Nascimento");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<int?>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("ArtistaId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Tbl_Artista");
                });

            modelBuilder.Entity("Fiap.Aula03.Web.Exemplo01.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EnderecoId");

                    b.ToTable("Tbl_Endereco");
                });

            modelBuilder.Entity("Fiap.Aula03.Web.Exemplo01.Models.Musica", b =>
                {
                    b.Property<int>("MusicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlbumId")
                        .HasColumnType("int");

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

                    b.HasIndex("AlbumId");

                    b.ToTable("Tbl_Musica");
                });

            modelBuilder.Entity("Fiap.Aula03.Web.Exemplo01.Models.MusicaArtista", b =>
                {
                    b.Property<int>("ArtistaId")
                        .HasColumnType("int");

                    b.Property<int>("MusicaId")
                        .HasColumnType("int");

                    b.HasKey("ArtistaId", "MusicaId");

                    b.HasIndex("MusicaId");

                    b.ToTable("Tbl_Musica_Artista");
                });

            modelBuilder.Entity("Fiap.Aula03.Web.Exemplo01.Models.Artista", b =>
                {
                    b.HasOne("Fiap.Aula03.Web.Exemplo01.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Fiap.Aula03.Web.Exemplo01.Models.Musica", b =>
                {
                    b.HasOne("Fiap.Aula03.Web.Exemplo01.Models.Album", "Album")
                        .WithMany("Musicas")
                        .HasForeignKey("AlbumId");

                    b.Navigation("Album");
                });

            modelBuilder.Entity("Fiap.Aula03.Web.Exemplo01.Models.MusicaArtista", b =>
                {
                    b.HasOne("Fiap.Aula03.Web.Exemplo01.Models.Artista", "Artista")
                        .WithMany("MusicaArtistas")
                        .HasForeignKey("ArtistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fiap.Aula03.Web.Exemplo01.Models.Musica", "Musica")
                        .WithMany("MusicaArtistas")
                        .HasForeignKey("MusicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artista");

                    b.Navigation("Musica");
                });

            modelBuilder.Entity("Fiap.Aula03.Web.Exemplo01.Models.Album", b =>
                {
                    b.Navigation("Musicas");
                });

            modelBuilder.Entity("Fiap.Aula03.Web.Exemplo01.Models.Artista", b =>
                {
                    b.Navigation("MusicaArtistas");
                });

            modelBuilder.Entity("Fiap.Aula03.Web.Exemplo01.Models.Musica", b =>
                {
                    b.Navigation("MusicaArtistas");
                });
#pragma warning restore 612, 618
        }
    }
}

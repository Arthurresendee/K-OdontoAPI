﻿// <auto-generated />
using System;
using DRAKaysaResende.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DRAKaysa.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240904140221_alterando o campo número para string")]
    partial class alterandoocamponúmeroparastring
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DRAKaysa.Models.UsuarioDoSistema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AcessoDeUsuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("AcessoDeUsuario");

                    b.Property<string>("NomeCompleto")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar")
                        .HasColumnName("NomeCompleto");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Senha");

                    b.Property<int?>("TipoDeSexo")
                        .HasColumnType("INT")
                        .HasColumnName("TipoDeSexo");

                    b.Property<int?>("TipoDeUsuario")
                        .HasColumnType("INT")
                        .HasColumnName("TipoDeUsuario");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "AcessoDeUsuario" }, "IX_UsuarioDoSistema_AcessoDeUsuario")
                        .IsUnique();

                    b.ToTable("UsuariosDoSistema", (string)null);
                });

            modelBuilder.Entity("DRAKaysaResende.Models.Dentista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar")
                        .HasDefaultValue("00000000000")
                        .HasColumnName("CPF");

                    b.Property<DateTime?>("DataDeNascimento")
                        .HasColumnType("SMALLDATETIME")
                        .HasColumnName("DataDeNascimento");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Email");

                    b.Property<string>("Especializacao")
                        .HasColumnType("TEXT")
                        .HasColumnName("Especialização");

                    b.Property<int>("IdEndereco")
                        .HasColumnType("INT")
                        .HasColumnName("IdEndereco");

                    b.Property<int?>("Idade")
                        .HasColumnType("INT")
                        .HasColumnName("Idade");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Nome");

                    b.Property<string>("NumeroDeRegistro")
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar")
                        .HasColumnName("NumeroDeRegistro");

                    b.Property<string>("NumeroDeTelefone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar")
                        .HasColumnName("NumeroDeTelefone");

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar")
                        .HasColumnName("SobreNome");

                    b.HasKey("Id");

                    b.HasIndex("IdEndereco");

                    b.HasIndex(new[] { "Id" }, "IX_dentista_CPF")
                        .IsUnique();

                    b.ToTable("Dentistas", (string)null);
                });

            modelBuilder.Entity("DRAKaysaResende.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Bairro");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar")
                        .HasColumnName("CEP");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Cidade");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Descricao");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Estado");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Numero");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Rua");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CEP" }, "IX_Endereco_CEP");

                    b.ToTable("Enderecos", (string)null);
                });

            modelBuilder.Entity("DRAKaysaResende.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar")
                        .HasDefaultValue("00000000000")
                        .HasColumnName("CPF");

                    b.Property<DateTime?>("DataDeAniversario")
                        .HasColumnType("SMALLDATETIME")
                        .HasColumnName("DataDeAniversario");

                    b.Property<string>("Email")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Email");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<int?>("IdEndereco")
                        .HasColumnType("int");

                    b.Property<int?>("Idade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasDefaultValue(18)
                        .HasColumnName("Idade");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("Nome");

                    b.Property<string>("NumeroDeTelefone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar")
                        .HasColumnName("NumeroDeTelefone");

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("SobreNome");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Pacientes", (string)null);
                });

            modelBuilder.Entity("DRAKaysaResende.Models.PacientePlano", b =>
                {
                    b.Property<int>("IdPlano")
                        .HasColumnType("int");

                    b.Property<int>("IdPaciente")
                        .HasColumnType("int");

                    b.Property<bool>("PlanoAtivo")
                        .HasColumnType("BIT")
                        .HasColumnName("PlanoAtivo");

                    b.HasKey("IdPlano", "IdPaciente");

                    b.HasIndex("IdPaciente");

                    b.ToTable("PacientePlanos", (string)null);
                });

            modelBuilder.Entity("DRAKaysaResende.Models.PacienteProcedimento", b =>
                {
                    b.Property<int>("IdPaciente")
                        .HasColumnType("int");

                    b.Property<int>("IdProcedimento")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataProcedimento")
                        .HasColumnType("SMALLDATETIME")
                        .HasColumnName("DataProcedimento");

                    b.Property<bool>("ProcedimentoRealizado")
                        .HasColumnType("bit");

                    b.HasKey("IdPaciente", "IdProcedimento");

                    b.HasIndex("IdProcedimento");

                    b.HasIndex(new[] { "ProcedimentoRealizado" }, "IX_PacienteProcedimento_ProcedimentoRealizado")
                        .IsUnique();

                    b.ToTable("PacienteProcedimentos", (string)null);
                });

            modelBuilder.Entity("DRAKaysaResende.Models.Plano", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Coberturas")
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("Coberturas");

                    b.Property<DateTime>("DataFinal")
                        .HasColumnType("DATETIME")
                        .HasColumnName("DataFinal");

                    b.Property<DateTime>("DataInicial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME")
                        .HasDefaultValue(new DateTime(2024, 9, 4, 11, 2, 21, 587, DateTimeKind.Local).AddTicks(7167))
                        .HasColumnName("DataInicial");

                    b.Property<string>("Descricao")
                        .HasMaxLength(300)
                        .HasColumnType("varchar")
                        .HasColumnName("Descricao");

                    b.Property<int>("TipoDePlano")
                        .HasColumnType("INT")
                        .HasColumnName("TipoDePlano");

                    b.Property<string>("Titulo")
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Planos", (string)null);
                });

            modelBuilder.Entity("DRAKaysaResende.Models.Procedimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasMaxLength(300)
                        .HasColumnType("varchar")
                        .HasColumnName("Descricao");

                    b.Property<int>("TipoDeProcedimento")
                        .HasColumnType("INT")
                        .HasColumnName("TipoDeProcedimento");

                    b.Property<string>("Titulo")
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Procedimentos", (string)null);
                });

            modelBuilder.Entity("DRAKaysaResende.Models.Dentista", b =>
                {
                    b.HasOne("DRAKaysaResende.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("IdEndereco")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("DRAKaysaResende.Models.Paciente", b =>
                {
                    b.HasOne("DRAKaysaResende.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("DRAKaysaResende.Models.PacientePlano", b =>
                {
                    b.HasOne("DRAKaysaResende.Models.Paciente", "Paciente")
                        .WithMany("PacientePlanos")
                        .HasForeignKey("IdPaciente")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DRAKaysaResende.Models.Plano", "Plano")
                        .WithMany("PacientePlanos")
                        .HasForeignKey("IdPlano")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Paciente");

                    b.Navigation("Plano");
                });

            modelBuilder.Entity("DRAKaysaResende.Models.PacienteProcedimento", b =>
                {
                    b.HasOne("DRAKaysaResende.Models.Paciente", "Paciente")
                        .WithMany("PacienteProcedimentos")
                        .HasForeignKey("IdPaciente")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DRAKaysaResende.Models.Procedimento", "Procedimento")
                        .WithMany("PacienteProcedimentos")
                        .HasForeignKey("IdProcedimento")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Paciente");

                    b.Navigation("Procedimento");
                });

            modelBuilder.Entity("DRAKaysaResende.Models.Paciente", b =>
                {
                    b.Navigation("PacientePlanos");

                    b.Navigation("PacienteProcedimentos");
                });

            modelBuilder.Entity("DRAKaysaResende.Models.Plano", b =>
                {
                    b.Navigation("PacientePlanos");
                });

            modelBuilder.Entity("DRAKaysaResende.Models.Procedimento", b =>
                {
                    b.Navigation("PacienteProcedimentos");
                });
#pragma warning restore 612, 618
        }
    }
}

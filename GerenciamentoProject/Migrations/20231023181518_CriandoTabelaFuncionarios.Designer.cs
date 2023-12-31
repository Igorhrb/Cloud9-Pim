﻿// <auto-generated />
using GerenciamentoProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GerenciamentoProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231023181518_CriandoTabelaFuncionarios")]
    partial class CriandoTabelaFuncionarios
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.23");

            modelBuilder.Entity("GerenciamentoProject.Models.Funcionario", b =>
                {
                    b.Property<int>("Id_funcionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id_funcionario");

                    b.ToTable("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using GerenciamentoProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GerenciamentoProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231027051021_DescontoModelADD")]
    partial class DescontoModelADD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.23");

            modelBuilder.Entity("GerenciamentoProject.Models.DescontosModel", b =>
                {
                    b.Property<int>("Id_Usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Atraso")
                        .HasColumnType("REAL");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Faltas")
                        .HasColumnType("REAL");

                    b.Property<double>("HoraExtra")
                        .HasColumnType("REAL");

                    b.Property<string>("NomeFuncionario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double?>("SalarioBruto")
                        .HasColumnType("REAL");

                    b.HasKey("Id_Usuario");

                    b.ToTable("Descontos");
                });

            modelBuilder.Entity("GerenciamentoProject.Models.FuncionarioModel", b =>
                {
                    b.Property<int>("Id_funcionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CPF")
                        .HasColumnType("REAL");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ContaBanco")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Dtnascimento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Gerente")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PIS")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Salario")
                        .HasColumnType("REAL");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("celular")
                        .HasColumnType("REAL");

                    b.HasKey("Id_funcionario");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("GerenciamentoProject.Models.UsuarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Perfil")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
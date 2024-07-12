﻿// <auto-generated />
using System;
using Controle_Financeiro_Pessoal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Controle_Financeiro_Pessoal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240706135623_eliminadatabelac7recebimentos")]
    partial class eliminadatabelac7recebimentos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Controle_Financeiro_Pessoal.Model.C1Usuario", b =>
                {
                    b.Property<int>("C1ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("C1ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("C1ID"));

                    b.Property<bool>("C1Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("C1Ativo");

                    b.Property<string>("C1Cpf")
                        .HasColumnType("text")
                        .HasColumnName("C1Cpf");

                    b.Property<DateTime>("C1Data_Criacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("C1Data_Criacao");

                    b.Property<string>("C1Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("C1Email");

                    b.Property<string>("C1Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("C1Nome");

                    b.Property<float>("C1Renda_Mensal")
                        .HasColumnType("real")
                        .HasColumnName("C1Renda_Mensal");

                    b.Property<string>("C1Senha")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("C1Senha");

                    b.HasKey("C1ID");

                    b.ToTable("C1Usuario");
                });

            modelBuilder.Entity("Controle_Financeiro_Pessoal.Model.C2Lancamento", b =>
                {
                    b.Property<int>("C2ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("C2ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("C2ID"));

                    b.Property<DateTime>("C2Data_Lancamento")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("C2Data_Lancamento");

                    b.Property<DateTime?>("C2Data_Pagamento")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("C2Data_Pagamento");

                    b.Property<DateTime>("C2Data_Previa_Pagamento")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("C2Data_Previa_Pagamento");

                    b.Property<int>("C2FKC1ID_User")
                        .HasColumnType("integer")
                        .HasColumnName("C2FKC1ID_User");

                    b.Property<int>("C2FKC3ID_Status")
                        .HasColumnType("integer")
                        .HasColumnName("C2FKC3ID_Status");

                    b.Property<int>("C2FKC4ID_Moeda")
                        .HasColumnType("integer")
                        .HasColumnName("C2FKC4ID_Moeda");

                    b.Property<int>("C2FKC5ID_Tipo_Lancamento")
                        .HasColumnType("integer")
                        .HasColumnName("C2FKC5ID_Tipo_Lancamento");

                    b.Property<int>("C2FKC6ID_Conta")
                        .HasColumnType("integer")
                        .HasColumnName("C2FKC6ID_Conta");

                    b.Property<string>("C2Observacao")
                        .HasColumnType("text")
                        .HasColumnName("C2Observacao");

                    b.Property<string>("C2Titulo_Lancamento")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("C2Titulo_Lancamento");

                    b.Property<decimal>("C2Valor")
                        .HasColumnType("numeric")
                        .HasColumnName("C2Valor");

                    b.HasKey("C2ID");

                    b.HasIndex("C2FKC1ID_User");

                    b.HasIndex("C2FKC3ID_Status");

                    b.HasIndex("C2FKC4ID_Moeda");

                    b.HasIndex("C2FKC5ID_Tipo_Lancamento");

                    b.HasIndex("C2FKC6ID_Conta");

                    b.ToTable("C2Lancamento");
                });

            modelBuilder.Entity("Controle_Financeiro_Pessoal.Model.C3Status_Lancamento", b =>
                {
                    b.Property<int>("C3ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("C3ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("C3ID"));

                    b.Property<string>("C3Nome_Status")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("C3Nome_Status");

                    b.HasKey("C3ID");

                    b.ToTable("C3Status_Lancamento");
                });

            modelBuilder.Entity("Controle_Financeiro_Pessoal.Model.C4Moeda", b =>
                {
                    b.Property<int>("C4ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("C4ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("C4ID"));

                    b.Property<string>("C4Nome_Moeda")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("C4Nome_Moeda");

                    b.HasKey("C4ID");

                    b.ToTable("C4Moeda");
                });

            modelBuilder.Entity("Controle_Financeiro_Pessoal.Model.C5Tipo_Lancamento", b =>
                {
                    b.Property<int>("C5ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("C5ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("C5ID"));

                    b.Property<string>("C5Nome_Tipo_Lancamento")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("C5Nome_Tipo_Lancamento");

                    b.HasKey("C5ID");

                    b.ToTable("C5Tipo_Lancamento");
                });

            modelBuilder.Entity("Controle_Financeiro_Pessoal.Model.C6Conta", b =>
                {
                    b.Property<int>("C6Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("C6Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("C6Id"));

                    b.Property<bool>("C6Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("C6Ativo");

                    b.Property<DateTime>("C6Data_Criacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("C6Data_Criacao");

                    b.Property<int>("C6FKC1ID_User")
                        .HasColumnType("integer")
                        .HasColumnName("C6FKC1ID_User");

                    b.Property<string>("C6Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("C6Nome");

                    b.Property<int>("C6Tipo_Conta")
                        .HasColumnType("integer")
                        .HasColumnName("C6Tipo_Conta");

                    b.HasKey("C6Id");

                    b.HasIndex("C6FKC1ID_User");

                    b.ToTable("C6Conta");
                });

            modelBuilder.Entity("Controle_Financeiro_Pessoal.Model.C2Lancamento", b =>
                {
                    b.HasOne("Controle_Financeiro_Pessoal.Model.C1Usuario", "C1Usuario")
                        .WithMany()
                        .HasForeignKey("C2FKC1ID_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Controle_Financeiro_Pessoal.Model.C3Status_Lancamento", "C3Status_Lancamento")
                        .WithMany()
                        .HasForeignKey("C2FKC3ID_Status")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Controle_Financeiro_Pessoal.Model.C4Moeda", "C4Moeda")
                        .WithMany()
                        .HasForeignKey("C2FKC4ID_Moeda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Controle_Financeiro_Pessoal.Model.C5Tipo_Lancamento", "C5Tipo_Lancamento")
                        .WithMany()
                        .HasForeignKey("C2FKC5ID_Tipo_Lancamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Controle_Financeiro_Pessoal.Model.C6Conta", "C6Conta")
                        .WithMany()
                        .HasForeignKey("C2FKC6ID_Conta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("C1Usuario");

                    b.Navigation("C3Status_Lancamento");

                    b.Navigation("C4Moeda");

                    b.Navigation("C5Tipo_Lancamento");

                    b.Navigation("C6Conta");
                });

            modelBuilder.Entity("Controle_Financeiro_Pessoal.Model.C6Conta", b =>
                {
                    b.HasOne("Controle_Financeiro_Pessoal.Model.C1Usuario", "C1Usuario")
                        .WithMany()
                        .HasForeignKey("C6FKC1ID_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("C1Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}

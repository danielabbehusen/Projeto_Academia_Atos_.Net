﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoFinal01.Models;

#nullable disable

namespace ProjetoFinal01.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjetoFinal01.Models.Aluno", b =>
                {
                    b.Property<int>("idAluno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idAluno"), 1L, 1);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CPF");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.Property<int>("professorID")
                        .HasColumnType("int")
                        .HasColumnName("profId");

                    b.HasKey("idAluno");

                    b.HasIndex("professorID");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("ProjetoFinal01.Models.Professor", b =>
                {
                    b.Property<int>("idProfessor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idProfessor"), 1L, 1);

                    b.Property<string>("CREF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREF");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.HasKey("idProfessor");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("ProjetoFinal01.Models.Aluno", b =>
                {
                    b.HasOne("ProjetoFinal01.Models.Professor", "Professor")
                        .WithMany()
                        .HasForeignKey("professorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");
                });
#pragma warning restore 612, 618
        }
    }
}

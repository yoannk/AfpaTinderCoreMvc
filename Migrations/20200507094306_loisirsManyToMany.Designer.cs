﻿// <auto-generated />
using AfpaTinderCoreMvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AfpaTinderCoreMvc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200507094306_loisirsManyToMany")]
    partial class loisirsManyToMany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AfpaTinderCoreMvc.Models.Loisir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Loisirs");
                });

            modelBuilder.Entity("AfpaTinderCoreMvc.Models.Personne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Personnes");
                });

            modelBuilder.Entity("AfpaTinderCoreMvc.Models.PersonneLoisir", b =>
                {
                    b.Property<int>("PersonneId")
                        .HasColumnType("int");

                    b.Property<int>("LoisirId")
                        .HasColumnType("int");

                    b.HasKey("PersonneId", "LoisirId");

                    b.HasIndex("LoisirId");

                    b.ToTable("PersonneLoisirs");
                });

            modelBuilder.Entity("AfpaTinderCoreMvc.Models.PersonneLoisir", b =>
                {
                    b.HasOne("AfpaTinderCoreMvc.Models.Loisir", "Loisir")
                        .WithMany("PersonneLoisirs")
                        .HasForeignKey("LoisirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AfpaTinderCoreMvc.Models.Personne", "Personne")
                        .WithMany("PersonneLoisirs")
                        .HasForeignKey("PersonneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
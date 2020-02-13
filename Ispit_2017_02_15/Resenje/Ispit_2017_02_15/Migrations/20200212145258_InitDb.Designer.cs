﻿// <auto-generated />
using Ispit_2017_02_15.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Ispit_2017_02_15.Migrations
{
    [DbContext(typeof(MojContext))]
    [Migration("20200212145258_InitDb")]
    partial class InitDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ispit_2017_02_15.Models.AkademskaGodina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Opis");

                    b.HasKey("Id");

                    b.ToTable("AkademskaGodina");
                });

            modelBuilder.Entity("Ispit_2017_02_15.Models.Angazovan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AkademskaGodinaId");

                    b.Property<int>("NastavnikId");

                    b.Property<int>("PredmetId");

                    b.HasKey("Id");

                    b.HasIndex("AkademskaGodinaId");

                    b.HasIndex("NastavnikId");

                    b.HasIndex("PredmetId");

                    b.ToTable("Angazovan");
                });

            modelBuilder.Entity("Ispit_2017_02_15.Models.AuthorizationToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IpAddress");

                    b.Property<int>("UserId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AuthorizationTokens");
                });

            modelBuilder.Entity("Ispit_2017_02_15.Models.Nastavnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Nastavnik");
                });

            modelBuilder.Entity("Ispit_2017_02_15.Models.OdrzaniCas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AngazovanId");

                    b.Property<DateTime>("Datum");

                    b.HasKey("Id");

                    b.HasIndex("AngazovanId");

                    b.ToTable("OdrzaniCasovi");
                });

            modelBuilder.Entity("Ispit_2017_02_15.Models.OdrzaniCasDetalji", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BodoviNaCasu");

                    b.Property<int>("OdrzaniCasId");

                    b.Property<bool>("Prisutan");

                    b.Property<int>("SlusaPredmetId");

                    b.HasKey("Id");

                    b.HasIndex("OdrzaniCasId");

                    b.HasIndex("SlusaPredmetId");

                    b.ToTable("OdrzaniCasDetalji");
                });

            modelBuilder.Entity("Ispit_2017_02_15.Models.Predmet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ECTS");

                    b.Property<int>("Godina");

                    b.Property<string>("Naziv");

                    b.Property<int>("Sifra");

                    b.HasKey("Id");

                    b.ToTable("Predmet");
                });

            modelBuilder.Entity("Ispit_2017_02_15.Models.SlusaPredmet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AngazovanId");

                    b.Property<DateTime?>("DatumOcjene");

                    b.Property<int?>("Ocjena");

                    b.Property<int>("UpisGodineId");

                    b.HasKey("Id");

                    b.HasIndex("AngazovanId");

                    b.HasIndex("UpisGodineId");

                    b.ToTable("SlusaPredmet");
                });

            modelBuilder.Entity("Ispit_2017_02_15.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrojIndeksa");

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.HasKey("Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Ispit_2017_02_15.Models.UpisGodine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AkademskaGodinaId");

                    b.Property<DateTime>("DatumUpisa");

                    b.Property<int>("GodinaStudija");

                    b.Property<int>("PolozioECTS");

                    b.Property<int>("SlusaECTS");

                    b.Property<int>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("AkademskaGodinaId");

                    b.HasIndex("StudentId");

                    b.ToTable("UpisGodine");
                });

            modelBuilder.Entity("Ispit_2017_02_15.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Ispit_2017_02_15.Models.Angazovan", b =>
                {
                    b.HasOne("Ispit_2017_02_15.Models.AkademskaGodina", "AkademskaGodina")
                        .WithMany()
                        .HasForeignKey("AkademskaGodinaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ispit_2017_02_15.Models.Nastavnik", "Nastavnik")
                        .WithMany()
                        .HasForeignKey("NastavnikId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ispit_2017_02_15.Models.Predmet", "Predmet")
                        .WithMany()
                        .HasForeignKey("PredmetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ispit_2017_02_15.Models.AuthorizationToken", b =>
                {
                    b.HasOne("Ispit_2017_02_15.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ispit_2017_02_15.Models.Nastavnik", b =>
                {
                    b.HasOne("Ispit_2017_02_15.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ispit_2017_02_15.Models.OdrzaniCas", b =>
                {
                    b.HasOne("Ispit_2017_02_15.Models.Angazovan", "Angazovan")
                        .WithMany()
                        .HasForeignKey("AngazovanId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ispit_2017_02_15.Models.OdrzaniCasDetalji", b =>
                {
                    b.HasOne("Ispit_2017_02_15.Models.OdrzaniCas", "OdrzaniCas")
                        .WithMany("OdrzaniCasDetaljii")
                        .HasForeignKey("OdrzaniCasId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Ispit_2017_02_15.Models.SlusaPredmet", "SlusaPredmet")
                        .WithMany("Casovi")
                        .HasForeignKey("SlusaPredmetId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Ispit_2017_02_15.Models.SlusaPredmet", b =>
                {
                    b.HasOne("Ispit_2017_02_15.Models.Angazovan", "Angazovan")
                        .WithMany()
                        .HasForeignKey("AngazovanId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ispit_2017_02_15.Models.UpisGodine", "UpisGodine")
                        .WithMany("SlusaPredmete")
                        .HasForeignKey("UpisGodineId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Ispit_2017_02_15.Models.UpisGodine", b =>
                {
                    b.HasOne("Ispit_2017_02_15.Models.AkademskaGodina", "AkademskaGodina")
                        .WithMany()
                        .HasForeignKey("AkademskaGodinaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ispit_2017_02_15.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
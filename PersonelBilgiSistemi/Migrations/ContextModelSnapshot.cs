﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonelBilgiSistemi.Models;

namespace PersonelBilgiSistemi.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PersonelBilgiSistemi.Models.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Kullanıcı")
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("Sifre")
                        .HasColumnType("Varchar(10)");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("PersonelBilgiSistemi.Models.Birim", b =>
                {
                    b.Property<int>("BirimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirimAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BirimId");

                    b.ToTable("Birims");
                });

            modelBuilder.Entity("PersonelBilgiSistemi.Models.Personel", b =>
                {
                    b.Property<int>("PersonelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BirimId")
                        .HasColumnType("int");

                    b.Property<string>("Sehir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonelId");

                    b.HasIndex("BirimId");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("PersonelBilgiSistemi.Models.Personel", b =>
                {
                    b.HasOne("PersonelBilgiSistemi.Models.Birim", "Birim")
                        .WithMany("Personels")
                        .HasForeignKey("BirimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Birim");
                });

            modelBuilder.Entity("PersonelBilgiSistemi.Models.Birim", b =>
                {
                    b.Navigation("Personels");
                });
#pragma warning restore 612, 618
        }
    }
}

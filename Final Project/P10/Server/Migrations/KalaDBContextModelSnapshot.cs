﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using P10.Server.DB;

namespace P10.Server.Migrations
{
    [DbContext(typeof(KalaDBContext))]
    partial class KalaDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("P10.Shared.kala", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("p_category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("p_count")
                        .HasColumnType("integer");

                    b.Property<string>("p_info")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("p_link")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("p_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("p_price")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Kalas");
                });
#pragma warning restore 612, 618
        }
    }
}
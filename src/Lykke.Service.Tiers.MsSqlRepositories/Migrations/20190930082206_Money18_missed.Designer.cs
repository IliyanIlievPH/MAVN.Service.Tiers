﻿// <auto-generated />
using System;
using Lykke.Service.Tiers.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lykke.Service.Tiers.MsSqlRepositories.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190930082206_Money18_missed")]
    partial class Money18_missed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("tiers")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lykke.Service.Tiers.MsSqlRepositories.Entities.CustomerBonusesEntity", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("customer_id");

                    b.Property<Guid>("Id")
                        .HasColumnName("id");

                    b.Property<string>("TotalAwardedBonuses")
                        .IsRequired()
                        .HasColumnName("total_awarded_bonuses");

                    b.HasKey("CustomerId");

                    b.HasAlternateKey("Id");

                    b.ToTable("customer_bonuses");
                });

            modelBuilder.Entity("Lykke.Service.Tiers.MsSqlRepositories.Entities.CustomerTierEntity", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("customer_id");

                    b.Property<string>("SumBonusAwarded")
                        .IsRequired()
                        .HasColumnName("sum_bonus_awarded");

                    b.Property<Guid>("TierId")
                        .HasColumnName("tier_id");

                    b.HasKey("CustomerId");

                    b.HasIndex("TierId");

                    b.ToTable("customer_tiers");
                });

            modelBuilder.Entity("Lykke.Service.Tiers.MsSqlRepositories.Entities.TierEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Threshold")
                        .IsRequired()
                        .HasColumnName("threshold");

                    b.HasKey("Id");

                    b.ToTable("tiers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e5538c22-3f19-489a-8eed-0549b84a47d2"),
                            Name = "Black",
                            Threshold = "0"
                        },
                        new
                        {
                            Id = new Guid("af3804ef-faf2-47b0-b6f6-66100f3bcdd4"),
                            Name = "Silver",
                            Threshold = "100000000000000000000"
                        },
                        new
                        {
                            Id = new Guid("df6e1941-0828-4424-9ed5-451d73139bed"),
                            Name = "Gold",
                            Threshold = "200000000000000000000"
                        },
                        new
                        {
                            Id = new Guid("4c3cd4ce-98eb-487d-bef8-7e0ee3801ecc"),
                            Name = "Platinum",
                            Threshold = "300000000000000000000"
                        });
                });

            modelBuilder.Entity("Lykke.Service.Tiers.MsSqlRepositories.Entities.CustomerTierEntity", b =>
                {
                    b.HasOne("Lykke.Service.Tiers.MsSqlRepositories.Entities.TierEntity")
                        .WithMany()
                        .HasForeignKey("TierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

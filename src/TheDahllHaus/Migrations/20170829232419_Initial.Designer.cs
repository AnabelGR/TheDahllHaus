using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TheDahllHaus.Models;

namespace TheDahllHaus.Migrations
{
    [DbContext(typeof(TheDahllHausDbContext))]
    [Migration("20170829232419_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TheDahllHaus.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TheDahllHaus.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Note");

                    b.Property<string>("Phone");

                    b.Property<string>("State");

                    b.Property<string>("Zip");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("TheDahllHaus.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Price");

                    b.Property<bool>("Sale");

                    b.Property<int>("ShopId");

                    b.Property<string>("Type");

                    b.HasKey("ItemId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ShopId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("TheDahllHaus.Models.Shop", b =>
                {
                    b.Property<int>("ShopId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ShopId");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("TheDahllHaus.Models.Supply", b =>
                {
                    b.Property<int>("SupplyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Amount");

                    b.Property<string>("Color");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Theme");

                    b.Property<string>("Type");

                    b.HasKey("SupplyId");

                    b.ToTable("Supplies");
                });

            modelBuilder.Entity("TheDahllHaus.Models.Item", b =>
                {
                    b.HasOne("TheDahllHaus.Models.Category", "Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TheDahllHaus.Models.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MultipleContext.Sales;
using System;

namespace MultipleContext.Sales.Migrations
{
    [DbContext(typeof(SalesContext))]
    [Migration("20180418162040_AddOrderAddress")]
    partial class AddOrderAddress
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Sales")
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MultipleContext.Sales.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("OrderDate");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("MultipleContext.Sales.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("MultipleContext.Sales.Order", b =>
                {
                    b.OwnsOne("MultipleContext.Sales.Address", "Address", b1 =>
                        {
                            b1.Property<int>("OrderId");

                            b1.Property<string>("City");

                            b1.Property<string>("Street");

                            b1.ToTable("Order","Sales");

                            b1.HasOne("MultipleContext.Sales.Order")
                                .WithOne("Address")
                                .HasForeignKey("MultipleContext.Sales.Address", "OrderId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

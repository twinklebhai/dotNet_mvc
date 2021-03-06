// <auto-generated />
using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ecommerce.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210912164155_SeedingData")]
    partial class SeedingData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ecommerce.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            CustomerId = 1111,
                            CustomerEmail = "alluarjun@gmail.com",
                            CustomerName = "Allu Arjun"
                        },
                        new
                        {
                            CustomerId = 2222,
                            CustomerEmail = "saipallavi@gmail.com",
                            CustomerName = "Sai Pallavi"
                        },
                        new
                        {
                            CustomerId = 3333,
                            CustomerEmail = "keertysuresh@gmail.com",
                            CustomerName = "Keerty Suresh"
                        },
                        new
                        {
                            CustomerId = 4444,
                            CustomerEmail = "dhanush@gmail.com",
                            CustomerName = "Dhanush"
                        });
                });

            modelBuilder.Entity("Ecommerce.Models.Delivery", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("From")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.ToTable("Delivery");

                    b.HasData(
                        new
                        {
                            ItemId = 9999,
                            From = "20-sep",
                            To = "25-sep"
                        },
                        new
                        {
                            ItemId = 8888,
                            From = "20-sep",
                            To = "25-sep"
                        },
                        new
                        {
                            ItemId = 7777,
                            From = "20-sep",
                            To = "25-sep"
                        },
                        new
                        {
                            ItemId = 6666,
                            From = "20-sep",
                            To = "25-sep"
                        },
                        new
                        {
                            ItemId = 1232,
                            From = "22-sep",
                            To = "26-sep"
                        },
                        new
                        {
                            ItemId = 8764,
                            From = "22-sep",
                            To = "26-sep"
                        },
                        new
                        {
                            ItemId = 3745,
                            From = "23-sep",
                            To = "28-sep"
                        },
                        new
                        {
                            ItemId = 9837,
                            From = "23-sep",
                            To = "28-sep"
                        },
                        new
                        {
                            ItemId = 1836,
                            From = "23-sep",
                            To = "28-sep"
                        },
                        new
                        {
                            ItemId = 3646,
                            From = "23-sep",
                            To = "28-sep"
                        },
                        new
                        {
                            ItemId = 7645,
                            From = "24-sep",
                            To = "29-sep"
                        },
                        new
                        {
                            ItemId = 9721,
                            From = "24-sep",
                            To = "29-sep"
                        },
                        new
                        {
                            ItemId = 7878,
                            From = "24-sep",
                            To = "29-sep"
                        });
                });

            modelBuilder.Entity("Ecommerce.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("DirId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            OrderId = 111,
                            CustomerId = 1111,
                            DirId = 0
                        },
                        new
                        {
                            OrderId = 222,
                            CustomerId = 2222,
                            DirId = 0
                        },
                        new
                        {
                            OrderId = 333,
                            CustomerId = 3333,
                            DirId = 0
                        },
                        new
                        {
                            OrderId = 444,
                            CustomerId = 4444,
                            DirId = 0
                        });
                });

            modelBuilder.Entity("Ecommerce.Models.OrderItem", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItem");

                    b.HasData(
                        new
                        {
                            ItemId = 9999,
                            Amount = 1928,
                            OrderId = 111,
                            Status = "InTransit"
                        },
                        new
                        {
                            ItemId = 8888,
                            Amount = 6453,
                            OrderId = 111,
                            Status = "InTransit"
                        },
                        new
                        {
                            ItemId = 7777,
                            Amount = 333,
                            OrderId = 111,
                            Status = "InTransit"
                        },
                        new
                        {
                            ItemId = 6666,
                            Amount = 1111,
                            OrderId = 111,
                            Status = "InTransit"
                        },
                        new
                        {
                            ItemId = 1232,
                            Amount = 8765,
                            OrderId = 222,
                            Status = "InTransit"
                        },
                        new
                        {
                            ItemId = 8764,
                            Amount = 1111,
                            OrderId = 222,
                            Status = "InTransit"
                        },
                        new
                        {
                            ItemId = 3745,
                            Amount = 3425,
                            OrderId = 333,
                            Status = "InTransit"
                        },
                        new
                        {
                            ItemId = 9837,
                            Amount = 1234,
                            OrderId = 333,
                            Status = "InTransit"
                        },
                        new
                        {
                            ItemId = 1836,
                            Amount = 2121,
                            OrderId = 333,
                            Status = "InTransit"
                        },
                        new
                        {
                            ItemId = 3646,
                            Amount = 1456,
                            OrderId = 333,
                            Status = "InTransit"
                        },
                        new
                        {
                            ItemId = 7645,
                            Amount = 7677,
                            OrderId = 444,
                            Status = "InTransit"
                        },
                        new
                        {
                            ItemId = 9721,
                            Amount = 5674,
                            OrderId = 444,
                            Status = "InTransit"
                        },
                        new
                        {
                            ItemId = 7878,
                            Amount = 5547,
                            OrderId = 444,
                            Status = "InTransit"
                        });
                });

            modelBuilder.Entity("Ecommerce.Models.Delivery", b =>
                {
                    b.HasOne("Ecommerce.Models.OrderItem", "OrderItem")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderItem");
                });

            modelBuilder.Entity("Ecommerce.Models.Order", b =>
                {
                    b.HasOne("Ecommerce.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Ecommerce.Models.OrderItem", b =>
                {
                    b.HasOne("Ecommerce.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}

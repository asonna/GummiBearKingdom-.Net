using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GummiBearKingdom.Models;

namespace GummiBearKingdom.Migrations
{
    [DbContext(typeof(GummiBearDbContext))]
    [Migration("20170210183630_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GummiBearKingdom.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("OriginCountry");

                    b.Property<int>("SectionId");

                    b.Property<int>("cost");

                    b.HasKey("ProductId");

                    b.HasIndex("SectionId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("GummiBearKingdom.Models.Section", b =>
                {
                    b.Property<int>("SectionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("SectionId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("GummiBearKingdom.Models.Product", b =>
                {
                    b.HasOne("GummiBearKingdom.Models.Section", "Section")
                        .WithMany("Product")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

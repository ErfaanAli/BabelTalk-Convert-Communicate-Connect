﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Scribe_Factory_Core.Models;

namespace Scribe_Factory_Core.Migrations
{
    [DbContext(typeof(ScribeFactoryContext))]
    [Migration("20220924113644_FirstDBCreation1")]
    partial class FirstDBCreation1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Scribe_Factory_Core.Models.ApplicatioUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("TenantId")
                        .HasColumnType("bigint");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("ApplicatioUsers");
                });

            modelBuilder.Entity("Scribe_Factory_Core.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("TenantId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Scribe_Factory_Core.Models.ProjectFiles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectFiles");
                });

            modelBuilder.Entity("Scribe_Factory_Core.Models.Subcribers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("SubscriptionId")
                        .HasColumnType("int");

                    b.Property<int?>("SubscriptionsId")
                        .HasColumnType("int");

                    b.Property<long>("TenantId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionsId");

                    b.HasIndex("TenantId");

                    b.ToTable("Subcribers");
                });

            modelBuilder.Entity("Scribe_Factory_Core.Models.Subscriptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StripeUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebHookUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("Scribe_Factory_Core.Models.Tenant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("Scribe_Factory_Core.Models.ApplicatioUser", b =>
                {
                    b.HasOne("Scribe_Factory_Core.Models.Tenant", "Tenant")
                        .WithMany("ApplicatioUsers")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("Scribe_Factory_Core.Models.Project", b =>
                {
                    b.HasOne("Scribe_Factory_Core.Models.Tenant", "Tenant")
                        .WithMany("Projects")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("Scribe_Factory_Core.Models.ProjectFiles", b =>
                {
                    b.HasOne("Scribe_Factory_Core.Models.Project", "Project")
                        .WithMany("ProjectFiles")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Scribe_Factory_Core.Models.Subcribers", b =>
                {
                    b.HasOne("Scribe_Factory_Core.Models.Subscriptions", "Subscriptions")
                        .WithMany("Subcribers")
                        .HasForeignKey("SubscriptionsId");

                    b.HasOne("Scribe_Factory_Core.Models.Tenant", "Tenant")
                        .WithMany("Subcribers")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subscriptions");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("Scribe_Factory_Core.Models.Project", b =>
                {
                    b.Navigation("ProjectFiles");
                });

            modelBuilder.Entity("Scribe_Factory_Core.Models.Subscriptions", b =>
                {
                    b.Navigation("Subcribers");
                });

            modelBuilder.Entity("Scribe_Factory_Core.Models.Tenant", b =>
                {
                    b.Navigation("ApplicatioUsers");

                    b.Navigation("Projects");

                    b.Navigation("Subcribers");
                });
#pragma warning restore 612, 618
        }
    }
}

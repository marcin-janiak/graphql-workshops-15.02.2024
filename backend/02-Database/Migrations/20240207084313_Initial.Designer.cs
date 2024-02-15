﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using _02_Database;

#nullable disable

namespace _02_Database.Migrations
{
    [DbContext(typeof(WorkshopsDbContext))]
    [Migration("20240207084313_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GroupUserDevice", b =>
                {
                    b.Property<Guid>("GroupId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserDevicesDeviceId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserDevicesUserId")
                        .HasColumnType("uuid");

                    b.HasKey("GroupId", "UserDevicesDeviceId", "UserDevicesUserId");

                    b.HasIndex("UserDevicesDeviceId", "UserDevicesUserId");

                    b.ToTable("GroupUserDevice");

                    b.HasData(
                        new
                        {
                            GroupId = new Guid("cda99cc6-c678-aef0-ab64-6c4a1d6e5202"),
                            UserDevicesDeviceId = new Guid("66f98c5c-14ac-dd24-bbf8-8dae4db00793"),
                            UserDevicesUserId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad")
                        },
                        new
                        {
                            GroupId = new Guid("cda99cc6-c678-aef0-ab64-6c4a1d6e5202"),
                            UserDevicesDeviceId = new Guid("91f224e3-cb0c-3b9f-599a-2a11704aa833"),
                            UserDevicesUserId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad")
                        },
                        new
                        {
                            GroupId = new Guid("cda99cc6-c678-aef0-ab64-6c4a1d6e5202"),
                            UserDevicesDeviceId = new Guid("55242e0d-0559-bdc0-d674-7a54773f6fdb"),
                            UserDevicesUserId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad")
                        },
                        new
                        {
                            GroupId = new Guid("ee47e90a-d855-bddd-13e3-e960f7c02f0f"),
                            UserDevicesDeviceId = new Guid("5ecbeeec-2e75-254e-61b1-55e8d4eda3bd"),
                            UserDevicesUserId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad")
                        },
                        new
                        {
                            GroupId = new Guid("ee47e90a-d855-bddd-13e3-e960f7c02f0f"),
                            UserDevicesDeviceId = new Guid("264c2e76-e3aa-9112-54bf-90ee23b78f43"),
                            UserDevicesUserId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad")
                        },
                        new
                        {
                            GroupId = new Guid("ee47e90a-d855-bddd-13e3-e960f7c02f0f"),
                            UserDevicesDeviceId = new Guid("66c6d7c7-9a93-928e-8a72-a07a49ef77d7"),
                            UserDevicesUserId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad")
                        },
                        new
                        {
                            GroupId = new Guid("c20453f9-e80f-71f3-60f1-4b0e986acbf9"),
                            UserDevicesDeviceId = new Guid("0527c550-1bc1-efb2-b041-0565e42a3ea4"),
                            UserDevicesUserId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad")
                        },
                        new
                        {
                            GroupId = new Guid("c20453f9-e80f-71f3-60f1-4b0e986acbf9"),
                            UserDevicesDeviceId = new Guid("08991fac-4a35-03c9-be3e-eb82b5f50bb5"),
                            UserDevicesUserId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad")
                        },
                        new
                        {
                            GroupId = new Guid("c20453f9-e80f-71f3-60f1-4b0e986acbf9"),
                            UserDevicesDeviceId = new Guid("1b3bdf5c-ab3f-f233-a231-a953b0110105"),
                            UserDevicesUserId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad")
                        });
                });

            modelBuilder.Entity("_02_Domain.Device", b =>
                {
                    b.Property<Guid>("DeviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("DeviceType")
                        .HasColumnType("integer");

                    b.Property<Guid>("InstallationId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Payload")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("jsonb")
                        .HasDefaultValueSql("'{}'::jsonb");

                    b.HasKey("DeviceId");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            DeviceId = new Guid("66f98c5c-14ac-dd24-bbf8-8dae4db00793"),
                            DeviceType = 1,
                            InstallationId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "mabel.biz",
                            Payload = "{\"$\":\"Switch\",\"Value\":true,\"DeviceId\":\"66f98c5c-14ac-dd24-bbf8-8dae4db00793\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}"
                        },
                        new
                        {
                            DeviceId = new Guid("91f224e3-cb0c-3b9f-599a-2a11704aa833"),
                            DeviceType = 1,
                            InstallationId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "allie.info",
                            Payload = "{\"$\":\"Switch\",\"Value\":true,\"DeviceId\":\"91f224e3-cb0c-3b9f-599a-2a11704aa833\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}"
                        },
                        new
                        {
                            DeviceId = new Guid("55242e0d-0559-bdc0-d674-7a54773f6fdb"),
                            DeviceType = 1,
                            InstallationId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "hailey.com",
                            Payload = "{\"$\":\"Switch\",\"Value\":true,\"DeviceId\":\"55242e0d-0559-bdc0-d674-7a54773f6fdb\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}"
                        },
                        new
                        {
                            DeviceId = new Guid("5ecbeeec-2e75-254e-61b1-55e8d4eda3bd"),
                            DeviceType = 1,
                            InstallationId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "kaelyn.net",
                            Payload = "{\"$\":\"Switch\",\"Value\":true,\"DeviceId\":\"5ecbeeec-2e75-254e-61b1-55e8d4eda3bd\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}"
                        },
                        new
                        {
                            DeviceId = new Guid("264c2e76-e3aa-9112-54bf-90ee23b78f43"),
                            DeviceType = 1,
                            InstallationId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "tiara.biz",
                            Payload = "{\"$\":\"Switch\",\"Value\":true,\"DeviceId\":\"264c2e76-e3aa-9112-54bf-90ee23b78f43\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}"
                        },
                        new
                        {
                            DeviceId = new Guid("66c6d7c7-9a93-928e-8a72-a07a49ef77d7"),
                            DeviceType = 1,
                            InstallationId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "andy.net",
                            Payload = "{\"$\":\"Switch\",\"Value\":true,\"DeviceId\":\"66c6d7c7-9a93-928e-8a72-a07a49ef77d7\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}"
                        },
                        new
                        {
                            DeviceId = new Guid("0527c550-1bc1-efb2-b041-0565e42a3ea4"),
                            DeviceType = 1,
                            InstallationId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "ardella.net",
                            Payload = "{\"$\":\"Switch\",\"Value\":true,\"DeviceId\":\"0527c550-1bc1-efb2-b041-0565e42a3ea4\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}"
                        },
                        new
                        {
                            DeviceId = new Guid("08991fac-4a35-03c9-be3e-eb82b5f50bb5"),
                            DeviceType = 1,
                            InstallationId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "kris.name",
                            Payload = "{\"$\":\"Switch\",\"Value\":true,\"DeviceId\":\"08991fac-4a35-03c9-be3e-eb82b5f50bb5\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}"
                        },
                        new
                        {
                            DeviceId = new Guid("1b3bdf5c-ab3f-f233-a231-a953b0110105"),
                            DeviceType = 1,
                            InstallationId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "candido.name",
                            Payload = "{\"$\":\"Switch\",\"Value\":true,\"DeviceId\":\"1b3bdf5c-ab3f-f233-a231-a953b0110105\",\"InstallationId\":\"00000000-0000-0000-0000-000000000000\",\"SoftwareVersion\":\"0.0.1\"}"
                        });
                });

            modelBuilder.Entity("_02_Domain.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cda99cc6-c678-aef0-ab64-6c4a1d6e5202"),
                            Name = "Cocos (Keeling) Islands",
                            OwnerId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad")
                        },
                        new
                        {
                            Id = new Guid("ee47e90a-d855-bddd-13e3-e960f7c02f0f"),
                            Name = "Czech Republic",
                            OwnerId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad")
                        },
                        new
                        {
                            Id = new Guid("c20453f9-e80f-71f3-60f1-4b0e986acbf9"),
                            Name = "Peru",
                            OwnerId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad")
                        });
                });

            modelBuilder.Entity("_02_Domain.UserDevice", b =>
                {
                    b.Property<Guid>("DeviceId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("DeviceId", "UserId");

                    b.ToTable("UserDevices");

                    b.HasData(
                        new
                        {
                            DeviceId = new Guid("66f98c5c-14ac-dd24-bbf8-8dae4db00793"),
                            UserId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"),
                            Alias = "mabel.biz"
                        },
                        new
                        {
                            DeviceId = new Guid("91f224e3-cb0c-3b9f-599a-2a11704aa833"),
                            UserId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"),
                            Alias = "allie.info"
                        },
                        new
                        {
                            DeviceId = new Guid("55242e0d-0559-bdc0-d674-7a54773f6fdb"),
                            UserId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"),
                            Alias = "hailey.com"
                        },
                        new
                        {
                            DeviceId = new Guid("5ecbeeec-2e75-254e-61b1-55e8d4eda3bd"),
                            UserId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"),
                            Alias = "kaelyn.net"
                        },
                        new
                        {
                            DeviceId = new Guid("264c2e76-e3aa-9112-54bf-90ee23b78f43"),
                            UserId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"),
                            Alias = "tiara.biz"
                        },
                        new
                        {
                            DeviceId = new Guid("66c6d7c7-9a93-928e-8a72-a07a49ef77d7"),
                            UserId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"),
                            Alias = "andy.net"
                        },
                        new
                        {
                            DeviceId = new Guid("0527c550-1bc1-efb2-b041-0565e42a3ea4"),
                            UserId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"),
                            Alias = "ardella.net"
                        },
                        new
                        {
                            DeviceId = new Guid("08991fac-4a35-03c9-be3e-eb82b5f50bb5"),
                            UserId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"),
                            Alias = "kris.name"
                        },
                        new
                        {
                            DeviceId = new Guid("1b3bdf5c-ab3f-f233-a231-a953b0110105"),
                            UserId = new Guid("f2e9e523-e78f-436d-b7b1-7baa330c4dad"),
                            Alias = "candido.name"
                        });
                });

            modelBuilder.Entity("GroupUserDevice", b =>
                {
                    b.HasOne("_02_Domain.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_02_Domain.UserDevice", null)
                        .WithMany()
                        .HasForeignKey("UserDevicesDeviceId", "UserDevicesUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("_02_Domain.UserDevice", b =>
                {
                    b.HasOne("_02_Domain.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SWProject;

#nullable disable

namespace SWProject.Migrations
{
    [DbContext(typeof(SWContext))]
    [Migration("20220203102727_Initv.2")]
    partial class Initv2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SWProject.AssaultShip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BaseFleetId")
                        .HasColumnType("int");

                    b.Property<int?>("WeaponryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BaseFleetId");

                    b.HasIndex("WeaponryId");

                    b.ToTable("AssaultShipes");
                });

            modelBuilder.Entity("SWProject.Base", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AmmoSupplyId")
                        .HasColumnType("int");

                    b.Property<int>("AttachedFleetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AmmoSupplyId");

                    b.HasIndex("AttachedFleetId");

                    b.ToTable("Base");
                });

            modelBuilder.Entity("SWProject.BaseFleet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("VenatorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VenatorId");

                    b.ToTable("Fleets");
                });

            modelBuilder.Entity("SWProject.Clone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AssaultShipId")
                        .HasColumnType("int");

                    b.Property<int?>("BaseId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Equipment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LegionId")
                        .HasColumnType("int");

                    b.Property<int?>("LegionId1")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StarDestroyerId")
                        .HasColumnType("int");

                    b.Property<int?>("StarDestroyerId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssaultShipId");

                    b.HasIndex("BaseId");

                    b.HasIndex("LegionId");

                    b.HasIndex("LegionId1");

                    b.HasIndex("StarDestroyerId");

                    b.HasIndex("StarDestroyerId1");

                    b.ToTable("Clones");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Clone");
                });

            modelBuilder.Entity("SWProject.Droid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AssaultShipId")
                        .HasColumnType("int");

                    b.Property<int?>("BaseId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StarDestroyerId")
                        .HasColumnType("int");

                    b.Property<int?>("StarDestroyerId1")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssaultShipId");

                    b.HasIndex("BaseId");

                    b.HasIndex("StarDestroyerId");

                    b.HasIndex("StarDestroyerId1");

                    b.ToTable("Droid");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Droid");
                });

            modelBuilder.Entity("SWProject.Jedi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("LegionId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PadawanId")
                        .HasColumnType("int");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PadawanId")
                        .IsUnique()
                        .HasFilter("[PadawanId] IS NOT NULL");

                    b.ToTable("Jedies");
                });

            modelBuilder.Entity("SWProject.Legion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("GeneralJediId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GeneralJediId")
                        .IsUnique()
                        .HasFilter("[GeneralJediId] IS NOT NULL");

                    b.ToTable("Legions");
                });

            modelBuilder.Entity("SWProject.StarDestroyer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("WeaponryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WeaponryId");

                    b.ToTable("StarDestroyers");
                });

            modelBuilder.Entity("SWProject.StarshipWeaponry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LaserDoubleCannonCnt")
                        .HasColumnType("int");

                    b.Property<int>("LaserTargetDefenseCannonCnt")
                        .HasColumnType("int");

                    b.Property<int>("LaserTurretCnt")
                        .HasColumnType("int");

                    b.Property<int>("ProtonTorpedoLauncherCnt")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StarshipWeaponries");
                });

            modelBuilder.Entity("SWProject.Supply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartridgesCnt")
                        .HasColumnType("int");

                    b.Property<int>("FuelCnt")
                        .HasColumnType("int");

                    b.Property<int>("GrenadesCnt")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Supplies");
                });

            modelBuilder.Entity("SWProject.CloneCommander", b =>
                {
                    b.HasBaseType("SWProject.Clone");

                    b.HasDiscriminator().HasValue("CloneCommander");
                });

            modelBuilder.Entity("SWProject.CombatDroid", b =>
                {
                    b.HasBaseType("SWProject.Droid");

                    b.Property<string>("Equipment")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("CombatDroid");
                });

            modelBuilder.Entity("SWProject.ServiceDroid", b =>
                {
                    b.HasBaseType("SWProject.Droid");

                    b.HasDiscriminator().HasValue("ServiceDroid");
                });

            modelBuilder.Entity("SWProject.AssaultShip", b =>
                {
                    b.HasOne("SWProject.BaseFleet", null)
                        .WithMany("Acclamators")
                        .HasForeignKey("BaseFleetId");

                    b.HasOne("SWProject.StarshipWeaponry", "Weaponry")
                        .WithMany()
                        .HasForeignKey("WeaponryId");

                    b.Navigation("Weaponry");
                });

            modelBuilder.Entity("SWProject.Base", b =>
                {
                    b.HasOne("SWProject.Supply", "AmmoSupply")
                        .WithMany()
                        .HasForeignKey("AmmoSupplyId");

                    b.HasOne("SWProject.BaseFleet", "AttachedFleet")
                        .WithMany("AttachedBases")
                        .HasForeignKey("AttachedFleetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AmmoSupply");

                    b.Navigation("AttachedFleet");
                });

            modelBuilder.Entity("SWProject.BaseFleet", b =>
                {
                    b.HasOne("SWProject.StarDestroyer", "Venator")
                        .WithMany()
                        .HasForeignKey("VenatorId");

                    b.Navigation("Venator");
                });

            modelBuilder.Entity("SWProject.Clone", b =>
                {
                    b.HasOne("SWProject.AssaultShip", null)
                        .WithMany("CloneList")
                        .HasForeignKey("AssaultShipId");

                    b.HasOne("SWProject.Base", null)
                        .WithMany("CloneList")
                        .HasForeignKey("BaseId");

                    b.HasOne("SWProject.Legion", "Legion")
                        .WithMany()
                        .HasForeignKey("LegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SWProject.Legion", null)
                        .WithMany("Clones")
                        .HasForeignKey("LegionId1");

                    b.HasOne("SWProject.StarDestroyer", null)
                        .WithMany("CloneList")
                        .HasForeignKey("StarDestroyerId");

                    b.HasOne("SWProject.StarDestroyer", null)
                        .WithMany("Passangers")
                        .HasForeignKey("StarDestroyerId1");

                    b.Navigation("Legion");
                });

            modelBuilder.Entity("SWProject.Droid", b =>
                {
                    b.HasOne("SWProject.AssaultShip", null)
                        .WithMany("DroidList")
                        .HasForeignKey("AssaultShipId");

                    b.HasOne("SWProject.Base", null)
                        .WithMany("DroidList")
                        .HasForeignKey("BaseId");

                    b.HasOne("SWProject.StarDestroyer", null)
                        .WithMany("DroidList")
                        .HasForeignKey("StarDestroyerId");

                    b.HasOne("SWProject.StarDestroyer", null)
                        .WithMany("Droids")
                        .HasForeignKey("StarDestroyerId1");
                });

            modelBuilder.Entity("SWProject.Jedi", b =>
                {
                    b.HasOne("SWProject.Jedi", "Padawan")
                        .WithOne("Teacher")
                        .HasForeignKey("SWProject.Jedi", "PadawanId");

                    b.Navigation("Padawan");
                });

            modelBuilder.Entity("SWProject.Legion", b =>
                {
                    b.HasOne("SWProject.Jedi", "GeneralJedi")
                        .WithOne("Legion")
                        .HasForeignKey("SWProject.Legion", "GeneralJediId");

                    b.Navigation("GeneralJedi");
                });

            modelBuilder.Entity("SWProject.StarDestroyer", b =>
                {
                    b.HasOne("SWProject.StarshipWeaponry", "Weaponry")
                        .WithMany()
                        .HasForeignKey("WeaponryId");

                    b.Navigation("Weaponry");
                });

            modelBuilder.Entity("SWProject.AssaultShip", b =>
                {
                    b.Navigation("CloneList");

                    b.Navigation("DroidList");
                });

            modelBuilder.Entity("SWProject.Base", b =>
                {
                    b.Navigation("CloneList");

                    b.Navigation("DroidList");
                });

            modelBuilder.Entity("SWProject.BaseFleet", b =>
                {
                    b.Navigation("Acclamators");

                    b.Navigation("AttachedBases");
                });

            modelBuilder.Entity("SWProject.Jedi", b =>
                {
                    b.Navigation("Legion");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SWProject.Legion", b =>
                {
                    b.Navigation("Clones");
                });

            modelBuilder.Entity("SWProject.StarDestroyer", b =>
                {
                    b.Navigation("CloneList");

                    b.Navigation("DroidList");

                    b.Navigation("Droids");

                    b.Navigation("Passangers");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebProject.Data;

namespace WebProject.Migrations
{
    [DbContext(typeof(WebProjectContext))]
    [Migration("20211226170004_SummonerRankedLeagueDetailCreate")]
    partial class SummonerRankedLeagueDetailCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebProject.Models.Summoner", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("ProfileIconId")
                        .HasColumnType("int");

                    b.Property<string>("PuuId")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("RevisionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SummonerLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Summoner");
                });

            modelBuilder.Entity("WebProject.Models.SummonerRankedLeagueDetail", b =>
                {
                    b.Property<string>("LeagueId")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("FreshBlood")
                        .HasColumnType("bit");

                    b.Property<bool>("HotStreak")
                        .HasColumnType("bit");

                    b.Property<bool>("Inactive")
                        .HasColumnType("bit");

                    b.Property<int>("LeaguePoint")
                        .HasColumnType("int");

                    b.Property<int>("Losses")
                        .HasColumnType("int");

                    b.Property<string>("QueueType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<string>("SummonerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Tier")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("Veteran")
                        .HasColumnType("bit");

                    b.Property<int>("Win")
                        .HasColumnType("int");

                    b.HasKey("LeagueId");

                    b.HasIndex("SummonerId");

                    b.ToTable("SummonerRankedLeagueDetail");
                });

            modelBuilder.Entity("WebProject.Models.SummonerRankedLeagueDetail", b =>
                {
                    b.HasOne("WebProject.Models.Summoner", "Summoner")
                        .WithMany()
                        .HasForeignKey("SummonerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Summoner");
                });
#pragma warning restore 612, 618
        }
    }
}
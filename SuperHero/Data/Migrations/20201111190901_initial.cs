﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHero.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Supes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupeName = table.Column<string>(nullable: true),
                    AlterEgo = table.Column<string>(nullable: true),
                    PrimaryAbility = table.Column<string>(nullable: true),
                    SecondaryAbility = table.Column<string>(nullable: true),
                    CatchPhrase = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Supes");
        }
    }
}

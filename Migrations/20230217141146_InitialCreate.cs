﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcBalloon.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Balloon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(nullable: true),
                    Occassion = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Shape = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balloon", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Balloon");
        }
    }
}

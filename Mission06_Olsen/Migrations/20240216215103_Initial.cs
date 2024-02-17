﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission06_Olsen.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieAddition",
                columns: table => new
                {
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Director = table.Column<string>(type: "TEXT", nullable: false),
                    MovieRating = table.Column<int>(type: "INTEGER", nullable: false),
                    Edited = table.Column<bool>(type: "BOOL", nullable: false),
                    LentTo = table.Column<string>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: false)
                },

                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieAddition", x => x.Title);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieAddition");
        }
    }
}

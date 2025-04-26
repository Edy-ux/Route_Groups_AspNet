using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Route_Groups_AspNet.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 600, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Title", "Url" },
                values: new object[,]
                {
                    { new Guid("74a95654-9248-42d1-a9ba-756313bbec7e"), "Esportes e Fitnes", "https://http2.mlstatic.com/storage/splinter-admin/o:f_webp,q_auto:best/1731421475975-desk-01-v2.jpg" },
                    { new Guid("b68c0981-903b-45ae-b44d-3438769c1fce"), "Casa E Móveis", "https://http2.mlstatic.com/storage/splinter-admin/o:f_webp,q_auto:best/1729294158019-desktop26.png" },
                    { new Guid("f993b84b-bee4-41c8-911e-8879702595a3"), "Tecnologias", "https://http2.mlstatic.com/D_NQ_NP2X_660966-MLA80300585057_102024-B.webp" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

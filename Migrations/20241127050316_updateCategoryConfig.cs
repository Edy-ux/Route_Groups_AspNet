using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Route_Groups_AspNet.Migrations
{
    /// <inheritdoc />
    public partial class updateCategoryConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Title", "Url" },
                values: new object[,]
                {
                    { new Guid("d09fe398-0917-439d-8edc-d423894c21cc"), "Tecnologias", "https://http2.mlstatic.com/D_NQ_NP2X_660966-MLA80300585057_102024-B.webp" },
                    { new Guid("f19d1d91-34dc-4a2d-ba08-1fee0468fcf3"), "Esportes e Fitnes", "https://http2.mlstatic.com/storage/splinter-admin/o:f_webp,q_auto:best/1731421475975-desk-01-v2.jpg" },
                    { new Guid("f407aca2-ef55-4771-a1b4-1456bfaf2665"), "Casa E Móveis", "https://http2.mlstatic.com/storage/splinter-admin/o:f_webp,q_auto:best/1729294158019-desktop26.png" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d09fe398-0917-439d-8edc-d423894c21cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f19d1d91-34dc-4a2d-ba08-1fee0468fcf3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f407aca2-ef55-4771-a1b4-1456bfaf2665"));
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSchema3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CoverImageUrl",
                value: "https://m.media-amazon.com/images/I/41LuUlddrhL._SY445_SX342_.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CoverImageUrl",
                value: "https://m.media-amazon.com/images/I/81+uA5ds6yL._AC_UF1000,1000_QL80_.jpg");
        }
    }
}

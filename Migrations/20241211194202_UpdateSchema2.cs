using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSchema2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CoverImageUrl",
                value: "https://m.media-amazon.com/images/I/51TI+w56qFL._SY445_SX342_.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CoverImageUrl",
                value: "https://m.media-amazon.com/images/I/51QnRBHJ+sL._SY445_SX342_.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoverImageUrl", "Price" },
                values: new object[] { "https://m.media-amazon.com/images/I/81NJTjH8EcL._SY466_.jpg", 87.99m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoverImageUrl", "Price" },
                values: new object[] { "https://m.media-amazon.com/images/I/71H52+sSb4L._SY466_.jpg", 31.49m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoverImageUrl", "Price" },
                values: new object[] { "https://m.media-amazon.com/images/I/61ZKK6Y1nFL._SY466_.jpg", 23.99m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "CoverImageUrl",
                value: "https://m.media-amazon.com/images/I/41KnOXaLyuL._SY445_SX342_.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "CoverImageUrl",
                value: "https://m.media-amazon.com/images/I/51kpoART0HL._SX342_SY445_.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "CoverImageUrl",
                value: "https://m.media-amazon.com/images/I/81NLDvyAHrL._SY466_.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CoverImageUrl",
                value: "https://example.com/catcher.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CoverImageUrl",
                value: "https://example.com/hobbit.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoverImageUrl", "Price" },
                values: new object[] { "https://m.media-amazon.com/images/I/91c+zIEnbcL._AC_UF1000,1000_QL80_.jpg", 19.99m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoverImageUrl", "Price" },
                values: new object[] { "https://m.media-amazon.com/images/I/91PStwG1nHL._AC_UF1000,1000_QL80_.jpg", 10.49m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoverImageUrl", "Price" },
                values: new object[] { "https://m.media-amazon.com/images/I/81OoyVMBTJL._AC_UF1000,1000_QL80_.jpg", 14.99m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "CoverImageUrl",
                value: "https://m.media-amazon.com/images/I/91ObZ1zZx-L._AC_UF1000,1000_QL80_.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "CoverImageUrl",
                value: "https://m.media-amazon.com/images/I/81ytgD0OLFL._AC_UF1000,1000_QL80_.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "CoverImageUrl",
                value: "https://m.media-amazon.com/images/I/91HHxxtA1wL._AC_UF1000,1000_QL80_.jpg");
        }
    }
}

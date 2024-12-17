using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverImageUrl", "Description", "Genre", "Price", "Title" },
                values: new object[,]
                {
                    { 6, "J.R.R. Tolkien", "https://m.media-amazon.com/images/I/91c+zIEnbcL._AC_UF1000,1000_QL80_.jpg", "An epic adventure in Middle-earth, chronicling the quest to destroy the One Ring.", "Fantasy", 19.99m, "The Lord of the Rings" },
                    { 7, "Paulo Coelho", "https://m.media-amazon.com/images/I/91PStwG1nHL._AC_UF1000,1000_QL80_.jpg", "A journey of self-discovery following Santiago, a shepherd, in search of his personal legend.", "Philosophical Fiction", 10.49m, "The Alchemist" },
                    { 8, "J.K. Rowling", "https://m.media-amazon.com/images/I/81YOuOGFCJL._AC_UF1000,1000_QL80_.jpg", "The first book in the beloved Harry Potter series, introducing the magical world of Hogwarts.", "Fantasy", 12.99m, "Harry Potter and the Philosopher's Stone" },
                    { 9, "Markus Zusak", "https://m.media-amazon.com/images/I/81+uA5ds6yL._AC_UF1000,1000_QL80_.jpg", "A hauntingly beautiful story set in Nazi Germany, narrated by Death itself.", "Historical Fiction", 8.99m, "The Book Thief" },
                    { 10, "Yuval Noah Harari", "https://m.media-amazon.com/images/I/81OoyVMBTJL._AC_UF1000,1000_QL80_.jpg", "A fascinating exploration of the history and evolution of humankind.", "Non-Fiction", 14.99m, "Sapiens: A Brief History of Humankind" },
                    { 11, "James Clear", "https://m.media-amazon.com/images/I/91bYsX41DVL._AC_UF1000,1000_QL80_.jpg", "A guide to building good habits and breaking bad ones for a successful life.", "Self-Help", 16.99m, "Atomic Habits" },
                    { 12, "Frank Herbert", "https://m.media-amazon.com/images/I/91ObZ1zZx-L._AC_UF1000,1000_QL80_.jpg", "A science fiction masterpiece set on the desert planet Arrakis, exploring politics, religion, and survival.", "Science Fiction", 11.99m, "Dune" },
                    { 13, "Michelle Obama", "https://m.media-amazon.com/images/I/81h2gWPTYJL._AC_UF1000,1000_QL80_.jpg", "An intimate and inspiring memoir by the former First Lady of the United States.", "Biography", 18.49m, "Becoming" },
                    { 14, "Margaret Wise Brown", "https://m.media-amazon.com/images/I/81ytgD0OLFL._AC_UF1000,1000_QL80_.jpg", "A timeless bedtime story for children, filled with soothing rhythms and illustrations.", "Children's Fiction", 6.99m, "Goodnight Moon" },
                    { 15, "Jane Austen", "https://m.media-amazon.com/images/I/91HHxxtA1wL._AC_UF1000,1000_QL80_.jpg", "A timeless tale of love and social commentary, centered around Elizabeth Bennet and Mr. Darcy.", "Classic Romance", 7.99m, "Pride and Prejudice" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}

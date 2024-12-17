using Microsoft.EntityFrameworkCore;
using BookStoreApp.Models;
using System.Security.Cryptography;
using System.Text;

namespace BookStoreApp.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Book)
                .WithMany()
                .HasForeignKey(oi => oi.BookId);

            // Seed data for Users
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FullName = "Admin User",
                    Email = "admin@booknook.com",
                    Password = HashPassword("admin123"), // Hashing the admin password
                    Role = "Admin"
                }
            );

            // Seed data for Books
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    Price = 10.99M,
                    CoverImageUrl = "https://m.media-amazon.com/images/I/71V1cA2fiZL._AC_UF1000,1000_QL80_.jpg",
                    Genre = "Classic",
                    Description = "A story of the mysterious Jay Gatsby and his unrequited love for Daisy Buchanan, set in the Roaring Twenties."
                },
                new Book
                {
                    Id = 2,
                    Title = "1984",
                    Author = "George Orwell",
                    Price = 8.99M,
                    CoverImageUrl = "https://m.media-amazon.com/images/I/71rpa1-kyvL._AC_UF1000,1000_QL80_.jpg",
                    Genre = "Dystopian",
                    Description = "A chilling depiction of a totalitarian regime where surveillance and mind control are omnipresent."
                },
                new Book
                {
                    Id = 3,
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    Price = 12.99M,
                    CoverImageUrl = "https://m.media-amazon.com/images/I/71FxgtFKcQL._AC_UF1000,1000_QL80_.jpg",
                    Genre = "Fiction",
                    Description = "A powerful exploration of racial injustice and childhood innocence in the Deep South."
                },
                new Book
                {
                    Id = 4,
                    Title = "The Catcher in the Rye",
                    Author = "J.D. Salinger",
                    Price = 9.99M,
                    CoverImageUrl = "https://m.media-amazon.com/images/I/51TI+w56qFL._SY445_SX342_.jpg",
                    Genre = "Modern Classic",
                    Description = "A coming-of-age novel about teenage rebellion."
                },
                new Book
                {
                    Id = 5,
                    Title = "The Hobbit",
                    Author = "J.R.R. Tolkien",
                    Price = 14.99M,
                    CoverImageUrl = "https://m.media-amazon.com/images/I/51QnRBHJ+sL._SY445_SX342_.jpg",
                    Genre = "Fantasy",
                    Description = "The prelude to the epic Lord of the Rings series."
                },

                new Book
                {
                    Id = 6,
                    Title = "The Lord of the Rings",
                    Author = "J.R.R. Tolkien",
                    Price = 87.99M,
                    CoverImageUrl = "https://m.media-amazon.com/images/I/81NJTjH8EcL._SY466_.jpg",
                    Genre = "Fantasy",
                    Description = "An epic adventure in Middle-earth, chronicling the quest to destroy the One Ring."
                },
                new Book
                {
                    Id = 7,
                    Title = "The Alchemist",
                    Author = "Paulo Coelho",
                    Price = 31.49M,
                    CoverImageUrl = "https://m.media-amazon.com/images/I/71H52+sSb4L._SY466_.jpg",
                    Genre = "Philosophical Fiction",
                    Description = "A journey of self-discovery following Santiago, a shepherd, in search of his personal legend."
                },
                new Book
                {
                    Id = 8,
                    Title = "Harry Potter and the Philosopher's Stone",
                    Author = "J.K. Rowling",
                    Price = 12.99M,
                    CoverImageUrl = "https://m.media-amazon.com/images/I/81YOuOGFCJL._AC_UF1000,1000_QL80_.jpg",
                    Genre = "Fantasy",
                    Description = "The first book in the beloved Harry Potter series, introducing the magical world of Hogwarts."
                },
                new Book
                {
                    Id = 9,
                    Title = "The Book Thief",
                    Author = "Markus Zusak",
                    Price = 8.99M,
                    CoverImageUrl = "https://m.media-amazon.com/images/I/41LuUlddrhL._SY445_SX342_.jpg",
                    Genre = "Historical Fiction",
                    Description = "A hauntingly beautiful story set in Nazi Germany, narrated by Death itself."
                },
                new Book
                {
                    Id = 10,
                    Title = "Sapiens: A Brief History of Humankind",
                    Author = "Yuval Noah Harari",
                    Price = 23.99M,
                    CoverImageUrl = "https://m.media-amazon.com/images/I/61ZKK6Y1nFL._SY466_.jpg",
                    Genre = "Non-Fiction",
                    Description = "A fascinating exploration of the history and evolution of humankind."
                },
                new Book
                {
                    Id = 11,
                    Title = "Atomic Habits",
                    Author = "James Clear",
                    Price = 16.99M,
                    CoverImageUrl = "https://m.media-amazon.com/images/I/91bYsX41DVL._AC_UF1000,1000_QL80_.jpg",
                    Genre = "Self-Help",
                    Description = "A guide to building good habits and breaking bad ones for a successful life."
                },
                new Book
                {
                    Id = 12,
                    Title = "Dune",
                    Author = "Frank Herbert",
                    Price = 11.99M,
                    CoverImageUrl = "https://m.media-amazon.com/images/I/41KnOXaLyuL._SY445_SX342_.jpg",
                    Genre = "Science Fiction",
                    Description = "A science fiction masterpiece set on the desert planet Arrakis, exploring politics, religion, and survival."
                },
                new Book
                {
                    Id = 13,
                    Title = "Becoming",
                    Author = "Michelle Obama",
                    Price = 18.49M,
                    CoverImageUrl = "https://m.media-amazon.com/images/I/81h2gWPTYJL._AC_UF1000,1000_QL80_.jpg",
                    Genre = "Biography",
                    Description = "An intimate and inspiring memoir by the former First Lady of the United States."
                },
                new Book
                {
                    Id = 14,
                    Title = "Goodnight Moon",
                    Author = "Margaret Wise Brown",
                    Price = 6.99M,
                    CoverImageUrl = "https://m.media-amazon.com/images/I/51kpoART0HL._SX342_SY445_.jpg",
                    Genre = "Children's Fiction",
                    Description = "A timeless bedtime story for children, filled with soothing rhythms and illustrations."
                },
                new Book
                    {
                    Id = 15,
                    Title = "Pride and Prejudice",
                    Author = "Jane Austen",
                    Price = 7.99M,
                    CoverImageUrl = "https://m.media-amazon.com/images/I/81NLDvyAHrL._SY466_.jpg",
                    Genre = "Classic Romance",
                    Description = "A timeless tale of love and social commentary, centered around Elizabeth Bennet and Mr. Darcy."
                }

            );

        }

        // Helper method to hash passwords
        private static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}

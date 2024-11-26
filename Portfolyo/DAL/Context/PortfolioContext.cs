using Microsoft.EntityFrameworkCore;
using Portfolyo.DAL.Entities;

namespace Portfolyo.DAL.Context
{
    public class PortfolioContext : DbContext
    {
        // Bağlantı stringini verdiğimiz metod
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SELIM\\SQLEXPRESS;initial Catalog=PortfolioDb;integrated Security=true");
        }

        public DbSet<About> Abouts { get; set; } // <About> -> Entities klasöründeki Class / Abouts -> DB Table
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
    }
}

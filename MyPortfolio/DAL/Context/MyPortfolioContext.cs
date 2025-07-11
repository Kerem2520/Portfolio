using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Entities;
using System.Reflection.Metadata.Ecma335;

namespace MyPortfolio.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {

        // Bağlantı stringini vereceğimiz metod.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = KEREM\\SQLEXPRESS; initial Catalog = MyPortfolioDb ; integrated Security = true;");
        }

        // Sql e yansıtacağımız (tablo olacak ) sınıfların ismini veriyoruz.
        // Çoğul olan sql, tekil olan c#
        public DbSet<About> Abouts { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Experience> Experiences { get; set; }

        public DbSet<feature> Features { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Portfolio> Portfolios { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<SocialMedia> SocialMedias { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }





    }
}

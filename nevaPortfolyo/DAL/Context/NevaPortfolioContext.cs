using Microsoft.EntityFrameworkCore;
using nevaPortfolyo.DAL.Entites;

namespace nevaPortfolyo.DAL.Context
{
    public class NevaPortfolioContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=DESKTOP-4K5F1LJ; initial Catalog=NevaPortfolyoDb;integrated Securit=true; ");
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4K5F1LJ\\SQLEXPRESS;Initial Catalog=NevaPortfolyoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias  { get; set; }
        public DbSet<Testimonial> Testimonials   { get; set; }

    }
}

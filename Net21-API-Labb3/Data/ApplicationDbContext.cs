using Microsoft.EntityFrameworkCore;
using Net21_API_Labb3.Models;

namespace Net21_API_Labb3.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }



        public virtual DbSet<Interest> Interests { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Website> Websites { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Website>()
       .HasKey(w => new { w.UserId, w.InterestId });
            builder.Entity<Website>()
                .HasOne(u => u.User)
                .WithMany(w => w.Websites)
                .HasForeignKey(ui => ui.UserId);
            builder.Entity<Website>()
                .HasOne(i => i.Interest)
                .WithMany(w => w.Websites)
                .HasForeignKey(i => i.InterestId);


            builder.Entity<Interest>().HasData(
                new Interest
                {
                    InterestId = 1,
                    Interest_Name = "Swimming",
                    Description = "Water Sport",
                    
                },
                new Interest
                {

                    InterestId = 2,
                    Interest_Name = "Running",
                    Description = "Long Distance Marathons",
                    
                },
                 new Interest
                 {

                     InterestId = 3,
                     Interest_Name = "Music",
                     Description = "Pop Music",
                     
                 }
                );

            builder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Name = "John Johns",
                    PhoneNumber = "075432213",

                },
                new User
                {
                    UserId = 2,
                    Name = "Tina Turner",
                    PhoneNumber = "075487094",

                },
                 new User
                 {
                     UserId = 3,
                     Name = "Jommy Choo",
                     PhoneNumber = "0721540956",

                 });

            builder.Entity<Website>().HasData(
                 new Website
                 {
                     WebsiteAddress = "www.testing.com",
                     UserId = 1,
                     InterestId = 2
                 },

            new Website
            {
                WebsiteAddress = "www.tester.com",
                UserId = 1,
                InterestId = 3
            },

            new Website
            {
                WebsiteAddress = "www.check.net",
                UserId = 2,
                InterestId = 3,
            },

            new Website
            {
                WebsiteAddress = "www.hahaha.net",
                UserId = 3,
                InterestId = 1,
            });


        }


    }
}




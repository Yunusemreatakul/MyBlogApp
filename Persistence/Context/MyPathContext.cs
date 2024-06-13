using Microsoft.EntityFrameworkCore;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Persistence.Context
{
    public class MyPathContext : DbContext
    {
        
        public MyPathContext(DbContextOptions<MyPathContext> options): base(options)
        {
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Skils> Skills { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<BlogCard> BlogCards { get; set; }
        public DbSet<BlogDetail> BlogDetails { get; set; }
        public DbSet<CommentBlog> CommentBs { get; set; }
        public DbSet<CommentBlogReply> Replies { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<CategoryPortfolio> CategoryPortfolios { get; set; }
        public DbSet<PortfolioDetail> PortfolioDetails { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<PortfolioImageList> PortfolioImageLists { get; set;}

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // User-Role
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);

            //PortfolioImageList-PortfolioDetail
            modelBuilder.Entity<PortfolioDetail>()
                .HasMany(pd => pd.PortfolioImageLists) 
                .WithOne(pil => pil.PortfolioDetail)  
                .HasForeignKey(pil => pil.PortfolioDetailId);

            // User-About
            modelBuilder.Entity<User>()
                .HasMany(u => u.Abouts)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId);

            // User-Client
            modelBuilder.Entity<User>()
                .HasMany(u => u.Clients)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserId);

            // User-Skill
            modelBuilder.Entity<User>()
                .HasMany(u => u.Skills)
                .WithOne(s => s.User)
                .HasForeignKey(s => s.UserId);

            // User-Testimonial
            modelBuilder.Entity<User>()
                .HasMany(u => u.Testimonials)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.UserId);

            // User-Contact
            modelBuilder.Entity<User>()
                .HasMany(u => u.Contacts)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserId);

            // User-BlogCard
            modelBuilder.Entity<User>()
                .HasMany(u => u.BlogCards)
                .WithOne(b => b.User)
                .HasForeignKey(b => b.UserId);

            // BlogCard-BlogDetail One-to-One
            modelBuilder.Entity<BlogCard>()
                .HasOne(bc => bc.BlogDetail)
                .WithOne(bd => bd.BlogCard)
                .HasForeignKey<BlogDetail>(bd => bd.BlogCardId);

            // BlogDetail-CommentB One-to-Many
            modelBuilder.Entity<BlogDetail>()
                .HasMany(bd => bd.Comments)
                .WithOne(c => c.BlogDetail)
                .HasForeignKey(c => c.BlogDetailId);

            // CommentB-Reply One-to-Many
            modelBuilder.Entity<CommentBlog>()
                .HasMany(c => c.Replies)
                .WithOne(r => r.CommentB)
                .HasForeignKey(r => r.CommentBId);

            // User-Portfolio
            modelBuilder.Entity<User>()
                .HasMany(u => u.Portfolios)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId).
                OnDelete(DeleteBehavior.NoAction);

            // Portfolio-CategoryP one-to-Many
            

            modelBuilder.Entity<Portfolio>()
                .HasOne(u => u.CategoryPortfolio)
                .WithMany(cp => cp.Portfolios)
                .HasForeignKey(u => u.CategoryPortfolioId);

            // Portfolio-PortfolioDetail One-to-One
            modelBuilder.Entity<Portfolio>()
                .HasOne(p => p.PortfolioDetail)
                .WithOne(pd => pd.Portfolio)
                .HasForeignKey<PortfolioDetail>(pd => pd.PortfolioId);

            // User-Experience
            modelBuilder.Entity<User>()
                .HasMany(u => u.Experiences)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId);

            // User-Education
            modelBuilder.Entity<User>()
                .HasMany(u => u.Educations)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId);

            // User-Profile One-to-One
            modelBuilder.Entity<User>()
                .HasOne(u => u.Profile)
                .WithOne(p => p.User)
                .HasForeignKey<Profile>(p => p.UserId);
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Gymany_API.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){
        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Set precision and scale for admin_salary
            modelBuilder.Entity<Admin>()
                .Property(a => a.admin_salary)
                .HasPrecision(18, 2);  // Precision: 18 digits, 2 after decimal point

            modelBuilder.Entity<Order>()
                .Property(a => a.order_totalPrice)
                .HasPrecision(18, 2);  // Precision: 18 digits, 2 after decimal point


            modelBuilder.Entity<PersonalTrainer>()
                .Property(a => a.pt_salary)
                .HasPrecision(18, 2);  // Precision: 18 digits, 2 after decimal point


            modelBuilder.Entity<Product>()
                .Property(a => a.prod_price)
                .HasPrecision(18, 2);  // Precision: 18 digits, 2 after decimal point

            
        }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PersonalTrainer> PersonalTrainers { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SystemAdmin> SystemAdmins { get; set; }
        public DbSet<WorkoutPlan> WorkoutPlans { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lession> Lessions { get; set; }
        public DbSet<Examination> Examinations { get; set; }

    }
}



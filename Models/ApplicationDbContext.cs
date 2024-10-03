using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bogus;

namespace Gymany_API.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        
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

            modelBuilder.Entity<Course>()
                .HasOne(c => c.WorkoutPlan)
                .WithMany(wp => wp.Courses)
                .HasForeignKey(c => c.workout_id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Examination>()
                .HasOne(ex => ex.Course)
                .WithMany(c => c.Examinations)
                .HasForeignKey(c => c.course_id)
                .OnDelete(DeleteBehavior.Restrict);


        //Add default account by using Bogus
        var adminFaker = new Faker<Admin>()
            .RuleFor(a => a.admin_id, f => f.IndexFaker + 1)
            .RuleFor(a => a.admin_username, f => "gymanyadmin") // Set username to "admin"
            .RuleFor(a => a.admin_password, f => "gymanyadmin@123")   // Set password to "123"
            .RuleFor(a => a.admin_name, f => f.Name.FullName()) // You can still use a random full name or customize it
            .RuleFor(a => a.admin_age, f => f.Date.Past(30, DateTime.Now.AddYears(-18)))
            .RuleFor(a => a.admin_salary, f => f.Finance.Amount(1000, 5000))
            .RuleFor(a => a.admin_email, f => f.Internet.Email());
        modelBuilder.Entity<Admin>().HasData(adminFaker.Generate(1));

        var cartFaker = new Faker<Cart>()
            .RuleFor(c => c.cart_id, f => f.IndexFaker + 1) // Auto-incrementing ID
            .RuleFor(c => c.cart_quantity, f => f.Random.Int(1, 10)) // Random quantity between 1 and 10
            .RuleFor(c => c.cus_id, f => 1) // Assuming Customer IDs range from 1 to 10
            .RuleFor(c => c.prod_id, f => f.Random.Int(1, 10)); // Assuming Product IDs range from 1 to 10
        modelBuilder.Entity<Cart>().HasData(cartFaker.Generate(10));

        var courseFaker = new Faker<Course>()
            .RuleFor(c => c.course_id, f => f.IndexFaker + 1) // Auto-incrementing ID
            .RuleFor(c => c.course_title, f => f.Commerce.ProductName()) // Random course title
            .RuleFor(c => c.course_description, f => f.Lorem.Paragraph().Substring(0, 50)) 
            .RuleFor(c => c.course_episode, f => f.Random.Int(1, 20).ToString()) // Random episode count as a string
            .RuleFor(c => c.cus_id, f => 1) // Assuming Customer IDs range from 1 to 10
            .RuleFor(c => c.workout_id, f => f.Random.Int(1, 10)) // Assuming WorkoutPlan IDs range from 1 to 10
            .RuleFor(c => c.pt_id, f => 1); // Assuming Personal Trainer IDs range from 1 to 10
        modelBuilder.Entity<Course>().HasData(courseFaker.Generate(10));


        var examinationFaker = new Faker<Examination>()
            .RuleFor(e => e.exam_id, f => f.IndexFaker + 1)
            .RuleFor(e => e.exam_title, f => f.Commerce.ProductName()) // Random exam title
            .RuleFor(e => e.exam_question, f => f.Lorem.Sentence(10).Substring(0, 50)) // Random exam question
            .RuleFor(e => e.course_id, f => f.Random.Int(1, 10)) // Assuming Course IDs range from 1 to 10
            .RuleFor(e => e.pt_id, f => 1); // Assuming Personal Trainer IDs range from 1 to 10
        modelBuilder.Entity<Examination>().HasData(examinationFaker.Generate(10));


        var orderFaker = new Faker<Order>()
            .RuleFor(o => o.order_id, f => f.IndexFaker + 1) // Auto-incrementing ID
            .RuleFor(o => o.order_status, f => f.PickRandom(new[] { "Pending", "Completed", "Canceled" })) // Random status
            .RuleFor(o => o.order_startDate, f => f.Date.Recent()) // Random recent date
            .RuleFor(o => o.order_totalPrice, f => f.Finance.Amount(100, 500)) // Random price between 100 and 500
            .RuleFor(o => o.order_quantity, f => f.Random.Int(1, 5)) // Random quantity between 1 and 5
            .RuleFor(o => o.cus_id, f => 1) // Assuming Customer IDs range from 1 to 10
            .RuleFor(o => o.prod_id, f => f.Random.Int(1, 10)); // Assuming Product IDs range from 1 to 10
        modelBuilder.Entity<Order>().HasData(orderFaker.Generate(10));

        var paymentFaker = new Faker<Payment>()
            .RuleFor(p => p.pay_id, f => f.IndexFaker + 1) // Auto-incrementing ID
            .RuleFor(p => p.pay_date, f => f.Date.Recent()) // Random recent date for the payment
            .RuleFor(p => p.pay_quantity, f => f.Random.Int(1, 10)) // Random quantity between 1 and 10
            .RuleFor(p => p.cus_id, f => 1) // Assuming Customer IDs range from 1 to 10
            .RuleFor(p => p.prod_id, f => f.Random.Int(1, 10)); // Assuming Product IDs range from 1 to 10
        modelBuilder.Entity<Payment>().HasData(paymentFaker.Generate(10));

        var postFaker = new Faker<Post>()
            .RuleFor(p => p.post_id, f => f.IndexFaker + 1)
            .RuleFor(p => p.post_date, f => f.Date.Past(1)) // Posts within the past year
            .RuleFor(p => p.post_content, f => f.Lorem.Paragraphs(1, 3)) // Random paragraphs as post content
            .RuleFor(p => p.post_title, f => f.Lorem.Sentence(5)) // Random sentence as title
            .RuleFor(p => p.post_img, f => f.Image.PicsumUrl()) // Random image URL
            .RuleFor(p => p.pt_id, f => 1) // Assuming PersonalTrainer IDs range from 1 to 10
            .RuleFor(p => p.cus_id, f => 1) // Assuming Customer IDs range from 1 to 10
            .RuleFor(p => p.admin_id, f => 1); // Assuming Admin IDs range from 1 to 10
        modelBuilder.Entity<Post>().HasData(postFaker.Generate(10));

        var productFaker = new Faker<Product>()
            .RuleFor(p => p.prod_id, f => f.IndexFaker + 1)
            .RuleFor(p => p.prod_name, f => f.Commerce.ProductName()) // Generate product names
            .RuleFor(p => p.prod_description, f => f.Lorem.Sentence()) // Random description for the product
            .RuleFor(p => p.prod_amount, f => f.Random.Int(1, 100)) // Random amount of products
            .RuleFor(p => p.prod_img, f => f.Image.PicsumUrl()) // Random image URL
            .RuleFor(p => p.prod_price, f => f.Finance.Amount(5, 500)) // Random price between $5 and $500
            .RuleFor(p => p.cate_id, f => f.Random.Int(1, 10)); // Assuming Category IDs range from 1 to 10
        modelBuilder.Entity<Product>().HasData(productFaker.Generate(10));

        var workoutPlanFaker = new Faker<WorkoutPlan>()
            .RuleFor(w => w.workout_id, f => f.IndexFaker + 1)
            .RuleFor(w => w.workout_name, f => f.Commerce.ProductName()) // Using random workout names
            .RuleFor(w => w.workout_startDate, f => f.Date.Past(1)) // Random start date within the past year
            .RuleFor(w => w.workout_endDate, (f, w) => w.workout_startDate?.AddMonths(f.Random.Int(1, 6))) // Random end date after start
            .RuleFor(w => w.workout_description, f => f.Lorem.Paragraph(1)) // Random description
            .RuleFor(w => w.workout_session, f => f.Random.Word()) // Random workout session type
            .RuleFor(w => w.workout_activity, f => f.Lorem.Sentence()) // Random workout activity description
            .RuleFor(w => w.pt_id, f => 1) // Assuming PersonalTrainer IDs range from 1 to 10
            .RuleFor(w => w.exc_id, f => f.Random.Int(1, 10)) // Assuming Exercise IDs range from 1 to 10
            .RuleFor(w => w.cus_id, f => 1); // Assuming Customer IDs range from 1 to 10
        modelBuilder.Entity<WorkoutPlan>().HasData(workoutPlanFaker.Generate(10));

        var systemAdminFaker = new Faker<SystemAdmin>()
            .RuleFor(sa => sa.sysad_id, f => f.IndexFaker + 1)
            .RuleFor(sa => sa.sysad_username, f => "gymanysysadmin") // Fixed username as "admin"
            .RuleFor(sa => sa.sysad_password, f => "gymanysysadmin@123") // Fixed password as "123"
            .RuleFor(sa => sa.sysad_name, f => f.Name.FullName()) // Random full name
            .RuleFor(sa => sa.sysad_age, f => f.Date.Past(30, DateTime.Now.AddYears(-18))) // Birthdate between 18 and 48 years ago
            .RuleFor(sa => sa.sysad_email, f => f.Internet.Email()); // Random email address
        modelBuilder.Entity<SystemAdmin>().HasData(systemAdminFaker.Generate(10));

        var categoryFaker = new Faker<Category>()
            .RuleFor(c => c.cate_id, f => f.IndexFaker + 1)
            .RuleFor(c => c.cate_type, f => f.Commerce.Categories(1)[0]) // Random category type from the Faker library
            .RuleFor(c => c.cate_img, f => f.Image.PicsumUrl()) // Random image URL
            .RuleFor(c => c.cate_description, f => f.Lorem.Paragraph()); // Random description paragraph
        modelBuilder.Entity<Category>().HasData(categoryFaker.Generate(10));

        var customerFaker = new Faker<Customer>()
            .RuleFor(c => c.cus_id, f => f.IndexFaker + 1)
            .RuleFor(c => c.cus_username, f => "gymanycus") // Random username
            .RuleFor(c => c.cus_password, f => "gymanycus@123") // Random password
            .RuleFor(c => c.cus_name, f => f.Name.FullName()) // Random full name
            .RuleFor(c => c.cus_address, f => f.Address.StreetAddress()) // Random full address
            .RuleFor(c => c.cus_age, f => f.Date.Past(30, DateTime.Now.AddYears(-18))) // Random age between 18 and 48 years ago
            .RuleFor(c => c.cus_image, f => f.Image.PicsumUrl()) // Random image URL
            .RuleFor(c => c.cus_phone, f => f.Phone.PhoneNumber("(###) ###-####")) // Random phone number
            .RuleFor(c => c.cus_email, f => f.Internet.Email()); // Random email address
        modelBuilder.Entity<Customer>().HasData(customerFaker.Generate(5));

        var exerciseFaker = new Faker<Exercise>()
            .RuleFor(e => e.exc_id, f => f.IndexFaker + 1) // Auto-incrementing ID
            .RuleFor(e => e.exc_title, f => f.Lorem.Sentence(3)) // Random title with 3 words
            .RuleFor(e => e.exc_description, f => {
        var description = f.Lorem.Paragraph();
            return description.Length > 50 ? description.Substring(0, 50) : description;
        })
            .RuleFor(e => e.exc_guide, f => f.Lorem.Sentence(5)) // Random guide with 5 words
            .RuleFor(e => e.exc_video, f => f.Internet.Url()); // Random video URL
        modelBuilder.Entity<Exercise>().HasData(exerciseFaker.Generate(10)); 

        var lessionFaker = new Faker<Lession>()
            .RuleFor(l => l.lession_id, f => f.IndexFaker + 1) // Auto-incrementing ID
            .RuleFor(l => l.lession_context, f => f.Lorem.Paragraph().Substring(0, 50)) // Random context for the lesson
            .RuleFor(l => l.lesson_topic, f => f.Lorem.Sentence(3)) // Random topic with 3 words
            .RuleFor(l => l.course_id, f => f.Random.Int(1, 10)); // Assuming Course IDs range from 1 to 10
        modelBuilder.Entity<Lession>().HasData(lessionFaker.Generate(10));

        
        var personalTrainerFaker = new Faker<PersonalTrainer>()
            .RuleFor(pt => pt.pt_id, f => f.IndexFaker + 1)
            .RuleFor(pt => pt.pt_username, f => "gymanypt")
            .RuleFor(pt => pt.pt_password, f => "gymanypt@123")
            .RuleFor(pt => pt.pt_name, f => f.Name.FullName())
            .RuleFor(pt => pt.pt_age, f => f.Date.Past(30, DateTime.Now.AddYears(-25)))
            .RuleFor(pt => pt.pt_address, f => {
        var address = f.Address.FullAddress();
        return address.Length > 50 ? address.Substring(0, 50) : address;})
            .RuleFor(pt => pt.pt_salary, f => f.Finance.Amount(2000, 10000))
            .RuleFor(pt => pt.pt_email, f => f.Internet.Email())
            .RuleFor(pt => pt.pt_phone, f => f.Phone.PhoneNumber("(###) ###-####"))
            .RuleFor(pt => pt.pt_img, f => f.Image.PicsumUrl());
        var personalTrainers = personalTrainerFaker.Generate(5);
        modelBuilder.Entity<PersonalTrainer>().HasData(personalTrainers);

        // Seed Notifications and ensure `pt_id` matches valid `PersonalTrainer` IDs
        var notificationFaker = new Faker<Notification>()
            .RuleFor(n => n.noti_id, f => f.IndexFaker + 1)
            .RuleFor(n => n.noti_date, f => f.Date.Recent())
            .RuleFor(n => n.noti_context, f => f.Lorem.Sentence(10))
            .RuleFor(n => n.noti_type, f => f.PickRandom(new[] { "Info", "Warning", "Alert" }))
            .RuleFor(n => n.cus_id, f => 1) // Assuming Customer IDs are between 1 and 10
            .RuleFor(n => n.pt_id, f => 1); // Use valid PersonalTrainer IDs
        modelBuilder.Entity<Notification>().HasData(notificationFaker.Generate(10));
        }
    }
}



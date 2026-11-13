using Microsoft.EntityFrameworkCore;
using TrainingItDiv2023Api.Classes.Models;

namespace TrainingItDiv2023Api.Classes
{
    public sealed class DbContextSchool(DbContextOptions<DbContextSchool> options) : DbContext(options)
    {
        public DbSet<Gender> Gender { get; set; }

        public DbSet<Grade> Grade { get; set; }

        public DbSet<Religion> Religion { get; set; }

        public DbSet<Student> Student { get; set; }

        public DbSet<Subject> Subject { get; set; }

        public DbSet<Transaction> Transaction { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Academy2.Models;

namespace Academy2.Data
{
    public class Academy2Context : DbContext
    {
        public DbSet<Academy2.Models.Teacher> Teacher { get; set; } = default!;

        public Academy2Context(DbContextOptions<Academy2Context> options)
            : base(options)
        {
        }

        public DbSet<Academy2.Models.Direction> Directions { get; set; } = default!;
        public DbSet<Academy2.Models.Group> Groups { get; set; } = default!;
        public DbSet<Academy2.Models.Student> Students { get; set; } = default!;
        public DbSet<Academy2.Models.Discipline> Disciplines { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Disciplines)
                .WithMany(d => d.Teachers)
                .UsingEntity<Dictionary<string, object>>(
                    "TeachersDisciplinesRelation",
                    j => j.HasOne<Discipline>().WithMany().HasForeignKey("discipline"),
                    j => j.HasOne<Teacher>().WithMany().HasForeignKey("teacher"),
                    j => j.ToTable("TeachersDisciplinesRelation")
                );
        }
    }
}    
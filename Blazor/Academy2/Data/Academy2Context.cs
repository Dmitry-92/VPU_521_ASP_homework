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
        public DbSet<Academy2.Models.Discipline> Disciplines { get; set; } = default!;
        public Academy2Context (DbContextOptions<Academy2Context> options)
            : base(options)
        {
        }

        public DbSet<Academy2.Models.Direction> Directions { get; set; } = default!;
        public DbSet<Academy2.Models.Group> Groups { get; set; } = default!;
        public DbSet<Academy2.Models.Student> Students { get; set; } = default!;
        public DbSet<Academy2.Models.Teacher> Teachers { get; set; } = default!;
        public DbSet<Academy2.Models.TeachersDisciplinesRelation> TeachersDisciplinesRelation { get; set; } = default!;
        public DbSet<Academy2.Models.DependentDiscipline> DependentDisciplines { get; set; } = default!;
        public DbSet<Academy2.Models.RequiredDiscipline> RequiredDisciplines { get; set; } = default!;
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Составной ключ для DependentDiscipline
            modelBuilder.Entity<DependentDiscipline>()
                .HasKey(dd => new { dd.discipline, dd.dependent_discipline });

            // Составной ключ для RequiredDiscipline
            modelBuilder.Entity<RequiredDiscipline>()
                .HasKey(rd => new { rd.discipline, rd.required_discipline });
        }
    }
}
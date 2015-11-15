using System.Data.Common;
using System.Data.Entity;
using UniPlanner.Entities;

namespace UniPlanner.DBContext
{
    public class BaseContext : DbContext
    {
        #region Constructors

        public BaseContext()
            : base("DefaultConnection")
        {
        }
        public BaseContext(DbConnection context)
            : base(context, true)
        {
        }

        #endregion

        #region Public Property

        public DbSet<Building> Buildings { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Day> Days { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<LessonType> LessonTypes { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Sequence> Sequences { get; set; }

        public DbSet<StudentGroup> StudentGroups { get; set; }

        public DbSet<Univer> Univers { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<WeekType> WeekTypes { get; set; }
      
        #endregion

    }
}
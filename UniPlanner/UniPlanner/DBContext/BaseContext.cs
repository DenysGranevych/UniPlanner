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

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<Sequence> Sequences { get; set; }

        public DbSet<WeekType> WeekTypes { get; set; }

        public DbSet<LessonType> LessonTypes { get; set; }

        public DbSet<Day> Days { get; set; }

        public DbSet<Course> Courses { get; set; }

        #endregion

    }
}
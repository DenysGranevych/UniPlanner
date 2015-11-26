using System;
using UniPlanner.Entities;
using UniPlanner.Enums;

namespace UniPlanner.DTO
{
    public class LessonDto
    {
        public virtual Guid Id { get; set; }

        #region Navigation Properties

        public  Sequence Sequence { get; set; }

        public  LessonType LessonType { get; set; }

        public  Day Day { get; set; }

        public  WeekType WeekType { get; set; }

        public  Course Course { get; set; }

        public  Room Room { get; set; }

        public  StudentGroup StudentGroup { get; set; }

        #endregion

        public bool IsActive { get; set; }

        public SemesterEnum Semester { get; set; }

        public DateTime ActualYear { get; set; }
    }
}

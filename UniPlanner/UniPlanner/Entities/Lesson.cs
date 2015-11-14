using System;
using System.ComponentModel.DataAnnotations.Schema;
using UniPlanner.Entities.Base;
using UniPlanner.Enums;

namespace UniPlanner.Entities
{
    public class Lesson : BaseEntity
    {

        #region ForeignKeys

        public Guid SequenceId { get; set; }

        public Guid LessonTypeId { get; set; }

        public Guid DayId { get; set; }

        public Guid WeekTypeId { get; set; }

        public Guid CourseId { get; set; }

        [ForeignKey("SequenceId")]
        public virtual Sequence Sequence { get; set; }

        [ForeignKey("LessonTypeId")]
        public virtual LessonType LessonType { get; set; }

        [ForeignKey("DayId")]
        public virtual Day Day { get; set; }

        [ForeignKey("WeekTypeId")]
        public virtual WeekType WeekType { get; set; }

        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
        #endregion

        public bool IsActive { get; set; }

        public SemesterEnum Semester { get; set; }
    }
}
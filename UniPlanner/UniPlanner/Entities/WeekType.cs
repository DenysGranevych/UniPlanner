using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UniPlanner.Entities.Base;
using UniPlanner.Enums;

namespace UniPlanner.Entities
{
    public class WeekType : BaseEntity
    {
        [Required]
        public WeekEnum WeekName { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; } 
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UniPlanner.Entities.Base;

namespace UniPlanner.Entities
{
    public class Day : BaseEntity
    {
        [Required]
        public string DayName { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; } 
    }
}
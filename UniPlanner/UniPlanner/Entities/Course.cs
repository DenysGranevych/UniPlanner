using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UniPlanner.Entities.Base;

namespace UniPlanner.Entities
{
    public class Course : BaseEntity
    {
        [Required]
        public string CourseName { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; } 
    }
}
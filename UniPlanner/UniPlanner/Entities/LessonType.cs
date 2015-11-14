using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UniPlanner.Entities.Base;

namespace UniPlanner.Entities
{
    public class LessonType : BaseEntity
    {
        [Required]
        public string TypeName { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
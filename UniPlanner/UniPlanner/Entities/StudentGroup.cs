using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UniPlanner.Entities.Base;

namespace UniPlanner.Entities
{
    public class StudentGroup : BaseEntity
    {
        [Required]
        public string StudentGroupName { get; set; }

        [Required]
        public DateTime StartYear { get; set; }

        public ICollection<Lesson> Lessons { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
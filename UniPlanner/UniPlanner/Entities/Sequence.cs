using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UniPlanner.Entities.Base;

namespace UniPlanner.Entities
{
    public class Sequence : BaseEntity
    {
        [Required]
        public string SequenceName { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
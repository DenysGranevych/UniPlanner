using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UniPlanner.Entities.Base;

namespace UniPlanner.Entities
{
    public class Room : BaseEntity
    {
        [Required]
        public string RoomName { get; set; }

        public Guid BuildingId { get; set; }

        public virtual Building Building { get; set; }

        public ICollection<Lesson> Lessons { get; set; }
    }
}
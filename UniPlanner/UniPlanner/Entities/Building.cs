using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UniPlanner.Entities.Base;

namespace UniPlanner.Entities
{
    public class Building : BaseEntity
    {
        [Required]
        public string BuildingName { get; set; }

        public string Address { get; set; }

        public Guid UniverId { get; set; }

        public virtual Univer Univer { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }  
    }
}
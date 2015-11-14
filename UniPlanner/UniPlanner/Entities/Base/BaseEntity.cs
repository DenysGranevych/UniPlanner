using System;
using System.ComponentModel.DataAnnotations;

namespace UniPlanner.Entities.Base
{
    public class BaseEntity
    {
        [Required]
        public virtual Guid Id { get; set; }
    }
}

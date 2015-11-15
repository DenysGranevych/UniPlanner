using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UniPlanner.Entities.Base;

namespace UniPlanner.Entities
{
    public class User : BaseEntity
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        public string Email { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        public virtual ICollection<StudentGroup> StudentGroups { get; set; }
    }
}
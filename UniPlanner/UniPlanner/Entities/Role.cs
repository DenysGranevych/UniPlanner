using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UniPlanner.Entities.Base;
using UniPlanner.Enums;

namespace UniPlanner.Entities
{
    public class Role : BaseEntity
    {
        [Required]
        public RoleEnum RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
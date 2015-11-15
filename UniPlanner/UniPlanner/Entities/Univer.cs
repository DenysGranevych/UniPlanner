using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UniPlanner.Entities.Base;

namespace UniPlanner.Entities
{
    public class Univer : BaseEntity
    {
        [Required]
        public string UniverName { get; set; }

        public virtual ICollection<Building> Buildings { get; set; }  
    }
}
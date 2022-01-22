using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TechTree.Interfaces;


namespace TechTree.Entities
{
    public class Category: IPrimaryProperties
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        [Display(Name = "Thumbnail Image Path")]
        public string ImagePath { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ICollection<UserCategory> UserCategory { get; set; }

    }
}

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechTree.Entities
{
    public class CategoryItem
    {
        private DateTime _releaseDate = DateTime.MinValue;
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage ="Please Select a Valid Item From the '{0}' Dropdown List")]
        [Display(Name = "Media Type")]
        public int MediaTypeId { get; set; }
        [NotMapped]
        public virtual ICollection<SelectListItem> MediaTypes { get; set; }
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Release Date")]
        public DateTime DateTimeItemReleased {
            get 
            {
                return (_releaseDate == DateTime.MinValue) ? DateTime.Now : _releaseDate;
            }
            set
            {
                _releaseDate = value;
            }
        }
        [NotMapped]
        public int ContentId { get; set; }

    }
}

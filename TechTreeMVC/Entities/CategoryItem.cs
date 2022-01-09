using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechTreeMVC.Entities
{
    public class CategoryItem
    {
        private DateTime _releaseDate = DateTime.MinValue; //to get today's date
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }

        public string Description { get; set; }
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Please select a valid item from the '{0}' dropdown list!")]
        [Display(Name ="Media Type")]
        public int MediaTypeId { get; set; }

        [NotMapped]
        public virtual ICollection<SelectListItem> MediaTypes { get; set; }//we added this so we can have a dropdown of article or video
        [NotMapped]
        public int ContentId { get; set; } //we added the Notmapped so when we created a migration the EFcore will ignore this property
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}")]
        [Display(Name = "Release Date")]
        public DateTime DateTimeItemReleased 
        { 
            get
            {
                return (_releaseDate == DateTime.MinValue) ? DateTime.Now : _releaseDate;//this will return todays date if datetime has not been set 
            }
            set
            {
                _releaseDate = value;
            }
        
        
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CmsCoreIdentity.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ScaffoldColumn(false)]
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }

        [Required]
        [StringLength(100)]
        public string Subject { get; set; }

        [StringLength(3000)]
        public string Body { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public DateTime PublcationDate { get; set; }

        [StringLength(100)]
        [Display(Name = "Author name")]
        public string AuthorName { get; set; }

        [ScaffoldColumn(false)]
        public int Readers { get; set; }

        [Url]
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
    }
}

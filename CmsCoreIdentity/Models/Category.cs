using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CmsCoreIdentity.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "you must enter category name.")]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core5CRUDApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Nama Category")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="Display Order for Category Must be greater than 0")]
        public int DisplayOrder { get; set; }
    }
}

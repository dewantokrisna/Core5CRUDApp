using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core5CRUDApp.Models
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Nama Application Type")]
        public string Name { get; set; }

    }
}

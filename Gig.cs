using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MBKeysMusic.Models
{
    public class Gig
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [DataType(DataType.Currency)]
        public decimal Payment { get; set; }

        [Display(Name = "Performance Date")]
        [DataType(DataType.Date)]
        public DateTime PerformanceDate { get; set; }

        [Range(1, 10)]
        [Required]
        public int Practices { get; set; }
    }
}

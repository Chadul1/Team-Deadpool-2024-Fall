using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Aquariums
    {
        [Key]
        [Column(TypeName = "char(36)")]
        public Guid AquariumID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(75)]
        public string Location { get; set; }

        [Required]
        [StringLength(10)]
        public string Hours { get; set; }
    }
}

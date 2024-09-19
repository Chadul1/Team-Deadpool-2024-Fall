using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    /// <summary>
    /// A class that represents a species object.
    /// </summary>
     public class Species
    {
        [Key]
        [Column(TypeName = "char(36)")]
        public required Guid SpeciesID { get; set; }

        [Required]
        [StringLength(50)]
        public required string Name { get; set; }

        [Required]
        [StringLength(50)]
        public required string Colors { get; set; }

        [Required]
        [StringLength(150)]
        public required string Habitat { get; set; }

        [Required]
        [StringLength(150)]
        public required string Diet { get; set; }
    }
}

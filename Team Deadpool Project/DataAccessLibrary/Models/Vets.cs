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
    /// Represents a vet in the Aquarium.
    /// </summary>
    public class Vets
    {
        [Key]
        [Column(TypeName = "char(36)")]
        public required Guid VetID { get; set; }

        [Required]
        [Column(TypeName = "char(36)")]
        public required Guid AquariumID { get; set; } 

        [Required]
        [Column(TypeName = "char(36)")]
        public required Guid ContactInformation { get; set; }

        public Contacts Contact { get; set; }

        [Required]
        [StringLength(50)]
        public required string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public required string LastName { get; set; }
    }
}

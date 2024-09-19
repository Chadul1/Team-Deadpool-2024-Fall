using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Animal
    {
        [Key]
        [Column(TypeName = "char(36)")]
        public Guid AnimalID { get; set; }
        
        [Required]
        [Column(TypeName = "char(36)")]
        public Guid TankID { get; set; }

        [Required]
        [Column(TypeName = "char(36)")]
        public Guid VetID { get; set; }

        [Required]
        [Column(TypeName = "char(36)")]
        public Guid SpeciesID { get; set; }

        [Required]
        [StringLength(50)]
        public required string Name { get; set; }

        public ICollection<TankMovements> TankMovements { get; set; }

    }
}

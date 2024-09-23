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
    /// This class Follows the movements of the animals.
    /// </summary>
    public class TankMovements
    {
        [Key]
        [Column(TypeName = "char(36)")]
        public required Guid MovementId { get; set; }

        [Required]
        [Column(TypeName = "char(36)")]
        public required Guid AnimalID { get; set; }

        [Required]
        [StringLength(50)]
        public required string CurrentTank { get; set; }

        [Required]
        [StringLength(50)]
        public required string LastTank { get; set; }

        [Required]
        public required DateTime WhenMoved { get; set; }

    }
}

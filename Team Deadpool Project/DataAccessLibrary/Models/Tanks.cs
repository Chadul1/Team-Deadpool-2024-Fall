using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Tanks
    {
        [Key]
        [Column(TypeName = "char(36)")]
        public required Guid TankID { get; set; }

        [Required]
        [Column(TypeName = "char(36)")]
        public required Guid AquariumID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int Size { get; set; }

        public ICollection<WorkersTanks> WorkerTank { get; set; }
    }
}

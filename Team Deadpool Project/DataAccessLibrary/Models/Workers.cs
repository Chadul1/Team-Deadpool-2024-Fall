using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Workers
    {
        [Key]
        [Column(TypeName = "char(36)")]
        public required Guid WorkerID { get; set; }

        [Required]
        [Column(TypeName = "char(36)")]
        public required Guid AquariumID { get; set; }

        [Required]
        [Column(TypeName = "char(36)")]
        public required Guid ContactInformation { get; set; }

        /// <summary>
        /// The contact information for the worker. 
        /// </summary>
        public Contacts Contact { get; set; }

        [Required]
        [Column(TypeName = "char(36)")]
        public required Guid PositionID { get; set; }

        /// <summary>
        /// The workers position in the Aquarium.
        /// </summary>
        [NotMapped]
        public Positions Position { get; set; }

        [Required]
        [StringLength(50)]
        public required string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public required string LastName { get; set; }

        [Required]
        public required int Years_of_Experience { get; set; }

        public ICollection<WorkersTanks> WorkerTank { get; set; }
    }
}

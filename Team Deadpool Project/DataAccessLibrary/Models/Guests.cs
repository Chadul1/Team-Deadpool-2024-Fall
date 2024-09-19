using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Guests
    {
        [Key]
        [Column(TypeName = "char(36)")]
        public Guid GuestID { get; set; }

        [Required]
        [Column(TypeName = "char(36)")]
        public Guid AquariumID { get; set; }

        [Required]
        [StringLength(50)]
        public required string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public required string LastName { get; set; }

        public ICollection<GuestsTickets> GuestsTickets { get; set; }
    }
}

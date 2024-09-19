using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class GuestsTickets
    {
        [Key]
        [Column(TypeName = "char(36)")]
        public Guid GuestsTicketsID { get; set; }

        [Required]
        [Column(TypeName = "char(36)")]
        public Guid TicketID { get; set; }

        [Required]
        [Column(TypeName = "char(36)")]
        public Guid GuestID { get; set; }

        public Tickets tickets { get; set; }
        public Guests guests { get; set; }
    }
}

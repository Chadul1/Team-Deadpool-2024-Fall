using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Tickets
    {
        [Key]
        [Column(TypeName = "char(36)")]
        public Guid TicketID { get; set; }

        [Required]
        public bool IsUsed { get; set; }

        public ICollection<GuestsTickets> GuestsTickets { get; set; }
    }
}

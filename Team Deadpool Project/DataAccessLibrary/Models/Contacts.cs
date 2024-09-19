using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccessLibrary.Models
{
    /// <summary>
    /// An object that represents a contact for a worker/vet.
    /// </summary>
    public class Contacts
    { 
        [Key]
        [Column(TypeName = "char(36)")]
        public Guid ContactID { get; set; }

        [Required]
        [StringLength(22)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }
    }
}

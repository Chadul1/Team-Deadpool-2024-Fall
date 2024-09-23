using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    /// <summary>
    /// Represents the Worker's position table.
    /// </summary>
    public  class Positions
    {
        [Key]
        [Column(TypeName = "char(36)")]
        public required Guid PositionID { get; set; }
        
        [Required]
        [StringLength(30)]
        public string PositionTitle { get; set; }  
    }
}

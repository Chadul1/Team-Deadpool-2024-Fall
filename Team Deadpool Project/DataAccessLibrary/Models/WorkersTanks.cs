using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class WorkersTanks
    {
        [Key]
        [Column(TypeName = "char(36)")]
        public Guid WorkersTanksID { get; set; }
        
        [Required]
        [Column(TypeName = "char(36)")]
        public Guid WorkerID { get; set; }
        
        [Required]
        [Column(TypeName = "char(36)")]
        public Guid TankID { get; set; }

        public Tanks Tank { get; set; }

        public Workers Worker { get; set; }

    }
}

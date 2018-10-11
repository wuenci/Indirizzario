using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indirizzario.Db.Models
{
    [Table("Address")]
    public class Address
    {
        public int Id { get; set; }

        [StringLength(150)]
        public String Street { get; set; }

        [Required]
        [StringLength(10)]
        public String Postcode { get; set; }

        [Required]
        [StringLength(150)]
        public String Town { get; set; }

        public String State { get; set; }

        public String Regione { get; set; }

        [Required]
        [StringLength(150)]
        public String Country { get; set; }

        public int PersonId { get; set; }

    }
}

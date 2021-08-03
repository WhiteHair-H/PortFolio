using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPortFolio.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [StringLength(50)]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Text)]
        public string Contents { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Regdate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Models {
    public class Contact {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Number { get; set; }
        [Required]
        public string Designation { get; set; }
        public string Email { get; set; }        
        public string DOB { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; }

        public List<Numbers> NumbersList { get; set; }
    }
}

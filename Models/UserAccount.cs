using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace samplewebapi.Models
{
    public class UserAccount
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desgnation { get; set; }
        public int Salary { get; set; }
    }
}

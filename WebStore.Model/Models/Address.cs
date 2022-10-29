using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string StreetName { get; set; } = default!;
        public string City { get; set; } = default!;

    }
}
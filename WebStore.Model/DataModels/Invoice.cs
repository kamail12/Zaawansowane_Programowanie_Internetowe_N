using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.DataModels
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string IssuedFor { get; set; } = default!;
        public string IssuedBy { get; set; } = default!;

    }
}
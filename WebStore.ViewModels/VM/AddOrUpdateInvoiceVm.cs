using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WebStore.ViewModels.VM
{
    public class AddOrUpdateInvoiceVm
    {
        public int? Id { get; set; }
        [Required]
        public DateTime DateOfIssue { get; set; }




    }
}
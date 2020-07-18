using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IDServer.Models
{
    public class Supplier : BaseEntity
    {
        public string PhoneNo { get; set; }
    }
}

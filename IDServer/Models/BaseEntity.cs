using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IDServer.Models
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; } = false;

        public DateTimeOffset CreatedDT { get; set; } = DateTimeOffset.MinValue;

        public DateTimeOffset DeletedDT { get; set; } = DateTimeOffset.MinValue;

        public DateTimeOffset LastUpdatedDT { get; set; } = DateTimeOffset.MinValue;
    }
}

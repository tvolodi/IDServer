using System;
using System.Collections.Generic;
using System.Text;

namespace IDCommon
{
    public class BaseEntityDTO
    {
        public long Id { get; set; }

        public bool IsDeleted { get; set; }

        public string Name { get; set; }

        public DateTimeOffset CreatedDT { get; set; }

        public DateTimeOffset DeletedDT { get; set; }

        public DateTimeOffset LastUpdatedDT { get; set; }
    }
}

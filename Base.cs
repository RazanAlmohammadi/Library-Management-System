using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Base
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }

        public Base(DateTime? createdDate = null)
        {
            Id = Guid.NewGuid();
            CreatedDate = createdDate ?? DateTime.Now;
        }
    }
}

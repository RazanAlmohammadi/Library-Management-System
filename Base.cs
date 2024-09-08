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

        public Base()
        {
            Id = Guid.NewGuid(); 
            CreatedDate = DateTime.Now; 
        }
    }
}

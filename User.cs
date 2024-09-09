using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class User : Base
    {
        public string Name { get; set; }
        public User(string name, DateTime? createdDate = null) : base(createdDate)
        {
            Name = name;
        }
    }
}
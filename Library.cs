using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Library
    {
        public string Name { get; set; }
        public Library(string name) : base()
        {
            Name = name;
        }

    }
}
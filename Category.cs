using System;
using System.Collections.Generic;
using System.Text;

namespace EF_CORE_01
{
    internal class Category
    {
        public int Id { get; set; } 

        public string name { get; set; }    
        public string description { get; set; }
        public bool isActive { get; set; }  

    }
}

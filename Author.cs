using System;
using System.Collections.Generic;
using System.Text;

namespace EF_CORE_01
{
    internal class Author
    {

        public int Id { get; set; }
        public string frstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }   
        public string Bio { get; set; }
        public DateTime dateOfBirth { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EF_CORE_01
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN   { get; set; }
        public decimal Price { get; set; }
        public int numberOfPages { get; set; }
        public int YearOfPublication { get; set; }
        public bool inStock { get; set; }
    }
}

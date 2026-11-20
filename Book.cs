using System;
using System.Collections.Generic;
using System.Text;

namespace C50_GSat_Basics02
{
    internal class Book
    {
        public string title;
        public int pages;

        public override string ToString()
        {
            return $"{title} , {pages}";
        }
    }
}

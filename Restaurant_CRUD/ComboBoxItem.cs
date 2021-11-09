using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_CRUD
{
    public class ComboBoxItem
    {

         public string Texto { get; set; }
         public Object Value { get; set; }

        public override string ToString()
        {
            return Texto;
        }

    }
}

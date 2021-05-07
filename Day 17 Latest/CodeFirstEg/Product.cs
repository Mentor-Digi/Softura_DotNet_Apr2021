using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeFirstEg
{
    class Product
    {
        [Key]
        public int PId { get; set; }
        public string PName { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }

        public override string ToString()
        {
            return String.Format(PId + " " + PName + "  " + Price + "  " + Qty);
        }

    }
}

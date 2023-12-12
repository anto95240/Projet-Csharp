using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Csharp
{
    public class cart_Table
    {
        [Key]
        public int CartId { get; set; }

        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public string Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Csharp.Class_db
{
    public class Invoices_Table
    {
        [Key]
        public int InvoiceId { get; set; }

        public int UserId { get; set; }

        public int CartId { get; set; }

        public int CommandId { get; set; }

        public int Total { get; set; }

        public string InvoiceDate { get; set; }

    }
}
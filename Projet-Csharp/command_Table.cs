using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Csharp
{
    public class command_Table
    {
        [Key]
        public int CommandId { get; set; }

        public int UserId { get; set; }

        public string CommandDate { get; set; }

        public string CommandStatus { get; set; }

    }
}

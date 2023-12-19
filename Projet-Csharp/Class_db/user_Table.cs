using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Csharp.Class_db
{
    public class user_Table
    {
        [Key]
        public int UserId { get; set; }

        public string Email { get; set; }

        public string Password_hash { get; set; }

    }
}
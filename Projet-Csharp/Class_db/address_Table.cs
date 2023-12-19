﻿using System.ComponentModel.DataAnnotations;

namespace Projet_Csharp.Class_db
{
    public class address_Table
    {
        [Key]
        public int AddressId { get; set; }

        public int UserId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

    }
}
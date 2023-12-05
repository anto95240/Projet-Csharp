using System.ComponentModel.DataAnnotations;

namespace Projet_Csharp
{
    public class address_Table
    {
        [Key]
        public int AddressId { get; set; }

        public int UserId { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int PostalCode { get; set; }

        public string Country { get; set; }

    }
}
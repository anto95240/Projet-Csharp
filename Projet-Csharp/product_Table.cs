using System.ComponentModel.DataAnnotations;

namespace Projet_Csharp
{
    public class product_table
    {
        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Stock_Quantity { get; set; }

    }
}

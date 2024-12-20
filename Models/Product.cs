﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
    public class Product
    {
        // [Key] -> Anotación si la propiedad no se llama Id, ejemplo ProductId
        public int Id { get; set; } // Sera la llave priamaria
        public string Name { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; } //Sera la llave foranea

	    public Category? Category { get; set; } = default; // Propiedad de navegacion
		//public ICollection<Category> Categories { get; set; } = default; // Propiedad de navegacion

		// public ICollection<Product>? Products { get; set; } = default; // Propiedad de navegacion
	}
}

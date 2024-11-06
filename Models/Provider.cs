namespace SupermarketWEB.Models
{
	public class Provider
	{
		public int Id { get; set; } // Sera la llave priamaria (Opcional)
		public string Name { get; set; }
		public string Address { get; set; }
		public string Birthday { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
	}
}

namespace SupermarketWEB.Models
{
	public class PayMode
	{
		public int Id { get; set; } // Será la llave primaria
		public string? Name { get; set; } = default;
		public string? Observation { get; set; }
	}	
}

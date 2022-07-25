using System.ComponentModel.DataAnnotations;

namespace RTXWebsite1.Models
{
	public class Marketplace
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Cost { get; set; }
	
	}
}
using System.ComponentModel.DataAnnotations;

namespace RTXWebsite1.Models
{
	public class Marketplace
	{
		public int Transaction_ID { get; set; }

		public int Course_ID { get; set; }

		public int Transaction_Cost { get; set; }

		public string? Transaction_Name { get; set; }

		public string? Transaction_Description { get; set; }
	
	}
}
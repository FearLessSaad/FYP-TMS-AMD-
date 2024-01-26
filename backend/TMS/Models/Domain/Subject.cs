using System.ComponentModel.DataAnnotations;

namespace TMS.Models.Domain
{
	public class Subject
	{
		[Key]
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Code { get; set; }
		public int Ch { get; set; }
		public DateTime CreatedAt { get; set; }
#nullable enable
		public DateTime? UpdatedAt { get; set; }
	}
}


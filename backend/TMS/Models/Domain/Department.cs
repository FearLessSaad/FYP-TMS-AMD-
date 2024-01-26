using System.ComponentModel.DataAnnotations;

namespace TMS.Models.Domain
{
    public class Department
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
#nullable enable
        public DateTime? UpdatedAt { get; set; }
    }
}

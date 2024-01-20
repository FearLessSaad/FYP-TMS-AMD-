using System.ComponentModel.DataAnnotations;

namespace TMS.Models.Domain
{
    public class Department
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Timestamp]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}

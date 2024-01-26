
using System.ComponentModel.DataAnnotations;

namespace TMS.Models.Domain
{
    public class Faculty
    {
        [Key]
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string CNIC { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }
        public Department Department { get; set; }
#nullable enable
        public string? Subject { get; set; }
#nullable disable
        public Int64 Salary { get; set; }
        public DateTime CreatedAt { get; set; }
#nullable enable
        public DateTime? UpdatedAt {get; set; }
    }
}


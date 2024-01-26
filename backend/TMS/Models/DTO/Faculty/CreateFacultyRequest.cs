using System.ComponentModel.DataAnnotations;

namespace TMS.Models.DTO.Faculty
{
	public class CreateFacultyRequest
	{
        [Required]
        [MinLength(3)]
        [MaxLength(40)]
        public string FullName { get; set; }
        [Required]
        [MinLength(13)]
        [MaxLength(15)]
        public string CNIC { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(1000)]
        public string Address { get; set; }
        [Required]
        public Int64 Salary { get; set; }
        public bool Gender { get; set; }
    }
}


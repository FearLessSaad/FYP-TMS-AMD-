using System.ComponentModel.DataAnnotations;

namespace TMS.Models
{
    public class Designation
    {
        [Key]
        public Int64 des_id { get; set; }

        [Required]
        [MaxLength(30)]
        public string des_name { get; set; }

        [Required]
        public Int64 des_scale { get; set; }

        [Timestamp]
        public DateTime created_at { get; set; }
    }
}

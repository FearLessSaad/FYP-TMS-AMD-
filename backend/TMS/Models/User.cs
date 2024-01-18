using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TMS.Models;

namespace TMS.Models
{
    public class User
    {
        [Key]
        public int uid { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(100)]
        public string user_name { get; set; }

        [Required]
        [MinLength(13)]
        [MaxLength(16)]
        public string cnic { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(7)]
        public string gender { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(50)]
        public string email { get; set; }

        [Required]
        [ForeignKey("des_id")]
        public int des_id { get; set; }
        public virtual Designation Designation { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(255)]
        public string address { get; set; }

        [Required]
        public string role { get; set; }

        [Timestamp]
        public DateTime created_at { get; set; }
    }
}

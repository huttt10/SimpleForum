using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleForum.Models
{
    public class Contribution
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }

        [ForeignKey("Forum")]
        public int ForumForeignKey { get; set; }
        public Forum Forum { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string Contetent { get; set; }

    }
}
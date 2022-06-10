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

        public string Contetent { get; set; }

    }
}
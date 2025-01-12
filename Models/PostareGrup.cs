using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_Life.Models
{
    public class PostareGrup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int GrupId { get; set; }
        public string UserId { get; set; }
        public string Text { get; set; }
        public string? Imagine { get; set; }
        public DateTime Data { get; set; }

        public virtual Grup Grup { get; set; }
        public virtual Profile Profile { get; set; }

    }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_Life.Models
{
    public class Grup_Membrii
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual Profile Profile { get; set; }
        public int GrupId { get; set; }
        public virtual Grup Grup { get; set; }
        public DateTime Data { get; set; }
    }
}

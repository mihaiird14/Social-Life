using System.ComponentModel.DataAnnotations;

namespace Social_Life.Models
{
    public class Grup
    {
        [Key]
        public int GrupId { get; set; } 
        public string GrupName { get; set; }
        public string AdminGrupId { get; set; }
        public virtual Profile Profile { get; set; }
        public string GrupImagine { get; set; }
        public bool GrupPublic { get; set; } = true;
        public DateTime DataGr { get; set; }
        public virtual ICollection<Grup_Membrii>? GrupMembrii { get; set; }
    }
}

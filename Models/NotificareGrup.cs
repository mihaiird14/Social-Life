using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_Life.Models
{
    public class NotificaticareGrup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NotificationId { get; set; }
        [Required]

        public string Id_User { get; set; }

        public virtual Profile Profile { get; set; }
        [Required]
        public int GrupId { get; set; }
        [Required]
        public string NotificationType { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; } = false;
        public bool Accepted { get; set; }
        public DateTime Date { get; set; }
    }
}

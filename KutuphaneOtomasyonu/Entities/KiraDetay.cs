using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entities
{
    [Table("KiraDetaylar")]
    public class KiraDetay
    {
        [Key]
        public int KiraDetayId { get; set; }

        [Required]
        public int KiraID { get; set; }

        [Required]
        [ForeignKey("KiraID")]
        public virtual Kiralanan Kiralanan { get; set; }


        public TimeSpan KiralananGun { get; set; } = (TimeSpan)(Kiralanan.VerisTarihi - Kiralanan.AlisTarihi);

    }
}

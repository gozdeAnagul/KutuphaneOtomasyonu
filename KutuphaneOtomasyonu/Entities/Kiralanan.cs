using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entities
{
    [Table("Kiralananlar")]
    public class Kiralanan
    {
        [Key]
        public int KiraID { get; set; }

        [Required]
        public int UyeID { get; set; }

        [Required]
        [ForeignKey("UyeID")]
        public virtual Uye Uye { get; set; }

        [Required]
        public static DateTime AlisTarihi { get; set; } = DateTime.Now.Date;

        public static DateTime? VerisTarihi { get; set; }

        public virtual ICollection<Kitap> Kitaps { get; set; } = new HashSet<Kitap>();

    }
}

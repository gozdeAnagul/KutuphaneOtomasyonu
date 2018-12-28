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
        //[Key]
        //[Column(Order =1)]
        //public int KiraID { get; set; }

        //[Key]
        //[Column(Order =2)]
        //public int KitapID { get; set; }

        //public static DateTime AlisTarihi { get; set; } = DateTime.Now.Date;

        //public static DateTime? VerisTarihi { get; set; } 

        //public virtual ICollection<Kitap> Kitaps { get; set; } = new HashSet<Kitap>();    

        //[ForeignKey("UyeID")]
        //public virtual Uye Uye { get; set; }

        //[ForeignKey("KitapID")]
        //public virtual Kitap Kitap { get; set; }

        [Key]
        public int KiraID { get; set; }

        [Required]
        [ForeignKey("UyeID")]
        public virtual Uye Uye { get; set; }

        [Required]
        [ForeignKey("KitapID")]
        public virtual Kitap Kitap { get; set; }

        [Required]
        public int UyeID { get; set; }

        [Required]
        public int KitapID { get; set; }

        [Required]
        public static DateTime AlisTarihi { get; set; } = DateTime.Now.Date;

        public static DateTime? VerisTarihi { get; set; }

        public virtual ICollection<Kitap> Kitaps { get; set; } = new HashSet<Kitap>();

    }
}

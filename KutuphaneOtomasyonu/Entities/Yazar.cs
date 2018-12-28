using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entities
{
    [Table("Yazarlar")]
    public class Yazar
    {
        [Key]
        public int YazarID { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Yazar adı 20 karakterden fazla olamaz!")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Lütfen sadece Harf kullanın")]
        public string YazarAdi { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Yazar Soyadı 20 karakterden fazla olamaz!")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Lütfen sadece Harf kullanın")]
        public string YazarSoyadi { get; set; }

        public virtual ICollection<Kitap> Kitaps { get; set; }

    }
}

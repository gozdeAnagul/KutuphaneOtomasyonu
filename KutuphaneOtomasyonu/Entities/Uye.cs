using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entities
{
    [Table("Uyeler")]
    public class Uye
    {
        [Key]
        public int UyeID { get; set; }

        [Required]
        [StringLength(20,ErrorMessage ="Üye adı 20 karakterden fazla olamaz!")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Lütfen sadece Harf kullanın")]
        public string UyeAdi { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Üye Soyadı 20 karakterden fazla olamaz!")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Lütfen sadece Harf kullanın")]
        public string UyeSoyadi { get; set; }

        [Required]
        [RegularExpression("^[0-9]*$",ErrorMessage ="Telefon sadece sayılardan oluşmalıdır")]
        [StringLength(11, ErrorMessage = "TCKN 11 karakterden fazla olamaz!")]
        public string UyeTCKN { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Telefon sadece sayılardan oluşmalıdır")]
        [StringLength(11, ErrorMessage = "telefon 11 karakterden fazla olamaz!")]
        public string UyeTelefon { get; set; }

        [StringLength(20, ErrorMessage = "E-Mail 20 karakterden fazla olamaz!")]
        [EmailAddress(ErrorMessage ="Geçersiz E-Mail adresi")]
        public string UyeEMail { get; set; }

        public virtual ICollection<Kiralanan> Kiralanans { get; set; }

    }
}

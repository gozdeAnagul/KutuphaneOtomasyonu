using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entities
{
    [Table("Kitaplar")]
    public class Kitap
    {
        [Key]
        public int KitapID { get; set; }

        [Required]
        [StringLength(50)]       
        public string KitapAdi { get; set; }

        [Required]
        public int YazarID { get; set; }

        [Required]
        [ForeignKey("YazarID")]
        public virtual Yazar Yazar { get; set; }

        [Required]
        public short Stok { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace giữa_kỳ.Data
{
    public class ChiTietDoiKhach
    {
        [Key]
        public int IdTranDau { get; set; }
        [Required]
        public int tysobanthang { get; set; }
        public int sobanthang { get; set; }
        public int iddoibong { get; set; }
        [ForeignKey("iddoibong")]
    } 
}

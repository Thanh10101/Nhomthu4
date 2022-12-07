using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace giữa_kỳ.Data
{
    public class ChiTietCauThuGhiBan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdTranDau { get; set; }
        [ForeignKey("IdTranDau")]
        public int IdCauThu { get; set; }
        [ForeignKey("IdCauThu")]
    }
}

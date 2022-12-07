using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace giữa_kỳ.Data
{
    public class CauThu
    {
        [Key]
        public int IdCauThu { get; set; }
        [Required]
        public int IdDoiBong { get; set; }
        [ForeignKey("IdDoiBong")]
        public string? tenCauThu { get; set; }
        public int soAo { get; set; }
        public string? vitri { get; set; }
    }
}

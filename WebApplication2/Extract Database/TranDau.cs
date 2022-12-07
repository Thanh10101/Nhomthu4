using System.ComponentModel.DataAnnotations;

namespace giữa_kỳ.Data
{
    public class TranDau
    {
        [Key]
        public int IdTranDau { get; set; }
        [Required]
        public int tysoTranDau { get; set; }
        public int sobanthang { get; set; }
    }
}

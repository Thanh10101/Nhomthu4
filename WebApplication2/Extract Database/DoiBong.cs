using System.ComponentModel.DataAnnotations;

namespace giữa_kỳ.Data
{
    public class DoiBong
    {
        [Key]
        public int Iddoibong { get; set; }
        [Required]
        public string? TenDoiBong { get; set; }
        public int SoCauThu { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAPINetCore6.Data
{
    [Table("ThongTinCCCN")]
    public class ThongTinCCCN
    {
        [Key]
        public int Id{ get; set; }
        public int Mssv { get; set; }
        [MaxLength(100)]
        public string HoTen { get; set; }
        [MaxLength(100)]
        public string Khoa { get; set; }
        [MaxLength(100)]
        public string Lop { get; set; }
        [MaxLength(100)]
        public string TenCN { get; set; }
        [MaxLength(100)]
        public string ChucVuNC { get; set; }
        [MaxLength(100)]
        public string TenNC { get; set; }
        [MaxLength(100)]
        public string SoQD { get; set; }
        public DateTime NgayCap { get; set; }
        [MaxLength(100)]
        public string? MoTa { get; set; }
    }
}

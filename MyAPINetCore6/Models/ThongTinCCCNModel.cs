using System.ComponentModel.DataAnnotations;

namespace MyAPINetCore6.Models
{
    public class ThongTinCCCNModel
    {
        public int Id { get; set; }
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

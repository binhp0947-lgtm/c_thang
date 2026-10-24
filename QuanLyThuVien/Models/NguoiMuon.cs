using System.ComponentModel.DataAnnotations;

namespace QuanLyThuVien.Models;

/// <summary>
/// Thực thể Người Mượn (Borrower / Reader)
/// </summary>
public class NguoiMuon
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string HoTen { get; set; } = string.Empty;

    [MaxLength(15)]
    public string SoDienThoai { get; set; } = string.Empty;

    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;

    public DateTime NgayDangKy { get; set; } = DateTime.Now;

    // Quan hệ 1 - N: Một người mượn có thể mượn nhiều cuốn sách
    public List<Sach> DanhSachSachMuon { get; set; } = new();
}

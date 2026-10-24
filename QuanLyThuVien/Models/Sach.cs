using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThuVien.Models;

/// <summary>
/// Thực thể Sách (Book)
/// </summary>
public class Sach
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string TieuDe { get; set; } = string.Empty;

    [MaxLength(100)]
    public string TacGia { get; set; } = string.Empty;

    [MaxLength(50)]
    public string TheLoai { get; set; } = string.Empty;

    public int NamXuatBan { get; set; }

    public int SoLuong { get; set; } = 1;

    // Khóa ngoại liên kết tới Người Mượn (null nếu sách đang nằm trong kho, chưa ai mượn)
    public int? NguoiMuonId { get; set; }

    [ForeignKey(nameof(NguoiMuonId))]
    public NguoiMuon? NguoiMuonHienTai { get; set; }
}

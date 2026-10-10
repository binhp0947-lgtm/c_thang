using System.Collections.Generic;
using QuanLySinhVien.DAL;
using QuanLySinhVien.DTO;

namespace QuanLySinhVien.BLL
{
    public class LopHocBLL
    {
        private readonly LopHocDAL _lopHocDAL = new LopHocDAL();

        public List<LopHoc> LayDanhSachLop() => _lopHocDAL.GetAll();

        public LopHoc LayChiTietLop(string maLop) => _lopHocDAL.GetById(maLop);
    }
}

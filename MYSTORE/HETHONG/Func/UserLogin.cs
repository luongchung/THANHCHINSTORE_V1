using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using HeThong;

namespace HeThong.Func
{
   public class UserLogin
    {
        public bool AddNewNV(NhanVien objnhanvien)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                db.NhanViens.InsertOnSubmit(objnhanvien);
                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public bool EditUser(NhanVien objnhanvien)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var objnv = db.NhanViens.Single(p => p.MaNV == objnhanvien.MaNV);
                objnv.TenNV = objnhanvien.TenNV;
                objnv.GioiTinh = objnhanvien.GioiTinh;
                objnv.Tuoi = objnhanvien.Tuoi;
                objnv.SDT = objnhanvien.SDT;
                if (objnhanvien.Password.Length != 0) objnv.Password = HashPassword(objnhanvien.Password);
                objnv.DiaChi = objnhanvien.DiaChi;
                objnv.IDLoaiNV = objnhanvien.IDLoaiNV;
                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public NhanVien GetUserByMaNV(string sMaNV, string sPassword)
        {
            NhanVien objnhanvien = new NhanVien();
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var query = db.NhanViens.ToList();
                objnhanvien = db.NhanViens.SingleOrDefault(p => p.MaNV == sMaNV & p.Password == HashPassword(sPassword));
                return objnhanvien;
            }
        }
        public NhanVien GetUserByMaNVNonHash(string sMaNV, string sPassword)
        {
            NhanVien objnhanvien = new NhanVien();
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                objnhanvien = db.NhanViens.SingleOrDefault(p => p.MaNV == sMaNV & p.Password == sPassword & p.IsLock == false);
                return objnhanvien;
            }
        }
        public bool ChangePassword(NhanVien objnhanvien)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var newuser = db.NhanViens.FirstOrDefault(p => p.ID == objnhanvien.ID);
                newuser.Password = objnhanvien.Password;
                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public string HashPassword(string OriginalString)
        {
            //Declarations
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;
            //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(OriginalString);
            encodedBytes = md5.ComputeHash(originalBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < encodedBytes.Length; i++)
            {
                sb.Append(encodedBytes[i].ToString("X2"));
            }
            //Convert encoded bytes back to a 'readable' string
            return sb.ToString();
        }
    }
}

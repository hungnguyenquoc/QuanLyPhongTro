using QLPhongTro.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLPhongTro.Models.DAO
{
    public class ModifyAccount
    {
        public void InsertDB(string tenHienThi, string tenTaiKhoan, string matKhau, int kieuNguoiDung)
        {
            QLPhongTroDBContext db = new QLPhongTroDBContext();
            TaiKhoan tk = new TaiKhoan();
            tk.TenTaiKhoan = tenTaiKhoan;
            tk.TenHienThi = tenHienThi;
            tk.MatKhau = matKhau;
            tk.KieuNguoiDung = kieuNguoiDung;
            db.TaiKhoans.Add(tk);
            db.SaveChanges();
        }
        public void DeleteDB(string userName)
        {
            QLPhongTroDBContext db = new QLPhongTroDBContext();
            TaiKhoan tk = db.TaiKhoans.SingleOrDefault(x => x.TenTaiKhoan == userName);
            db.TaiKhoans.Remove(tk);
            db.SaveChanges();
        }   
    }
}
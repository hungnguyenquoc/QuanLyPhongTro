using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLPhongTro.Models.DAO
{
    public class ModifyTVNguoiDung
    {
        public void InsertDB(string tenUser, string gioiTinh, string email, int soDienThoai, string diaChi, string tenTaiKhoan)
        {
            QLPhongTroDBContext db = new QLPhongTroDBContext();
            TVNguoiDung tvNguoiDung = new TVNguoiDung();
            tvNguoiDung.TenUser = tenUser;
            tvNguoiDung.GioiTinh = gioiTinh;
            tvNguoiDung.Email = email;
            tvNguoiDung.SoDT = soDienThoai;
            tvNguoiDung.DiaChi = diaChi;
            tvNguoiDung.idUser = 1;
            tvNguoiDung.TenTaiKhoan = tenTaiKhoan;
            db.TVNguoiDungs.Add(tvNguoiDung);
            db.SaveChanges();
        }
        public List<TVNguoiDung> GetList()
        {
            return new QLPhongTroDBContext().TVNguoiDungs.ToList();

            //return new QLPhongTroDBContext().TVNguoiDungs.Select(x => new QLNguoiDung { ID = x.idUser, Name = x.TenUser, Adress = x.DiaChi, Gender = x.GioiTinh }).ToList();
        }
        public void Delete(int ID)
        {
            QLPhongTroDBContext db = new QLPhongTroDBContext();
            TVNguoiDung t = db.TVNguoiDungs.SingleOrDefault(x => x.idUser == ID);
            db.TVNguoiDungs.Remove(t);
            db.SaveChanges();


            //QLPhongTroDBContext db = new QLPhongTroDBContext();
            //TVNguoiDung t = db.TVNguoiDungs.SingleOrDefault(x => x.idUser == ID);
            //t.SoDT = "34234234";
            //db.SaveChanges();
        }
        public int GetIDByUsername(string username)
        {
            QLPhongTroDBContext db = new QLPhongTroDBContext();
            return db.TVNguoiDungs.SingleOrDefault(x => x.TenTaiKhoan == username).idUser;
        }
    }
}
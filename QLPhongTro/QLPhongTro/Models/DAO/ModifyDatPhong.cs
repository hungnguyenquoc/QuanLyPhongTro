using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLPhongTro.Models.DAO
{
    public class ModifyDatPhong
    {
        public void Insert(int RoomID, int TVNguoiDungID)
        {
            QLPhongTroDBContext db = new QLPhongTroDBContext();
            DatPhong dp = new DatPhong();
            dp.idDatPhong = 0;
            dp.idPhong = RoomID;
            dp.idUser = TVNguoiDungID;
            dp.TenPhong = new ModifyPhong().GetTenPhongByID(RoomID);
            dp.NgayDangKy = DateTime.Now;
            db.DatPhongs.Add(dp);
            db.SaveChanges();
        }
    }
}
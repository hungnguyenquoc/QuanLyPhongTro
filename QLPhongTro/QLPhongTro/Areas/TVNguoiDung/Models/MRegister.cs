using QLPhongTro.Models;
using QLPhongTro.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLPhongTro.Areas.TVNguoiDung.Models
{
    public class MRegister
    {
        public List<Phong> getListPhong()
        {
            QLPhongTroDBContext db = new QLPhongTroDBContext();
            List<Phong> list = db.Phongs.ToList();
            return list;
        }
        public string DatPhong(int roomID, int TVNDID)
        {
            new ModifyDatPhong().Insert(roomID, TVNDID);
            return "true";
        }
    }
}
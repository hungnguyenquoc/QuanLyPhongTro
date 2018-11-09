using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLPhongTro.Models.DAO
{
    public class ModifyPhong
    {
        public string GetTenPhongByID(int roomID)
        {
            return new QLPhongTroDBContext().Phongs.SingleOrDefault(x => x.idPhong == roomID).TenPhong;
        }
    }
}
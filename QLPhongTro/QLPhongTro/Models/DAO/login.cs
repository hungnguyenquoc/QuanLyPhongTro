using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLPhongTro.Models.DAO
{
    public class login
    {
        [Required(ErrorMessage ="Chua nhap username")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Chua nhap password")]
        public string passWord { get; set; }
        public string VerifyLogin(string user, string pass)
        {
            QLPhongTroDBContext db = new QLPhongTroDBContext();
            TaiKhoan tk = db.TaiKhoans.SingleOrDefault(x => x.TenTaiKhoan == user);
            if (tk != null)
            {
                if(tk.MatKhau == pass)
                {
                     return tk.KieuNguoiDung + "";
                }
                else
                {
                    return "false";
                }
            }
            else
                return "false";
        }
    }
}
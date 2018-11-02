using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLPhongTro.Models.DAO
{
    public class register
    {
        [Required(ErrorMessage = "Chua nhap username")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Chua nhap password")]
        public string passWord { get; set; }
        [Required(ErrorMessage = "Chua nhap Ten hien thi")]
        public string name { get; set; }
        [Required(ErrorMessage = "Chua nhap Email")]
        public string email { get; set; }
        [Required(ErrorMessage = "Chua nhap so dien thoai")]
        public int phone { get; set; }
        [Required(ErrorMessage = "Chua nhap dia chi")]
        public string address { get; set; }
        [Required(ErrorMessage = "Chua nhap gioi tinh")]
        public string gender { get; set; }
        public string Register(register model )
        {
            QLPhongTroDBContext db = new QLPhongTroDBContext();
            TaiKhoan tk = db.TaiKhoans.SingleOrDefault(x => x.TenTaiKhoan == userName);
            if(tk == null)
            {
                ModifyAccount mA = new ModifyAccount();
                ModifyTVNguoiDung mTV = new ModifyTVNguoiDung();
                mA.InsertDB(model.name, model.userName, model.passWord, 2);
                mTV.InsertDB(model.name, model.gender, model.email, model.phone, model.address, model.userName);
                return "true";
            }
            else
            {
                return "false";
            }
            
        }
    }
}
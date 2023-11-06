using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class KhachHangBLL
    {
        private KhachHangDAL DAL;

        public KhachHangBLL()
        {
            DAL = new KhachHangDAL();
        }

        public KHACHHANG LayDataKH(string tk, string mk)
        {
            var kh = DAL.LayDataKHLogin(tk, mk);

            return kh;
        }

        public void UpdateKH(string makh, string hoten, DateTime ngsinh, string email, string cccd, string sdt, string diachi, string quoctich)
        {
            DAL.UpdateKH(makh, hoten, ngsinh, email, cccd, sdt, diachi, quoctich);
        }

        public void UpdateMK(string makh, string mkmoi)
        {
            DAL.UpdateMK(makh, mkmoi);
        }

        public void RegisterKH(string tk, string mk)
        {
            DAL.RegisterKH(tk, mk);
        }
    }
}

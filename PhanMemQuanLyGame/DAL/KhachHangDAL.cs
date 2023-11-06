using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDAL
    {
        private QLGAMEDataContext dataContext;

        public static string generateMaKH()
        {
            string allowedChars = "0123456789";
            Random random = new Random();
            char[] result = new char[5];

            for (int i = 0; i < 5; i++)
            {
                result[i] = allowedChars[random.Next(0, allowedChars.Length)];
            }

            return new string(result);
        }

        public KhachHangDAL() {
            dataContext = new QLGAMEDataContext();
        }

        public KHACHHANG LayDataKHLogin(string tk, string mk)
        {
            var kh = dataContext.KHACHHANGs.Where(user => user.TenTK == tk && user.PassTK == mk).SingleOrDefault();

            return kh;
        }

        public void UpdateKH(string makh, string hoten, DateTime ngsinh, string email, string cccd, string sdt, string diachi, string quoctich)
        {
            var update = dataContext.KHACHHANGs.FirstOrDefault(user => user.MaKH == makh);

            if (update != null)
            {
                update.HoTen = hoten;
                update.Email = email;
                update.CCCD = cccd;
                update.SDT = sdt;
                update.NgSinh = ngsinh;
                update.QuocTich = quoctich;
                update.DiaChi = diachi;

                dataContext.SubmitChanges();
            }
        }

        public void UpdateMK(string makh, string mkmoi)
        {
            var update = dataContext.KHACHHANGs.FirstOrDefault(user => user.MaKH == makh);

            if (update != null)
            {
                update.PassTK = mkmoi;

                dataContext.SubmitChanges();
            }
        }

        public void RegisterKH(string tk, string mk)
        {
            string randomId;

            do
            {
                randomId = generateMaKH();
            } while (dataContext.KHACHHANGs.Any(x => x.MaKH == randomId));

            KHACHHANG newKH = new KHACHHANG
            {
                MaKH = randomId,
                HoTen = "",
                CCCD = "",
                SDT = "",
                NgSinh = DateTime.Now,
                Email = "",
                DiaChi = "",
                QuocTich = "None",
                TenTK = tk,
                PassTK = mk,
                SoDu = 0,
            };

            dataContext.KHACHHANGs.InsertOnSubmit(newKH);
            dataContext.SubmitChanges();
        }
    }
}

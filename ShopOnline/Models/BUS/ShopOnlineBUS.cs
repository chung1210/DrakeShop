using System;
using ShopOnlineConnection;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOnline.Models.BUS
{
    public class ShopOnlineBUS
    {
        public static IEnumerable <SanPham> DanhSach()
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<SanPham>("select * from SanPham where TinhTrang = 0");
        }
        public static SanPham ChiTiet(string a)
        {
            var db = new ShopOnlineConnectionDB();
            return db.SingleOrDefault<SanPham>("select * from SanPham where MaSanPham = @0",a);
        }
        public static IEnumerable<SanPham> HotItems()
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<SanPham>("select Top 8 * from SanPham where LuotView>0");
        }
    }
}
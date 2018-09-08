using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeThong;
namespace HeThong
{
    public static class Common
    {
        public static NhanVien User { get; set;}
        public static bool IsClose { get; set; }
        public static String getChuoiKetNoi()
        {
            return "Data Source=" + Properties.Settings.Default.chuoiketnoi.ToString().Trim() + ";Initial Catalog=dbThanhChin;Integrated Security=True";
        }
    }
}

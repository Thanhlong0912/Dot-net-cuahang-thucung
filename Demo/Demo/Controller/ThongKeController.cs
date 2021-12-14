using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Demo.Model;

namespace Demo.Controller
{
    class ThongKeController
    {
        ThongKeModel usMod = new ThongKeModel();
        public DataTable HienThiDuLieuThongKe(string Nam)
        {
            return usMod.HienThiThongKeNam(Nam);
        }
    }
}

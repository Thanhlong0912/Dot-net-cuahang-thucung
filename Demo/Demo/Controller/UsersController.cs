using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Demo.Model;

namespace Demo.Controller
{
    class UsersController
    {
        UserModel usMod = new UserModel();
        public DataTable HienThiDuLieu()
        {
            return usMod.HienThiDuLieu();
        }
        public DataTable HienThiDuLieuTiemKiem(string User)
        {
            return usMod.HienThiDuLieuTimKiem(User);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBYLsales
{
    public static class staticLoinUser
    {
        public static string loginName { get; set; }
        public static int loginID { get; set; }
        public static string loginPower { get; set; }

        public static bool isAdminUser()
        {
            if (staticLoinUser.loginPower == "admin") return true;
            else return false;

        }
        public static bool isCommonUser()
        {
            if (staticLoinUser.loginPower == "common") return true;
            else return false;

        }
    }
}

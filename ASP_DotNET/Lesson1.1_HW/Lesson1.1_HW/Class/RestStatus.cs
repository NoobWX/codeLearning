using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson1._1_HW.Class
{
    public class RestStatus
    {
        static private string _username = "";
        static private string _password = "";

        public void SaveUserStatus(string username)
        {
            _username = username;
        }
        public void SavePwdStatus(string password)
        {
            _password = password;
        }
        public static string RecoverUserStatus()
        {
            return _password;
        }
        public static string RecoverPwdStatus()
        {
            return _username;
        }
    }
}
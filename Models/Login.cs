using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Login
    {
        private static string user = null;

        public static string User
        {
            get { return user; }
            set { user = value; }
        }
    }
}

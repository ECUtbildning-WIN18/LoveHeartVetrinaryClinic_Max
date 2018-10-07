using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeartVetrinaryClinicHEMU.Domain
{
    class User
    {
        private string UserName { get; set; }
        private string PassWord { get; set; }
        private string Role { get; set; }

        public User(string userName, string passWord, string role)
        {
            UserName = userName;
            PassWord = passWord;
            Role = role;
        }

        public string GetUserName()
        {
            return UserName;
        }

        public string GetPassWord()
        {
            return PassWord;
        }

        public string GetRole()
        {
            return Role;
        }
    }
}

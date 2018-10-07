using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeartVetrinaryClinicHEMU.Domain
{
    class UsersAndPassWordList
    {
        // private List<User> UserList;
        private List<User> UserList= new List<User>();
        public UsersAndPassWordList() // Constructor
        {
            UserList = new List<User>{
                new User("Sarah", "qwerty", "Receptionist"),
                new User("John", "12345", "Veterinarian"),
                new User("Fatman", "LittleBoy", "System Admin"),
                };
         
        }

        public List<User>GetUserList() // Call this to Export UserList
        {
            return UserList;
        }
        
    }// Class end
} // namespace

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeartVetrinaryClinicHEMU.Domain
{
    class SystemUsersDataBase
    {

        private int CurrentUser { get; set; }
        UsersAndPassWordList UserList = new UsersAndPassWordList();
        private List<User> Users;
       // bool ValidUserName = false; 
       // bool IsValidPassword = false;

        public SystemUsersDataBase() // In my Constructor I "Construct" a List of Persons that can log in
        {
            Users = UserList.GetUserList(); 
        }

        public void AddUser(User newUser)
        {
            Users.Add(newUser);
        }

        public List<User> GetUsers()
        {
            return Users;// This is the 
        }

        public void ListUsers()
        {
            int i = 1;
            foreach (User user in Users) // for each user in our system
            {
                Console.WriteLine(i + ". " + user.GetUserName() + "\tRole: " + user.GetRole());// write desired user info to the screen
                i++;
            }
        }

        public bool CheckUserName(string username, bool isValidUser)
        {
            int i = 1;
            foreach (User person in Users)
            {
                if (username == person.GetUserName())// Checks if entered user is in the list
                {
                    isValidUser = true;
                    CurrentUser = i;
                    return isValidUser; // and returns True if the user is in the list
                }
                else
                {
                    isValidUser = false;
                }
                i++;
            }
            return isValidUser; // If the entered user is not in the list false is returned
        }

        public bool CheckPassword(string username, string password, bool isValidPassword)
        {

            foreach (User person in Users)
            {
                if (password == person.GetPassWord() && username == person.GetUserName())//
                {
                    isValidPassword = true;
                    return isValidPassword; // and returns True if the user is in the list
                }
                else
                {
                    isValidPassword = false;
                }
            }
            return isValidPassword; // If the entered user is not in the list false is returned
        }

        public int GetCurrentUser()
        {
            return CurrentUser;
        }
    }
}

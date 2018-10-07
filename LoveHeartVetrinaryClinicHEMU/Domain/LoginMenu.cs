using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeartVetrinaryClinicHEMU.Domain
{
    class LoginMenu
    {
        private string UserName { get; set; }
        private string PassWord { get; set; }
        private List<User> Person;
        bool ValidUserName = false;
        bool IsValidPassword = false;
        SystemUsersDataBase Database = new SystemUsersDataBase();
        ReceptionistMenu receptionistMenu = new ReceptionistMenu();
        SystemAdministratorMenu SysMenuTest = new SystemAdministratorMenu();
        VetMenu vetMenu = new VetMenu();

        public LoginMenu() // In my Constructor I "Construct" a List of Persons that can log in
        {
            Person =  Database.GetUsers(); // 
            // Person = UserList.GetUserList();// Creates a List of Users from the USersAndPassWordList Class
        }
        
        public void Menu()
        {
            while (true) {
                Database = SysMenuTest.GetDatabase(); // since we add stuff and remove stuff as System Admin, we need to Update The Database inLogin
                Person = Database.GetUsers();// And readjust the vars in LoginMenu , Everything should be fine now.
                string choise = "Default";

            Console.WriteLine("=== LoveHeart Vetrinary Clinic ===\n1. Login\n2. Exit");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                    Console.Clear(); // Not nessecary at all but makes the app look nicer
                    Login();
                    break;
                    case "2":
                    Environment.Exit(0); // bye!
                    break;
                    default:
                    Console.WriteLine("--Invalid Selection--"); // Select Better noob! :p
                    break;
                }
                Console.ReadLine();
                Console.Clear(); // Not nessecary at all but makes the app look nicer
            }
        }

        private void Login()
        {
            

            Console.WriteLine("=== LoveHeart Vetrinary Clinic ===\nLogin");
            EnterUserName(); // Enter your username
            if (ValidUserName == true)// If your username is in the list, Continue
            {                                  
                EnterPassWord(); // Write your Password
                CheckPassword();// Checks if you entered the right Password
            }
            else // If your username is not in the list, don't continue
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadLine();
            Console.Clear(); // Not nessecary at all but makes the app look nicer
        }

        private void EnterUserName()
        {
            Console.WriteLine("Enter UserName:");
            UserName = Console.ReadLine();
            ValidUserName = Database.CheckUserName(UserName, ValidUserName);// checks if entered UserName is Valid
        }
        
        private void EnterPassWord()
        {
            
         Console.WriteLine("Enter Password");
         PassWord = Console.ReadLine();
         IsValidPassword = Database.CheckPassword(UserName, PassWord, IsValidPassword); // checks if entered PW is Valid
          
        }

        private void CheckPassword()
        {
            if (IsValidPassword == true) // 
            {
                
                Console.WriteLine("Login Sucesfull!");
                int CurrentUser = Database.GetCurrentUser();
                if(Person[CurrentUser - 1].GetRole() == "Receptionist") { // CurrentUser - 1 because Count starts at 0
                    receptionistMenu.Menu();
                }else if(Person[CurrentUser -1].GetRole() == "Veterinarian")
                {
                    vetMenu.Menu();
                }else if (Person[CurrentUser - 1].GetRole() == "System Admin")
                {
                    SysMenuTest.Menu();
                }
                else
                {
                    Console.WriteLine("User has no Valid Role");
                }


            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
    }
}

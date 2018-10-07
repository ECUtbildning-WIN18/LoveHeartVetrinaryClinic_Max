using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeartVetrinaryClinicHEMU.Domain
{
    class SystemAdministratorMenu
    {
        private List<User> Users;
        SystemUsersDataBase Database = new SystemUsersDataBase();

        public SystemAdministratorMenu()
        {
           Users = Database.GetUsers();
        }

        public SystemUsersDataBase GetDatabase()
        {
            return Database;
        }
        
        public void Menu()
        {
            bool LoopIsFinished = false;
            while (LoopIsFinished == false)
            {
                Console.WriteLine("== Admin Menu ==");
                Console.WriteLine("\n1. Add User\n2. Delete User\n3.List Users \n4. Log Out");
                Console.Write("\nSelect Action:");
                string choise = Console.ReadLine();
                switch (choise)
                {
                    case "1": // cw all Appointments // Choise to see details
                        AddUser();// Lets you add a new user to the system
                        break;
                    case "2": // Delete User
                        Database.ListUsers(); // Writes a List of all users
                        DeleteUser();// Chosees a User you wish to delete and removes him from the system
                        break;
                    case "3":
                        Database.ListUsers();
                        break;
                    case "4":
                        LoopIsFinished = true;
                        break;
                    default:
                        Console.WriteLine("--Unkown Action--"); // Select Better noob! :p
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        private void AddUser()
        {
            string Username = "";
            string Password = "";
            string Role = "";
            bool AmIaValidRole = false;
            Console.WriteLine("Enter new UserName:\n");
            Username = Console.ReadLine();
            Console.WriteLine("Enter new Password:\n");
            Password = Console.ReadLine();
            while (AmIaValidRole == false) // Im looping this untill you select a valid Role for the user
            {
                Console.WriteLine("Select User Role");
                Console.WriteLine("1. Receptionist\n2.Vetrenarian\n3.System Admin");// choises are 123
                Role = Console.ReadLine();
                switch (Role)
                {
                    case "1":
                        Role = "Receptionist";
                        AmIaValidRole = true;
                        break;
                    case "2":
                        Role = "Veterinarian";
                        AmIaValidRole = true;
                        break;
                    case "3":
                        Role = "System Admin";
                        AmIaValidRole = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }

            User NewUser = new User(Username, Password, Role); // creates a new user with teh given parameters
            Database.AddUser(NewUser);// adds the new user to the system
        }

        private void DeleteUser()
        {
            bool LoopIsFinished = false;
           while(LoopIsFinished == false) {  // Just looping untill I get a valid input
                Console.WriteLine("Select User:");
                int choise =Convert.ToInt32( Console.ReadLine());
                if (choise < Users.Count) { 
                Users.RemoveAt(choise - 1); // -1 because Array Counting (starts at 0 instead of 1)
                    LoopIsFinished = true;
                }
                else
                {
                Console.WriteLine("Invalid Selection");
                }
            }
        }
    }
}

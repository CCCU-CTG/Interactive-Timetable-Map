using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Timetable_Map
{
    public class User
    {
        string userID;
        string firstName;
        string surname;
        string userName;
        string password;
        string module;
        bool admin;

        public User(string ID, string fName, string sName, string uName, string pass, string userModule, bool Admin)
        {
            userID = ID;
            firstName = fName;
            surname = sName;
            userName = uName;
            password = pass;
            module = userModule;
            admin = Admin;
        }

        public string GetPatientID { get { return userID; } }
        public string GetFirstName { get { return firstName; } }
        public string GetSurname { get { return surname; } }
        public string GetUsername { get { return userName; } }
        public string GetPassword { get { return password; } }
        public string GetModule { get { return module; } }
        public bool GetAdmin { get { return admin; } }
    }    
}

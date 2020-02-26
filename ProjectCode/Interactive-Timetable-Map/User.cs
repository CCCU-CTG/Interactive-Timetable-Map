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
        string group;

        public User(string ID, string fName, string sName, string uName, string pass, string userGroup)
        {
            userID = ID;
            firstName = fName;
            surname = sName;
            userName = uName;
            password = pass;
            group = userGroup;
        }

        public string GetPatientID { get { return userID; } }
        public string GetFirstName { get { return firstName; } }
        public string GetSurname { get { return surname; } }
        public string GetUsername { get { return userName; } }
        public string GetPassword { get { return password; } }
        public string GetGroup { get { return group; } }
    }    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Timetable_Map
{
    class User
    {
        string userID;
        string firstName;
        string surname;
        string userName;
        string password;
        string passwordEncrypted;
        string group;

        public User(string ID, string fName, string sName, string uName, string pass, string passencrypted, string userGroup)
        {
            userID = ID;
            firstName = fName;
            surname = sName;
            userName = uName;
            password = pass;
            passwordEncrypted = passencrypted;
            group = userGroup;
        }
    }    
}

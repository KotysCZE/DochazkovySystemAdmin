using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DochazkovySystemAdmin
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string User_number { get; set; }
        public List<string> UserActions { get; set; }

        public User(string name, string user_number, List<string>UserActions)
        {
            Name = name;
            User_number = user_number;
            this.UserActions = UserActions;
        }

        public User(string name, string surname, string User_number)
        {
            Name = name;
            Surname = surname;
            this.User_number = User_number;
        }
        public User()
        {
        }

        public override string ToString()
        {
            return Name;
        }

        public string returnNumber()
        {
            return User_number;
        }

        public string[] Actions()
        {
            return UserActions.ToArray();
        }

        public string SaveIntoDatabaseForm()
        {
            return User_number + ";" + Name + ";" + Surname;
        }
    }
}

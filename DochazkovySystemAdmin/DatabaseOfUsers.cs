using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace DochazkovySystemAdmin
{
    internal class DatabaseOfUsers
    {
        string directoryPath = ""; //zde je potřeba napsat cestu do složky, kde máme databázi uživatelů
        List<User>Users = new List<User>();
        string User_number = "11";



        public void InsertUserIntoDatabase(string userName)
        {
            try
            {
                DatabaseOfActions databaseOfActions = new DatabaseOfActions();
                List<string> lines = databaseOfActions.Reader(directoryPath, "UserDatabase.txt");

                StreamWriter sw = new StreamWriter(directoryPath + "UserDatabase.txt");

                foreach (string newline in lines)
                {
                    sw.WriteLine(newline);
                }
                sw.Write(userName.ToString());
                sw.Flush();
                sw.Close();

                MessageBox.Show($"Uživatel úspěšně uložen.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Při zakládání uživatele se vyskytla chyba: {ex.Message}");
            }
        }
        public void ReadNameOfUsers()
        {
            
            string line = "";
            StreamReader sr = new StreamReader(directoryPath +"UserDatabase.txt" );
            DatabaseOfActions databaseOfActions = new DatabaseOfActions();
            while (line != null)
            {
                string[] lineField = new string[3];
                line = sr.ReadLine();
                if (line != null)
                {
                    lineField = line.Split(";");
                    string userNumber = lineField[0];
                    string userName = lineField[1] + " " + lineField[2];
                    List<string>userActions = databaseOfActions.ShowUserActionDatabase(userNumber);
                    

                    User user = new User(userName, userNumber,userActions);
                    Users.Add(user);
                }
            }
            sr.Close();


        }


        public void DeleteUser()
        {

        }

        public User[] ReturnUsers()
        {
            return Users.ToArray();
        }

        public List<string> returnActions()
        {
            List<string> actions = new List<string>();
            foreach (User user in Users)
            {
                foreach (string record in user.Actions())
                {
                    actions.Add(record);
                }
            }
            return actions;
        }
    }
}

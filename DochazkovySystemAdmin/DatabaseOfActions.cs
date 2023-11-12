using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DochazkovySystemAdmin
{
    internal class DatabaseOfActions
    {
        string directoryPath = ""; //zde je potřeba napsat cestu do složky, kam se budou ukládat akce aplikace
        string directoryPathToUserDatabase = ""; //zde je potřeba napsat cestu do složky, kde máme databázi uživatelů
        string fileName;
        string User_number = "11";




        public void CreateUser(string name, string surname)
        {
            try
            {
                User user = new User();
                bool nameFilled = false;
                while (!nameFilled)
                {

                    if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
                    {
                        MessageBox.Show("Musí být vyplněno jméno i přijímení");
                    }
                    else
                        nameFilled = true;

                }

                int user_number = 1;
                string[] files = Directory.GetFiles(directoryPath);
                foreach (string file in files)
                {
                    user_number++;
                }
                User_number += user_number.ToString();
                user.User_number = User_number;
                user.Name = name;
                user.Surname = surname;
                DatabaseOfUsers databaseOfUsers = new DatabaseOfUsers();
                databaseOfUsers.InsertUserIntoDatabase(user.SaveIntoDatabaseForm());
                StreamWriter sw = new StreamWriter(directoryPath + $"{User_number}.txt");
                sw.Flush();
                sw.Close();
                MessageBox.Show($"Zaměstnanec úspešně přidán. Bylo mu přiděleno číslo identifikační číslo {User_number} ");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Při zakládání uživatele se vyskytla chyba: {ex.Message}");
            }
            User_number = "11";
        }


        public void DeleteUser(string User_number)
        {
            if (File.Exists($"{directoryPath}{User_number}.txt"))
            {
                try
                {
                    File.Delete($"{directoryPath}{User_number}.txt");
                    MessageBox.Show($"Byl smazán záznam uživatele {User_number}");
                    StreamReader sr = new StreamReader(directoryPathToUserDatabase);
                    List<string> readedLines = new List<string>();
                    string readedline;
                    do
                    {
                        readedline = sr.ReadLine();
                        if (readedline != null)
                        {
                            if (!readedline.Contains(User_number))
                                readedLines.Add(readedline);
                        }
                    }
                    while (readedline != null);


                    sr.Close();
                    StreamWriter sw = new StreamWriter(directoryPathToUserDatabase);
                    foreach (string line in readedLines)
                    {
                        sw.WriteLine(line);
                    }
                    sw.Close();


                }
                catch (Exception e)
                {
                    MessageBox.Show($"Záznam se nepodařilo smazat - chyba {e}");
                }

            }
            else
            {
                MessageBox.Show($"Byl smazán záznam uživatele {User_number}");
                StreamReader sr = new StreamReader(directoryPathToUserDatabase);
                List<string> readedLines = new List<string>();
                string readedLine = "y";
                while (readedLine != null)
                {
                    readedLine = sr.ReadLine();
                    if (readedLine == null && readedLine.Contains(User_number))
                        continue;
                    else
                        readedLines.Add(readedLine);
                        
                }

                
                sr.Close();
                StreamWriter sw = new StreamWriter(directoryPathToUserDatabase);
                foreach (string line in readedLines)
                {
                    sw.WriteLine(line);
                    MessageBox.Show(line);
                }
                sw.Close();
            }
        }




        public List<string> ShowUserActionDatabase(string userNumber)
        {
            DatabaseOfUsers database = new DatabaseOfUsers();
            string fileNameToRead = userNumber;
            bool fileExists = CheckExistanceOfFile(directoryPath, fileNameToRead);
            List<string>userActions = new List<string>();
            if (fileExists)
            {
                List<string> lines = Reader();
                if (lines.Count == 0)
                {
                    userActions.Add("Nejsou zaznamenány žádné akce zaměstnance");
                }
                else
                {
                    foreach (string line in lines)
                    {
                        string[] newLine = line.Split(';');
                        userActions.Add(newLine[0] + " - " + newLine[1]);
                    }
                }
            }
            return userActions;
        }
        /// <summary>
        /// Reader is helping method which takes file and reads all the lines. Returns list of all lines in the file.
        /// </summary>
        /// <returns></returns>
        private List<string> Reader()
        {
            StreamReader sr = new StreamReader(directoryPath + $"{fileName}");
            string line = "";
            List<string> lines = new List<string>();

            while (line != null)
            {
                line = sr.ReadLine();
                if (line != null)
                    lines.Add(line);
            }

            sr.Close();
            return lines;
        }
        /// <summary>
        /// Parametrical version of Reader is helping method which takes file and reads all the lines. Recieves directorypath of file and name of the file itself.
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public List<string> Reader(string directoryPath, string fileName)
        {
            StreamReader sr = new StreamReader(directoryPath + $"{fileName}");
            string line = "";
            List<string> lines = new List<string>();

            while (line != null)
            {
                line = sr.ReadLine();
                if (line != null)
                    lines.Add(line);
            }

            sr.Close();
            return lines;

        }


        /// <summary>
        /// Helping method for receiving last action of employee.
        /// </summary>
        /// <returns></returns>
        public string LastAction()
        {
            List<string> lines = Reader();
            if (lines.Count > 0)
            {
                string lastLine = lines[lines.Count - 1];
                string[] lastActionField = lastLine.Split(';');
                string lastAction = lastActionField[lastActionField.Count() - 1];

                return lastAction;
            }
            else
                return "O";
        }

        /// <summary>
        /// Helping methods which receives directory path of file and file name itself. Returns bool of existance of file.
        /// </summary>
        /// <param name="fileNameToRead"></param>
        /// <returns></returns>
        public bool CheckExistanceOfFile(string directoryPath, string fileNameToRead)
        {
            string fileName = fileNameToRead + ".txt";

            this.fileName = fileName;

            string[] files = Directory.GetFiles(directoryPath);

            bool fileExists = false;

            foreach (string file in files)
            {
                if (Path.GetFileName(file) == fileName)
                {
                    fileExists = true;
                    break;
                }
            }

            return fileExists;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DochazkovySystemAdmin
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        public void closeForm()
        {
            this.Close();
        }

        public void saveUserButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameOfUser.Text) || string.IsNullOrEmpty(surnameOfUser.Text))
            {
                MessageBox.Show("Prosím vyplňte všechna pole!");
                return; // Přerušení metody, pokud nejsou vyplněna všechna pole
            }
                DatabaseOfActions databaseOfUsers = new DatabaseOfActions();
                databaseOfUsers.CreateUser(nameOfUser.Text, surnameOfUser.Text);
            BaseForm1 basetest = new BaseForm1();
            basetest.refreshPage();
            
            closeForm();
        }
    }
}

namespace DochazkovySystemAdmin
{
    public partial class BaseForm1 : Form
    {
        private string numberOfSelectedUser = "";
        public BaseForm1()
        {
            InitializeComponent();
            refreshPage();
        }

        public void refreshPage()
        {
            DatabaseOfUsers databaseOfUsers = new DatabaseOfUsers();

            listBox1.Items.Clear();
            databaseOfUsers.ReadNameOfUsers();
            listBox1.Items.AddRange(databaseOfUsers.ReturnUsers());
            listBox2.Items.Clear();
        }


        private void refreshPageButton_Click(object sender, System.EventArgs e)
        {
            DatabaseOfUsers databaseOfUsers = new DatabaseOfUsers();
            refreshPage();
        }

        public void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Clear();
                User user = (User)listBox1.SelectedItem;
                string[] userActionField = user.Actions();
                foreach (string action in userActionField)
                {
                    listBox2.Items.Add(action);
                }
            }
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.Show();
        }

        private void deleteUserButton_click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                User user = (User)listBox1.SelectedItem;
                DatabaseOfActions databaseOfActions = new DatabaseOfActions();
                databaseOfActions.DeleteUser(user.User_number);
                refreshPage();
            }
        }


    }
}
namespace DochazkovySystemAdmin
{
    partial class CreateUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameOfUser = new TextBox();
            surnameOfUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            saveUserButton = new Button();
            SuspendLayout();
            // 
            // nameOfUser
            // 
            nameOfUser.Location = new Point(149, 53);
            nameOfUser.Name = "nameOfUser";
            nameOfUser.Size = new Size(150, 23);
            nameOfUser.TabIndex = 0;
            // 
            // surnameOfUser
            // 
            surnameOfUser.Location = new Point(149, 96);
            surnameOfUser.Name = "surnameOfUser";
            surnameOfUser.Size = new Size(150, 23);
            surnameOfUser.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 56);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.Text = "Jméno zaměstnance:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 96);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.Text = "Příjmení zaměstnance: ";
            // 
            // saveUserButton
            // 
            saveUserButton.Location = new Point(121, 160);
            saveUserButton.Name = "saveUserButton";
            saveUserButton.Size = new Size(75, 23);
            saveUserButton.TabIndex = 3;
            saveUserButton.Text = "Uložit";
            saveUserButton.UseVisualStyleBackColor = true;
            saveUserButton.Click += saveUserButton_Click;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 326);
            Controls.Add(saveUserButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(surnameOfUser);
            Controls.Add(nameOfUser);
            Name = "CreateUserForm";
            Text = "CreateUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameOfUser;
        private TextBox surnameOfUser;
        private Label label1;
        private Label label2;
        private Button saveUserButton;
    }
}
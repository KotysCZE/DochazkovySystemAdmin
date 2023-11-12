namespace DochazkovySystemAdmin
{
    partial class BaseForm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            label1 = new Label();
            listBox2 = new ListBox();
            label2 = new Label();
            createUserButton = new Button();
            deleteUserButton = new Button();
            refreshPageButton = new Button();
            menuStrip2 = new MenuStrip();
            nastaveníToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(30, 61);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(133, 349);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 1;
            label1.Text = "Jméno zaměstnance:";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(188, 61);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(410, 349);
            listBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 33);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 4;
            label2.Text = "Záznamy zaměstnance:";
            // 
            // createUserButton
            // 
            createUserButton.Location = new Point(636, 61);
            createUserButton.Name = "createUserButton";
            createUserButton.Size = new Size(139, 51);
            createUserButton.TabIndex = 5;
            createUserButton.Text = "Vytvořit nového zaměstnance";
            createUserButton.UseVisualStyleBackColor = true;
            createUserButton.Click += createUserButton_Click;
            // 
            // deleteUserButton
            // 
            deleteUserButton.Location = new Point(636, 138);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(139, 51);
            deleteUserButton.TabIndex = 6;
            deleteUserButton.Text = "Smazat zaměstnance";
            deleteUserButton.UseVisualStyleBackColor = true;
            deleteUserButton.Click += deleteUserButton_click;
            // 
            // refreshPageButton
            // 
            refreshPageButton.Location = new Point(636, 359);
            refreshPageButton.Name = "refreshPageButton";
            refreshPageButton.Size = new Size(139, 51);
            refreshPageButton.TabIndex = 7;
            refreshPageButton.Text = "Načíst";
            refreshPageButton.UseVisualStyleBackColor = true;
            refreshPageButton.Click += refreshPageButton_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { nastaveníToolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 24);
            menuStrip2.TabIndex = 9;
            menuStrip2.Text = "menuStrip2";
            // 
            // nastaveníToolStripMenuItem1
            // 
            nastaveníToolStripMenuItem1.Name = "nastaveníToolStripMenuItem1";
            nastaveníToolStripMenuItem1.Size = new Size(71, 20);
            nastaveníToolStripMenuItem1.Text = "Nastavení";
            // 
            // BaseForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(refreshPageButton);
            Controls.Add(deleteUserButton);
            Controls.Add(createUserButton);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip2);
            Name = "BaseForm1";
            Text = "Form1";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private ListBox listBox1;
        private Label label1;
        private ListBox listBox2;
        private Label label2;
        private Button createUserButton;
        private Button deleteUserButton;
        private Button refreshPageButton;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem nastaveníToolStripMenuItem1;
    }
}
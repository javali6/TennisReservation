namespace TennisCourtReservation
{
    partial class Form1
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
            title = new Label();
            LoginText = new Label();
            login = new TextBox();
            password = new TextBox();
            loginButton = new Button();
            loginInformation = new Label();
            reservationTitle = new Label();
            aboutTitle = new Label();
            reservationButton = new Button();
            aboutButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            title.Location = new Point(11, 12);
            title.Name = "title";
            title.Size = new Size(1118, 81);
            title.TabIndex = 0;
            title.Text = "System Rezerwacji Kortów Tenisowych";
            // 
            // LoginText
            // 
            LoginText.AutoSize = true;
            LoginText.Location = new Point(952, 104);
            LoginText.Name = "LoginText";
            LoginText.Size = new Size(82, 20);
            LoginText.TabIndex = 1;
            LoginText.Text = "Zaloguj się";
            // 
            // login
            // 
            login.Location = new Point(921, 128);
            login.Margin = new Padding(3, 4, 3, 4);
            login.Name = "login";
            login.Size = new Size(138, 27);
            login.TabIndex = 2;
            login.Text = "login";
            login.TextChanged += textBox1_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(921, 167);
            password.Margin = new Padding(3, 4, 3, 4);
            password.Name = "password";
            password.Size = new Size(138, 27);
            password.TabIndex = 3;
            password.Text = "haslo";
            password.TextChanged += textBox1_TextChanged_1;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(952, 205);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(86, 31);
            loginButton.TabIndex = 4;
            loginButton.Text = "Zaloguj";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // loginInformation
            // 
            loginInformation.AutoSize = true;
            loginInformation.Location = new Point(901, 255);
            loginInformation.Name = "loginInformation";
            loginInformation.Size = new Size(177, 20);
            loginInformation.TabIndex = 5;
            loginInformation.Text = "zalgowany/niezalgowany";
            loginInformation.Click += label1_Click;
            // 
            // reservationTitle
            // 
            reservationTitle.AutoSize = true;
            reservationTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            reservationTitle.Location = new Point(29, 215);
            reservationTitle.Name = "reservationTitle";
            reservationTitle.Size = new Size(326, 60);
            reservationTitle.TabIndex = 6;
            reservationTitle.Text = "Zarezerwuj kort";
            // 
            // aboutTitle
            // 
            aboutTitle.AutoSize = true;
            aboutTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            aboutTitle.Location = new Point(389, 215);
            aboutTitle.Name = "aboutTitle";
            aboutTitle.Size = new Size(443, 60);
            aboutTitle.TabIndex = 7;
            aboutTitle.Text = "Informacje o obiekcie";
            aboutTitle.Click += label1_Click_1;
            // 
            // reservationButton
            // 
            reservationButton.Location = new Point(81, 339);
            reservationButton.Margin = new Padding(3, 4, 3, 4);
            reservationButton.Name = "reservationButton";
            reservationButton.Size = new Size(159, 84);
            reservationButton.TabIndex = 8;
            reservationButton.Text = "Przejdź";
            reservationButton.UseVisualStyleBackColor = true;
            reservationButton.Click += button1_Click;
            // 
            // aboutButton
            // 
            aboutButton.Location = new Point(521, 339);
            aboutButton.Margin = new Padding(3, 4, 3, 4);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(159, 84);
            aboutButton.TabIndex = 9;
            aboutButton.Text = "Przejdź";
            aboutButton.UseVisualStyleBackColor = true;
            aboutButton.Click += aboutButton_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label1.Location = new Point(14, 501);
            label1.Name = "label1";
            label1.Size = new Size(688, 37);
            label1.TabIndex = 10;
            label1.Text = "Przed przejściem do sekcji prosimy o zalogowanie się";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 715);
            Controls.Add(label1);
            Controls.Add(aboutButton);
            Controls.Add(reservationButton);
            Controls.Add(aboutTitle);
            Controls.Add(reservationTitle);
            Controls.Add(loginInformation);
            Controls.Add(loginButton);
            Controls.Add(password);
            Controls.Add(login);
            Controls.Add(LoginText);
            Controls.Add(title);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label LoginText;
        private TextBox login;
        private TextBox password;
        private Button loginButton;
        private Label loginInformation;
        private Label reservationTitle;
        private Label aboutTitle;
        private Button reservationButton;
        private Button aboutButton;
        private Label label1;
    }
}
namespace TennisCourtReservation
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            courtsList = new ComboBox();
            dateList = new ComboBox();
            hoursList = new ComboBox();
            numerOfPlayers = new TextBox();
            confirm = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tennisCourtBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)tennisCourtBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(294, 9);
            label1.Name = "label1";
            label1.Size = new Size(377, 45);
            label1.TabIndex = 0;
            label1.Text = "DOKONAJ REZERWACJI";
            // 
            // courtsList
            // 
            courtsList.DataSource = tennisCourtBindingSource;
            courtsList.FormattingEnabled = true;
            courtsList.Location = new Point(489, 154);
            courtsList.Name = "courtsList";
            courtsList.Size = new Size(121, 23);
            courtsList.TabIndex = 1;
            // 
            // dateList
            // 
            dateList.FormattingEnabled = true;
            dateList.Location = new Point(489, 204);
            dateList.Name = "dateList";
            dateList.Size = new Size(121, 23);
            dateList.TabIndex = 2;
            // 
            // hoursList
            // 
            hoursList.FormattingEnabled = true;
            hoursList.Location = new Point(489, 259);
            hoursList.Name = "hoursList";
            hoursList.Size = new Size(121, 23);
            hoursList.TabIndex = 3;
            // 
            // numerOfPlayers
            // 
            numerOfPlayers.Location = new Point(489, 317);
            numerOfPlayers.Name = "numerOfPlayers";
            numerOfPlayers.Size = new Size(121, 23);
            numerOfPlayers.TabIndex = 4;
            // 
            // confirm
            // 
            confirm.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            confirm.Location = new Point(378, 435);
            confirm.Name = "confirm";
            confirm.Size = new Size(214, 63);
            confirm.TabIndex = 5;
            confirm.Text = "ZATWIERDŹ";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 157);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 6;
            label2.Text = "Wybierz kort: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 212);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 7;
            label3.Text = "Wybierz datę: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 262);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 8;
            label4.Text = "Wybierz godzinę: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 325);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 9;
            label5.Text = "Podaj liczbę graczy:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(489, 389);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 10;
            label6.Text = "CENA: ....";
            label6.Click += label6_Click;
            // 
            // tennisCourtBindingSource
            // 
            tennisCourtBindingSource.DataSource = typeof(Domain.TennisCourt);
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 528);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(confirm);
            Controls.Add(numerOfPlayers);
            Controls.Add(hoursList);
            Controls.Add(dateList);
            Controls.Add(courtsList);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)tennisCourtBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox courtsList;
        private ComboBox dateList;
        private ComboBox hoursList;
        private TextBox numerOfPlayers;
        private Button confirm;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private BindingSource tennisCourtBindingSource;
    }
}
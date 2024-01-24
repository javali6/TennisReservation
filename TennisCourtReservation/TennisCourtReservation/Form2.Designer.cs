namespace TennisCourtReservation
{
    partial class Form2
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
            aboutTitle = new Label();
            pictureBox1 = new PictureBox();
            planObiektu = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // aboutTitle
            // 
            aboutTitle.AutoSize = true;
            aboutTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            aboutTitle.Location = new Point(127, 9);
            aboutTitle.Name = "aboutTitle";
            aboutTitle.Size = new Size(655, 65);
            aboutTitle.TabIndex = 0;
            aboutTitle.Text = "INFORMACJE O OBIEKTACH";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.korty3;
            pictureBox1.Location = new Point(30, 187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 251);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // planObiektu
            // 
            planObiektu.AutoSize = true;
            planObiektu.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            planObiektu.Location = new Point(114, 129);
            planObiektu.Name = "planObiektu";
            planObiektu.Size = new Size(179, 32);
            planObiektu.TabIndex = 2;
            planObiektu.Text = "PLAN OBIEKTU";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(364, 245);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 3;
            label1.Text = "nr. 1 - 5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(364, 361);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 4;
            label2.Text = "nr. 6 - 10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(556, 129);
            label3.Name = "label3";
            label3.Size = new Size(246, 32);
            label3.TabIndex = 5;
            label3.Text = "GODZINY OTWARCIA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(502, 207);
            label4.Name = "label4";
            label4.Size = new Size(386, 125);
            label4.TabIndex = 6;
            label4.Text = "KORTY OTWARTE SĄ W SEZONIE LETNIM\r\nOD POCZĄTKU MAJA DO KOŃCA WRZEŚNIA\r\n\r\nPN - PT    9.00 - 18.00\r\nSB - ND   11.00 - 20.00\r\n";
            label4.Click += label4_Click;
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            backButton.Location = new Point(580, 395);
            backButton.Name = "backButton";
            backButton.Size = new Size(202, 80);
            backButton.TabIndex = 7;
            backButton.Text = "POWRÓT";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 540);
            Controls.Add(backButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(planObiektu);
            Controls.Add(pictureBox1);
            Controls.Add(aboutTitle);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label planObiektu;
        private Label aboutTitle;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button backButton;
    }
}
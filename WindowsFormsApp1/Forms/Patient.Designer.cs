
namespace WindowsFormsApp1.Forms
{
    partial class Patient
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
            this.Surname = new System.Windows.Forms.Label();
            this.NameL = new System.Windows.Forms.Label();
            this.Patronym = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.GenderValue = new System.Windows.Forms.Label();
            this.BirthdayValue = new System.Windows.Forms.Label();
            this.PatronymValue = new System.Windows.Forms.Label();
            this.NameValue = new System.Windows.Forms.Label();
            this.SurnameValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(12, 9);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(84, 21);
            this.Surname.TabIndex = 0;
            this.Surname.Text = "Фамилия:";
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Location = new System.Drawing.Point(12, 31);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(47, 21);
            this.NameL.TabIndex = 1;
            this.NameL.Text = "Имя:";
            // 
            // Patronym
            // 
            this.Patronym.AutoSize = true;
            this.Patronym.Location = new System.Drawing.Point(12, 52);
            this.Patronym.Name = "Patronym";
            this.Patronym.Size = new System.Drawing.Size(85, 21);
            this.Patronym.TabIndex = 2;
            this.Patronym.Text = "Отчество:";
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Location = new System.Drawing.Point(12, 73);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(132, 21);
            this.Birthday.TabIndex = 3;
            this.Birthday.Text = "Дата рождения:";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(12, 94);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(45, 21);
            this.Gender.TabIndex = 4;
            this.Gender.Text = "Пол:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 77);
            this.button1.TabIndex = 5;
            this.button1.Text = "Узи брюшной полости";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 77);
            this.button2.TabIndex = 6;
            this.button2.Text = "Узи почек";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(402, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 77);
            this.button3.TabIndex = 7;
            this.button3.Text = "Узи мочевого пузыря";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(587, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 77);
            this.button4.TabIndex = 8;
            this.button4.Text = "Узи предстательной железы";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(47, 328);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 77);
            this.button5.TabIndex = 9;
            this.button5.Text = "Узи органов мошонки";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(221, 328);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 77);
            this.button6.TabIndex = 10;
            this.button6.Text = "Узи молочных желез";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(402, 328);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 77);
            this.button7.TabIndex = 11;
            this.button7.Text = "Узи щитовидной железы";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(587, 328);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(150, 77);
            this.button8.TabIndex = 12;
            this.button8.Text = "Узи";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // GenderValue
            // 
            this.GenderValue.AutoSize = true;
            this.GenderValue.Location = new System.Drawing.Point(59, 94);
            this.GenderValue.Name = "GenderValue";
            this.GenderValue.Size = new System.Drawing.Size(54, 21);
            this.GenderValue.TabIndex = 17;
            this.GenderValue.Text = "label6";
            // 
            // BirthdayValue
            // 
            this.BirthdayValue.AutoSize = true;
            this.BirthdayValue.Location = new System.Drawing.Point(140, 73);
            this.BirthdayValue.Name = "BirthdayValue";
            this.BirthdayValue.Size = new System.Drawing.Size(54, 21);
            this.BirthdayValue.TabIndex = 16;
            this.BirthdayValue.Text = "label7";
            // 
            // PatronymValue
            // 
            this.PatronymValue.AutoSize = true;
            this.PatronymValue.Location = new System.Drawing.Point(99, 52);
            this.PatronymValue.Name = "PatronymValue";
            this.PatronymValue.Size = new System.Drawing.Size(54, 21);
            this.PatronymValue.TabIndex = 15;
            this.PatronymValue.Text = "label8";
            // 
            // NameValue
            // 
            this.NameValue.AutoSize = true;
            this.NameValue.Location = new System.Drawing.Point(61, 31);
            this.NameValue.Name = "NameValue";
            this.NameValue.Size = new System.Drawing.Size(54, 21);
            this.NameValue.TabIndex = 14;
            this.NameValue.Text = "label9";
            // 
            // SurnameValue
            // 
            this.SurnameValue.AutoSize = true;
            this.SurnameValue.Location = new System.Drawing.Point(99, 9);
            this.SurnameValue.Name = "SurnameValue";
            this.SurnameValue.Size = new System.Drawing.Size(60, 21);
            this.SurnameValue.TabIndex = 13;
            this.SurnameValue.Text = "label10";
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenderValue);
            this.Controls.Add(this.BirthdayValue);
            this.Controls.Add(this.PatronymValue);
            this.Controls.Add(this.NameValue);
            this.Controls.Add(this.SurnameValue);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.Patronym);
            this.Controls.Add(this.NameL);
            this.Controls.Add(this.Surname);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Patient";
            this.Text = "Пациент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.Label Patronym;
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label GenderValue;
        private System.Windows.Forms.Label BirthdayValue;
        private System.Windows.Forms.Label PatronymValue;
        private System.Windows.Forms.Label NameValue;
        private System.Windows.Forms.Label SurnameValue;
    }
}
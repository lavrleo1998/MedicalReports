
namespace WindowsFormsApp1.Forms
{
    partial class JustUzi
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
            this.GenderValue = new System.Windows.Forms.Label();
            this.BirthdayValue = new System.Windows.Forms.Label();
            this.PatronymValue = new System.Windows.Forms.Label();
            this.NameValue = new System.Windows.Forms.Label();
            this.SurnameValue = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.Label();
            this.Patronym = new System.Windows.Forms.Label();
            this.NameL = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenderValue
            // 
            this.GenderValue.AutoSize = true;
            this.GenderValue.Location = new System.Drawing.Point(364, 260);
            this.GenderValue.Name = "GenderValue";
            this.GenderValue.Size = new System.Drawing.Size(38, 15);
            this.GenderValue.TabIndex = 37;
            this.GenderValue.Text = "label6";
            // 
            // BirthdayValue
            // 
            this.BirthdayValue.AutoSize = true;
            this.BirthdayValue.Location = new System.Drawing.Point(445, 239);
            this.BirthdayValue.Name = "BirthdayValue";
            this.BirthdayValue.Size = new System.Drawing.Size(38, 15);
            this.BirthdayValue.TabIndex = 36;
            this.BirthdayValue.Text = "label7";
            // 
            // PatronymValue
            // 
            this.PatronymValue.AutoSize = true;
            this.PatronymValue.Location = new System.Drawing.Point(404, 218);
            this.PatronymValue.Name = "PatronymValue";
            this.PatronymValue.Size = new System.Drawing.Size(38, 15);
            this.PatronymValue.TabIndex = 35;
            this.PatronymValue.Text = "label8";
            // 
            // NameValue
            // 
            this.NameValue.AutoSize = true;
            this.NameValue.Location = new System.Drawing.Point(366, 197);
            this.NameValue.Name = "NameValue";
            this.NameValue.Size = new System.Drawing.Size(38, 15);
            this.NameValue.TabIndex = 34;
            this.NameValue.Text = "label9";
            // 
            // SurnameValue
            // 
            this.SurnameValue.AutoSize = true;
            this.SurnameValue.Location = new System.Drawing.Point(404, 175);
            this.SurnameValue.Name = "SurnameValue";
            this.SurnameValue.Size = new System.Drawing.Size(44, 15);
            this.SurnameValue.TabIndex = 33;
            this.SurnameValue.Text = "label10";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(317, 260);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(33, 15);
            this.Gender.TabIndex = 32;
            this.Gender.Text = "Пол:";
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Location = new System.Drawing.Point(317, 239);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(93, 15);
            this.Birthday.TabIndex = 31;
            this.Birthday.Text = "Дата рождения:";
            // 
            // Patronym
            // 
            this.Patronym.AutoSize = true;
            this.Patronym.Location = new System.Drawing.Point(317, 218);
            this.Patronym.Name = "Patronym";
            this.Patronym.Size = new System.Drawing.Size(61, 15);
            this.Patronym.TabIndex = 30;
            this.Patronym.Text = "Отчество:";
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Location = new System.Drawing.Point(317, 197);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(34, 15);
            this.NameL.TabIndex = 29;
            this.NameL.Text = "Имя:";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(317, 175);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(61, 15);
            this.Surname.TabIndex = 28;
            this.Surname.Text = "Фамилия:";
            // 
            // JustUzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenderValue);
            this.Controls.Add(this.BirthdayValue);
            this.Controls.Add(this.PatronymValue);
            this.Controls.Add(this.NameValue);
            this.Controls.Add(this.SurnameValue);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.Patronym);
            this.Controls.Add(this.NameL);
            this.Controls.Add(this.Surname);
            this.Name = "JustUzi";
            this.Text = "SelectionWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GenderValue;
        private System.Windows.Forms.Label BirthdayValue;
        private System.Windows.Forms.Label PatronymValue;
        private System.Windows.Forms.Label NameValue;
        private System.Windows.Forms.Label SurnameValue;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.Label Patronym;
        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.Label Surname;
    }
}
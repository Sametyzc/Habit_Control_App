namespace Habit_Control
{
    partial class Form_Delete_Habit
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
            this.Label_Header = new System.Windows.Forms.Label();
            this.Label_Select_Habit = new System.Windows.Forms.Label();
            this.comboBox_Habits = new System.Windows.Forms.ComboBox();
            this.Button_Accept = new System.Windows.Forms.Button();
            this.Button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Header
            // 
            this.Label_Header.AutoSize = true;
            this.Label_Header.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label_Header.Location = new System.Drawing.Point(46, 9);
            this.Label_Header.Name = "Label_Header";
            this.Label_Header.Size = new System.Drawing.Size(167, 24);
            this.Label_Header.TabIndex = 1;
            this.Label_Header.Text = "Alışkanlık Silme";
            // 
            // Label_Select_Habit
            // 
            this.Label_Select_Habit.AutoSize = true;
            this.Label_Select_Habit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label_Select_Habit.ForeColor = System.Drawing.Color.Black;
            this.Label_Select_Habit.Location = new System.Drawing.Point(18, 63);
            this.Label_Select_Habit.Name = "Label_Select_Habit";
            this.Label_Select_Habit.Size = new System.Drawing.Size(225, 20);
            this.Label_Select_Habit.TabIndex = 2;
            this.Label_Select_Habit.Text = "Silmek İstediğin Alışkanlığı Seç";
            // 
            // comboBox_Habits
            // 
            this.comboBox_Habits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_Habits.FormattingEnabled = true;
            this.comboBox_Habits.Location = new System.Drawing.Point(50, 120);
            this.comboBox_Habits.MaxDropDownItems = 20;
            this.comboBox_Habits.Name = "comboBox_Habits";
            this.comboBox_Habits.Size = new System.Drawing.Size(163, 28);
            this.comboBox_Habits.TabIndex = 3;
            this.comboBox_Habits.Text = "Alışlanlık Seç";
            // 
            // Button_Accept
            // 
            this.Button_Accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(168)))), ((int)(((byte)(97)))));
            this.Button_Accept.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_Accept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.Button_Accept.Location = new System.Drawing.Point(144, 216);
            this.Button_Accept.Name = "Button_Accept";
            this.Button_Accept.Size = new System.Drawing.Size(98, 51);
            this.Button_Accept.TabIndex = 4;
            this.Button_Accept.Text = "Onayla";
            this.Button_Accept.UseVisualStyleBackColor = false;
            this.Button_Accept.Click += new System.EventHandler(this.Button_Accept_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(58)))), ((int)(((byte)(51)))));
            this.Button_Back.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.Button_Back.Location = new System.Drawing.Point(12, 216);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(98, 51);
            this.Button_Back.TabIndex = 5;
            this.Button_Back.Text = "Geri";
            this.Button_Back.UseVisualStyleBackColor = false;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Form_Delete_Habit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 289);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.Button_Accept);
            this.Controls.Add(this.comboBox_Habits);
            this.Controls.Add(this.Label_Select_Habit);
            this.Controls.Add(this.Label_Header);
            this.Name = "Form_Delete_Habit";
            this.Text = "Alışkanlık Silme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Header;
        private System.Windows.Forms.Label Label_Select_Habit;
        private System.Windows.Forms.ComboBox comboBox_Habits;
        private System.Windows.Forms.Button Button_Accept;
        private System.Windows.Forms.Button Button_Back;
    }
}
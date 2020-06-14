namespace Habit_Control
{
    partial class Form_Add_Habit
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
            this.Panel_AddHabit_Content = new System.Windows.Forms.Panel();
            this.Label_EndDate = new System.Windows.Forms.Label();
            this.dateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
            this.numericUD_Repetition_Number = new System.Windows.Forms.NumericUpDown();
            this.Label_Repetition_Number = new System.Windows.Forms.Label();
            this.textBox_Habit_Name = new System.Windows.Forms.TextBox();
            this.Label_Habit_Name = new System.Windows.Forms.Label();
            this.Button_Back = new System.Windows.Forms.Button();
            this.Button_Create = new System.Windows.Forms.Button();
            this.Panel_AddHabit_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_Repetition_Number)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Header
            // 
            this.Label_Header.AutoSize = true;
            this.Label_Header.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label_Header.Location = new System.Drawing.Point(185, 9);
            this.Label_Header.Name = "Label_Header";
            this.Label_Header.Size = new System.Drawing.Size(186, 24);
            this.Label_Header.TabIndex = 0;
            this.Label_Header.Text = "Alışkanlık Ekleme";
            // 
            // Panel_AddHabit_Content
            // 
            this.Panel_AddHabit_Content.Controls.Add(this.Label_EndDate);
            this.Panel_AddHabit_Content.Controls.Add(this.dateTimePicker_EndDate);
            this.Panel_AddHabit_Content.Controls.Add(this.numericUD_Repetition_Number);
            this.Panel_AddHabit_Content.Controls.Add(this.Label_Repetition_Number);
            this.Panel_AddHabit_Content.Controls.Add(this.textBox_Habit_Name);
            this.Panel_AddHabit_Content.Controls.Add(this.Label_Habit_Name);
            this.Panel_AddHabit_Content.Location = new System.Drawing.Point(12, 57);
            this.Panel_AddHabit_Content.Name = "Panel_AddHabit_Content";
            this.Panel_AddHabit_Content.Size = new System.Drawing.Size(523, 230);
            this.Panel_AddHabit_Content.TabIndex = 1;
            // 
            // Label_EndDate
            // 
            this.Label_EndDate.AutoSize = true;
            this.Label_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label_EndDate.ForeColor = System.Drawing.Color.Black;
            this.Label_EndDate.Location = new System.Drawing.Point(14, 163);
            this.Label_EndDate.Name = "Label_EndDate";
            this.Label_EndDate.Size = new System.Drawing.Size(196, 20);
            this.Label_EndDate.TabIndex = 5;
            this.Label_EndDate.Text = "Ne Zaman Biteceğini Seç :";
            // 
            // dateTimePicker_EndDate
            // 
            this.dateTimePicker_EndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_EndDate.Location = new System.Drawing.Point(264, 163);
            this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
            this.dateTimePicker_EndDate.Size = new System.Drawing.Size(233, 26);
            this.dateTimePicker_EndDate.TabIndex = 4;
            // 
            // numericUD_Repetition_Number
            // 
            this.numericUD_Repetition_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUD_Repetition_Number.Location = new System.Drawing.Point(264, 88);
            this.numericUD_Repetition_Number.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUD_Repetition_Number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUD_Repetition_Number.Name = "numericUD_Repetition_Number";
            this.numericUD_Repetition_Number.Size = new System.Drawing.Size(83, 26);
            this.numericUD_Repetition_Number.TabIndex = 3;
            this.numericUD_Repetition_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUD_Repetition_Number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label_Repetition_Number
            // 
            this.Label_Repetition_Number.AutoSize = true;
            this.Label_Repetition_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label_Repetition_Number.ForeColor = System.Drawing.Color.Black;
            this.Label_Repetition_Number.Location = new System.Drawing.Point(14, 88);
            this.Label_Repetition_Number.Name = "Label_Repetition_Number";
            this.Label_Repetition_Number.Size = new System.Drawing.Size(247, 20);
            this.Label_Repetition_Number.TabIndex = 2;
            this.Label_Repetition_Number.Text = "Kaç Günde Tekrarlayacağını Seç :";
            // 
            // textBox_Habit_Name
            // 
            this.textBox_Habit_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Habit_Name.Location = new System.Drawing.Point(264, 16);
            this.textBox_Habit_Name.Name = "textBox_Habit_Name";
            this.textBox_Habit_Name.Size = new System.Drawing.Size(233, 26);
            this.textBox_Habit_Name.TabIndex = 1;
            // 
            // Label_Habit_Name
            // 
            this.Label_Habit_Name.AutoSize = true;
            this.Label_Habit_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label_Habit_Name.ForeColor = System.Drawing.Color.Black;
            this.Label_Habit_Name.Location = new System.Drawing.Point(14, 16);
            this.Label_Habit_Name.Name = "Label_Habit_Name";
            this.Label_Habit_Name.Size = new System.Drawing.Size(166, 20);
            this.Label_Habit_Name.TabIndex = 0;
            this.Label_Habit_Name.Text = "Alışkanlığına İsim Ver :";
            // 
            // Button_Back
            // 
            this.Button_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(58)))), ((int)(((byte)(51)))));
            this.Button_Back.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.Button_Back.Location = new System.Drawing.Point(12, 293);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(197, 74);
            this.Button_Back.TabIndex = 2;
            this.Button_Back.Text = "Geri Dön";
            this.Button_Back.UseVisualStyleBackColor = false;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Button_Create
            // 
            this.Button_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(168)))), ((int)(((byte)(97)))));
            this.Button_Create.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_Create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.Button_Create.Location = new System.Drawing.Point(338, 293);
            this.Button_Create.Name = "Button_Create";
            this.Button_Create.Size = new System.Drawing.Size(197, 74);
            this.Button_Create.TabIndex = 3;
            this.Button_Create.Text = "Oluştur";
            this.Button_Create.UseVisualStyleBackColor = false;
            this.Button_Create.Click += new System.EventHandler(this.Button_Create_Click);
            // 
            // Form_Add_Habit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 374);
            this.Controls.Add(this.Button_Create);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.Panel_AddHabit_Content);
            this.Controls.Add(this.Label_Header);
            this.Name = "Form_Add_Habit";
            this.Text = "Alışkanlık Ekleme";
            this.Panel_AddHabit_Content.ResumeLayout(false);
            this.Panel_AddHabit_Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_Repetition_Number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Header;
        private System.Windows.Forms.Panel Panel_AddHabit_Content;
        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.Button Button_Create;
        private System.Windows.Forms.Label Label_EndDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EndDate;
        private System.Windows.Forms.NumericUpDown numericUD_Repetition_Number;
        private System.Windows.Forms.Label Label_Repetition_Number;
        private System.Windows.Forms.TextBox textBox_Habit_Name;
        private System.Windows.Forms.Label Label_Habit_Name;
    }
}
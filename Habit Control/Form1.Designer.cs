namespace Habit_Control
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Panel_Content = new System.Windows.Forms.Panel();
            this.Panel_Management = new System.Windows.Forms.Panel();
            this.Button_Add_Habit = new System.Windows.Forms.Button();
            this.Button_Delete_Habit = new System.Windows.Forms.Button();
            this.Panel_Header.SuspendLayout();
            this.Panel_Management.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alışkanlıklar Listesi";
            // 
            // Panel_Header
            // 
            this.Panel_Header.Controls.Add(this.label1);
            this.Panel_Header.Location = new System.Drawing.Point(12, 12);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(346, 43);
            this.Panel_Header.TabIndex = 2;
            // 
            // Panel_Content
            // 
            this.Panel_Content.AutoScroll = true;
            this.Panel_Content.Location = new System.Drawing.Point(12, 61);
            this.Panel_Content.Name = "Panel_Content";
            this.Panel_Content.Size = new System.Drawing.Size(346, 373);
            this.Panel_Content.TabIndex = 3;
            // 
            // Panel_Management
            // 
            this.Panel_Management.Controls.Add(this.Button_Add_Habit);
            this.Panel_Management.Controls.Add(this.Button_Delete_Habit);
            this.Panel_Management.Location = new System.Drawing.Point(12, 440);
            this.Panel_Management.Name = "Panel_Management";
            this.Panel_Management.Size = new System.Drawing.Size(346, 60);
            this.Panel_Management.TabIndex = 3;
            // 
            // Button_Add_Habit
            // 
            this.Button_Add_Habit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(168)))), ((int)(((byte)(97)))));
            this.Button_Add_Habit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_Add_Habit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.Button_Add_Habit.Location = new System.Drawing.Point(170, 0);
            this.Button_Add_Habit.Name = "Button_Add_Habit";
            this.Button_Add_Habit.Size = new System.Drawing.Size(173, 60);
            this.Button_Add_Habit.TabIndex = 0;
            this.Button_Add_Habit.Text = "Alışkanlık Ekle";
            this.Button_Add_Habit.UseVisualStyleBackColor = false;
            this.Button_Add_Habit.Click += new System.EventHandler(this.Button_Add_Habit_Click);
            // 
            // Button_Delete_Habit
            // 
            this.Button_Delete_Habit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(58)))), ((int)(((byte)(51)))));
            this.Button_Delete_Habit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_Delete_Habit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.Button_Delete_Habit.Location = new System.Drawing.Point(3, 0);
            this.Button_Delete_Habit.Name = "Button_Delete_Habit";
            this.Button_Delete_Habit.Size = new System.Drawing.Size(173, 60);
            this.Button_Delete_Habit.TabIndex = 2;
            this.Button_Delete_Habit.Text = "Alışkanlık Sil";
            this.Button_Delete_Habit.UseVisualStyleBackColor = false;
            this.Button_Delete_Habit.Click += new System.EventHandler(this.Button_Delete_Habit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 507);
            this.Controls.Add(this.Panel_Management);
            this.Controls.Add(this.Panel_Content);
            this.Controls.Add(this.Panel_Header);
            this.Name = "Form1";
            this.Text = "Alışkanlık Takip Uygulaması";
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.Panel_Management.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Panel Panel_Content;
        private System.Windows.Forms.Panel Panel_Management;
        private System.Windows.Forms.Button Button_Delete_Habit;
        private System.Windows.Forms.Button Button_Add_Habit;
    }
}


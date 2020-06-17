namespace Habit_Control
{
    partial class Form_Tick_Habit
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
            this.Panel_Content = new System.Windows.Forms.Panel();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Label_Header = new System.Windows.Forms.Label();
            this.Button_Back = new System.Windows.Forms.Button();
            this.Panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Content
            // 
            this.Panel_Content.AutoScroll = true;
            this.Panel_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Panel_Content.Location = new System.Drawing.Point(12, 68);
            this.Panel_Content.Name = "Panel_Content";
            this.Panel_Content.Size = new System.Drawing.Size(346, 484);
            this.Panel_Content.TabIndex = 4;
            // 
            // Panel_Header
            // 
            this.Panel_Header.Controls.Add(this.Label_Header);
            this.Panel_Header.Location = new System.Drawing.Point(12, 12);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(346, 43);
            this.Panel_Header.TabIndex = 5;
            // 
            // Label_Header
            // 
            this.Label_Header.AutoSize = true;
            this.Label_Header.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Header.Location = new System.Drawing.Point(3, 7);
            this.Label_Header.Name = "Label_Header";
            this.Label_Header.Size = new System.Drawing.Size(342, 28);
            this.Label_Header.TabIndex = 1;
            this.Label_Header.Text = "Tik Atılabilecek Alışkanlıklar";
            // 
            // Button_Back
            // 
            this.Button_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(58)))), ((int)(((byte)(51)))));
            this.Button_Back.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.Button_Back.Location = new System.Drawing.Point(12, 558);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(345, 42);
            this.Button_Back.TabIndex = 6;
            this.Button_Back.Text = "Geri";
            this.Button_Back.UseVisualStyleBackColor = false;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Form_Tick_Habit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 612);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.Panel_Header);
            this.Controls.Add(this.Panel_Content);
            this.Name = "Form_Tick_Habit";
            this.Text = "Form_Tick_Habit";
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Content;
        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label Label_Header;
        private System.Windows.Forms.Button Button_Back;
    }
}
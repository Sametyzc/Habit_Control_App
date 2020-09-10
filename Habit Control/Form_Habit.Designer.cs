namespace Habit_Control
{
    partial class Form_Habit
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
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Panel_Repetition_Number = new System.Windows.Forms.Panel();
            this.Label_Repetition_Number = new System.Windows.Forms.Label();
            this.Label_Repetition_Number_Header = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label_startDate = new System.Windows.Forms.Label();
            this.Label_startDate_Header = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Label_endDate = new System.Windows.Forms.Label();
            this.Label_endDate_Header = new System.Windows.Forms.Label();
            this.Button_Back = new System.Windows.Forms.Button();
            this.TLP_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.TPL_Cells = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Header.SuspendLayout();
            this.Panel_Repetition_Number.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.TLP_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Header
            // 
            this.Panel_Header.Controls.Add(this.Label_Name);
            this.Panel_Header.Location = new System.Drawing.Point(103, 12);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(921, 43);
            this.Panel_Header.TabIndex = 8;
            // 
            // Label_Name
            // 
            this.Label_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Name.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label_Name.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Label_Name.Location = new System.Drawing.Point(0, 0);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(921, 43);
            this.Label_Name.TabIndex = 0;
            this.Label_Name.Text = "label1";
            this.Label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_Repetition_Number
            // 
            this.Panel_Repetition_Number.Controls.Add(this.Label_Repetition_Number);
            this.Panel_Repetition_Number.Controls.Add(this.Label_Repetition_Number_Header);
            this.Panel_Repetition_Number.Location = new System.Drawing.Point(103, 61);
            this.Panel_Repetition_Number.Name = "Panel_Repetition_Number";
            this.Panel_Repetition_Number.Size = new System.Drawing.Size(278, 97);
            this.Panel_Repetition_Number.TabIndex = 9;
            // 
            // Label_Repetition_Number
            // 
            this.Label_Repetition_Number.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Label_Repetition_Number.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label_Repetition_Number.ForeColor = System.Drawing.Color.Red;
            this.Label_Repetition_Number.Location = new System.Drawing.Point(0, 51);
            this.Label_Repetition_Number.Name = "Label_Repetition_Number";
            this.Label_Repetition_Number.Size = new System.Drawing.Size(278, 46);
            this.Label_Repetition_Number.TabIndex = 11;
            this.Label_Repetition_Number.Text = "Tekrar Aralığı";
            this.Label_Repetition_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Repetition_Number_Header
            // 
            this.Label_Repetition_Number_Header.AutoSize = true;
            this.Label_Repetition_Number_Header.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label_Repetition_Number_Header.Location = new System.Drawing.Point(60, 14);
            this.Label_Repetition_Number_Header.Name = "Label_Repetition_Number_Header";
            this.Label_Repetition_Number_Header.Size = new System.Drawing.Size(164, 25);
            this.Label_Repetition_Number_Header.TabIndex = 10;
            this.Label_Repetition_Number_Header.Text = "Tekrar Aralığı";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Label_startDate);
            this.panel2.Controls.Add(this.Label_startDate_Header);
            this.panel2.Location = new System.Drawing.Point(425, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 97);
            this.panel2.TabIndex = 10;
            // 
            // Label_startDate
            // 
            this.Label_startDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Label_startDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label_startDate.ForeColor = System.Drawing.Color.Red;
            this.Label_startDate.Location = new System.Drawing.Point(0, 51);
            this.Label_startDate.Name = "Label_startDate";
            this.Label_startDate.Size = new System.Drawing.Size(280, 46);
            this.Label_startDate.TabIndex = 11;
            this.Label_startDate.Text = "Tekrar Aralığı";
            this.Label_startDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_startDate_Header
            // 
            this.Label_startDate_Header.AutoSize = true;
            this.Label_startDate_Header.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label_startDate_Header.Location = new System.Drawing.Point(43, 14);
            this.Label_startDate_Header.Name = "Label_startDate_Header";
            this.Label_startDate_Header.Size = new System.Drawing.Size(189, 25);
            this.Label_startDate_Header.TabIndex = 10;
            this.Label_startDate_Header.Text = "Başlangıc Tarihi";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Label_endDate);
            this.panel3.Controls.Add(this.Label_endDate_Header);
            this.panel3.Location = new System.Drawing.Point(744, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 97);
            this.panel3.TabIndex = 12;
            // 
            // Label_endDate
            // 
            this.Label_endDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Label_endDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label_endDate.ForeColor = System.Drawing.Color.Red;
            this.Label_endDate.Location = new System.Drawing.Point(0, 51);
            this.Label_endDate.Name = "Label_endDate";
            this.Label_endDate.Size = new System.Drawing.Size(280, 46);
            this.Label_endDate.TabIndex = 11;
            this.Label_endDate.Text = "Tekrar Aralığı";
            this.Label_endDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_endDate_Header
            // 
            this.Label_endDate_Header.AutoSize = true;
            this.Label_endDate_Header.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label_endDate_Header.Location = new System.Drawing.Point(75, 14);
            this.Label_endDate_Header.Name = "Label_endDate_Header";
            this.Label_endDate_Header.Size = new System.Drawing.Size(133, 25);
            this.Label_endDate_Header.TabIndex = 10;
            this.Label_endDate_Header.Text = "Bitiş Tarihi";
            // 
            // Button_Back
            // 
            this.Button_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(58)))), ((int)(((byte)(51)))));
            this.Button_Back.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button_Back.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.Button_Back.Location = new System.Drawing.Point(3, 3);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(157, 41);
            this.Button_Back.TabIndex = 6;
            this.Button_Back.Text = "Geri";
            this.Button_Back.UseVisualStyleBackColor = false;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // TLP_Buttons
            // 
            this.TLP_Buttons.ColumnCount = 3;
            this.TLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLP_Buttons.Controls.Add(this.Button_Back, 0, 0);
            this.TLP_Buttons.Location = new System.Drawing.Point(27, 374);
            this.TLP_Buttons.Name = "TLP_Buttons";
            this.TLP_Buttons.RowCount = 1;
            this.TLP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Buttons.Size = new System.Drawing.Size(1088, 47);
            this.TLP_Buttons.TabIndex = 13;
            // 
            // TPL_Cells
            // 
            this.TPL_Cells.AutoScroll = true;
            this.TPL_Cells.ColumnCount = 10;
            this.TPL_Cells.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TPL_Cells.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TPL_Cells.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TPL_Cells.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TPL_Cells.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TPL_Cells.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TPL_Cells.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TPL_Cells.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TPL_Cells.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TPL_Cells.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TPL_Cells.Location = new System.Drawing.Point(27, 175);
            this.TPL_Cells.Name = "TPL_Cells";
            this.TPL_Cells.RowCount = 3;
            this.TPL_Cells.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TPL_Cells.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.TPL_Cells.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.TPL_Cells.Size = new System.Drawing.Size(1088, 193);
            this.TPL_Cells.TabIndex = 14;
            // 
            // Form_Habit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 435);
            this.Controls.Add(this.TPL_Cells);
            this.Controls.Add(this.TLP_Buttons);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel_Repetition_Number);
            this.Controls.Add(this.Panel_Header);
            this.Name = "Form_Habit";
            this.Text = "Form_Habit";
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Repetition_Number.ResumeLayout(false);
            this.Panel_Repetition_Number.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.TLP_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Panel Panel_Repetition_Number;
        private System.Windows.Forms.Label Label_Repetition_Number;
        private System.Windows.Forms.Label Label_Repetition_Number_Header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Label_startDate;
        private System.Windows.Forms.Label Label_startDate_Header;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Label_endDate;
        private System.Windows.Forms.Label Label_endDate_Header;
        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.TableLayoutPanel TLP_Buttons;
        private System.Windows.Forms.TableLayoutPanel TPL_Cells;
    }
}
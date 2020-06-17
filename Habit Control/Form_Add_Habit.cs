using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Habit_Control
{
    public partial class Form_Add_Habit : Form
    {
        private string HabitsFolderPath = "./Habits";
        private Form parentForm;

        public Form_Add_Habit(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.FormClosed += new FormClosedEventHandler(When_Form_Closed);
        }

        private void When_Form_Closed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
            parentForm.Visible = true;
            ((Form1)parentForm).restartForm();
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            string Habit_Name = textBox_Habit_Name.Text;
            string Habit_Repetition_Number = numericUD_Repetition_Number.Value.ToString();
            string Habit_StartDate = DateTime.Now.ToString("dd MM yyyy");
            string Habit_EndDate = dateTimePicker_EndDate.Value.ToString("dd MM yyyy");

            int Habit_Count = (int)(((dateTimePicker_EndDate.Value - DateTime.Now).Days) / numericUD_Repetition_Number.Value) + 1;

            if (!Directory.Exists(HabitsFolderPath))
            {
                Directory.CreateDirectory(HabitsFolderPath);
            }

            string newFilePath = HabitsFolderPath + "/" + Habit_Name + ".txt";
            FileStream file = File.Create(newFilePath);

            string Text = Habit_Name + "\n" +
                          Habit_Repetition_Number + "\n" +
                          Habit_StartDate + "\n" +
                          Habit_EndDate + "\n";

            for (int i = 0; i < Habit_Count; i++)
            {
                Text += "0";
            }
            Text += "\n";

            byte[] info = new UTF8Encoding(true).GetBytes(Text);

            file.Write(info, 0, info.Length);
            file.Close();
            MessageBox.Show("Ekleme işlemi başarı ile gerçekleşti.", "Geri Bildirim", MessageBoxButtons.OK);
            this.Close();
        }
    }
}

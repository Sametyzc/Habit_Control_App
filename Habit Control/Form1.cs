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
    public partial class Form1 : Form
    {
        private List<string> fileList = new List<string>();
        private List<Label> labelList = new List<Label>();
        private List<Button> buttonList = new List<Button>();

        private int fileCount;
        private Point startPoint = new Point(20, 20);
        private string HabitsFolderPath = "./Habits";

        public Form1()
        {
            InitializeComponent();
            setFileDict();
            LoadContent();
        }

        private void setFileDict()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(HabitsFolderPath);
            fileCount = 0;
            foreach (var file in directoryInfo.GetFiles("*.txt"))
            {
                fileList.Add(file.Name.Split('.').First());
                fileCount++;
            }
        }

        private void LoadContent()
        {
            
            int count = 1;
            foreach(var file in fileList)
            {
                Label label = new Label();
                label.Location = new Point(startPoint.X, (startPoint.Y)*count);
                label.Text = file;
                label.Size = new Size(200, 30);
                Panel_Content.Controls.Add(label);
            }

        }

        private void Button_Add_Habit_Click(object sender, EventArgs e)
        {
            Form_Add_Habit form_Add_Habit = new Form_Add_Habit(this);
            form_Add_Habit.Show();
            this.Enabled = false;

        }

        private void Button_Delete_Habit_Click(object sender, EventArgs e)
        {
            Form_Delete_Habit form_Delete_Habit = new Form_Delete_Habit(this);
            if (form_Delete_Habit.getDoHaveHabit())
            {
                form_Delete_Habit.Show();
                this.Enabled = false;
            }
            else
            {
                MessageBox.Show("Hiç bir alışkanlığınız yok!", "Geri Bildirim", MessageBoxButtons.OK);
            }
        }
    }
}

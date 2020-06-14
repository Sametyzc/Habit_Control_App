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
        private Point shiftValue = new Point(200, 50);
        private Point startPoint = new Point(14, 14);

        private string HabitsFolderPath = "./Habits";

        public Form1()
        {
            InitializeComponent();
            setFileDict();
            LoadContent();
        }
        public void restartForm()
        {
            Controls.Clear();
            InitializeComponent();
            setFileDict();
            LoadContent();
        }
        private void setFileDict()
        {
            fileList.Clear();
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
            labelList.Clear();
            buttonList.Clear();

            int count = 0;
            foreach (var file in fileList)
            {
                //add label to content panel
                Label label = new Label();
                label.AutoSize = true;
                label.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
                label.Name = "Label_Content" + count.ToString();
                label.Size = new Size(61, 22);
                label.TabIndex = 0;
                label.Location = new Point(startPoint.X, (startPoint.Y + (shiftValue.Y * count)));
                label.Text = file;
                Panel_Content.Controls.Add(label);
                labelList.Add(label);

                //add button to content panel
                Button button = new Button();
                button.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
                button.Location = new Point(startPoint.X + shiftValue.X, (startPoint.Y + (shiftValue.Y * count)));
                button.Name = "Button_Content" + count.ToString(); ;
                button.Size = new Size(108, 26);
                button.TabIndex = 1;
                button.Text = "Görüntüle";
                button.Click += new EventHandler(Button_Content_Click);
                button.UseVisualStyleBackColor = true;
                Panel_Content.Controls.Add(button);
                buttonList.Add(button);

                count++;
            }

        }
        private void Button_Content_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int count = 0;
            foreach (var button in buttonList)
            {
                if (clickedButton.Equals(button))
                {
                    break;
                }
                count++;
            }
            MessageBox.Show(string.Format("Tiklanan {0}",fileList[count]), "Geri Bildirim", MessageBoxButtons.OK);
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

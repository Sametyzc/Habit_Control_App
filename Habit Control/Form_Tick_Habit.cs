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
    public partial class Form_Tick_Habit : Form
    {

        private Form parentForm;

        private string HabitsFolderPath = "./Habits";

        private int[] indexOfrepetitionNumber;
        private List<Habit> habitList = new List<Habit>();
        private List<Label> labelList = new List<Label>();
        private List<Button> buttonList = new List<Button>();

        private int fileCount;
        private Point shiftValue = new Point(200, 50);
        private Point startPoint = new Point(14, 14);

        public int habitListCount;

        public Form_Tick_Habit(Form parentForm)
        {
            InitializeComponent();

            this.parentForm = parentForm;
            this.FormClosed += new FormClosedEventHandler(When_Form_Closed);

            setFileDict();
            LoadContent();
        }

        public void restartForm()
        {

            Controls.Clear();
            InitializeComponent();
            setFileDict();
            if (habitListCount == 0)
            {
                this.Close();
            }
            LoadContent();
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void When_Form_Closed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
            parentForm.Visible = true;
        }

        private void setFileDict()
        {
            habitList.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo(HabitsFolderPath);
            fileCount = 0;
            indexOfrepetitionNumber = new int[directoryInfo.GetFiles("*.txt").Count()];
            foreach (var file in directoryInfo.GetFiles("*.txt"))
            {
                int lineCount = 0;
                int repetitionCount = 0;
                Habit habit = new Habit();
                foreach (var line in File.ReadAllLines(HabitsFolderPath + "/" + file.ToString()))
                {
                    string[] splitLine;
                    if (lineCount == 0)
                    {
                        habit.Name = line;
                    }
                    else if (lineCount == 1)
                    {
                        habit.repetitionNumber = int.Parse(line);
                    }
                    else if (lineCount == 2)
                    {
                        splitLine = line.Split(' ');
                        habit.startDate = new DateTime(int.Parse(splitLine[2]), int.Parse(splitLine[1]), int.Parse(splitLine[0]));
                    }
                    else if (lineCount == 3)
                    {
                        splitLine = line.Split(' ');
                        habit.endDate = new DateTime(int.Parse(splitLine[2]), int.Parse(splitLine[1]), int.Parse(splitLine[0]));
                    }
                    else if (lineCount == 4)
                    {
                        habit.continuity = line;
                    }
                    else
                    {
                        break;
                    }
                    lineCount++;
                }
                for (DateTime dateTime = habit.startDate; dateTime <= habit.endDate; dateTime = dateTime.AddDays(habit.repetitionNumber))
                {
                    if (dateTime.ToString("dd MM yyyy").Equals(DateTime.Now.ToString("dd MM yyyy")))
                    {
                        if (habit.continuity[repetitionCount] == '0')
                        {
                            habitList.Add(habit);
                            indexOfrepetitionNumber[fileCount] = repetitionCount;
                            fileCount++;
                            break;
                        }
                    }
                    repetitionCount++;
                }
                habitListCount = habitList.Count;
            }
        }

        private void LoadContent()
        {
            labelList.Clear();
            buttonList.Clear();
            int count = 0;

            foreach (var habit in habitList)
            {
                //add label to content panel
                Label label = new Label();
                label.AutoSize = true;
                label.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
                label.Name = "Label_Content" + count.ToString();
                label.Size = new Size(61, 22);
                label.TabIndex = 0;
                label.Location = new Point(startPoint.X, (startPoint.Y + (shiftValue.Y * count)));
                label.Text = habit.Name;
                Panel_Content.Controls.Add(label);
                labelList.Add(label);

                //add button to content panel
                Button button = new Button();
                button.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
                button.Location = new Point(startPoint.X + shiftValue.X, (startPoint.Y + (shiftValue.Y * count)));
                button.Name = "Button_Content" + count.ToString(); ;
                button.Size = new Size(108, 26);
                button.TabIndex = 1;
                button.Text = "Tik At";
                button.Click += new EventHandler(Button_Content_Click);
                button.BackColor = Color.FromArgb(0, 192, 192);
                button.ForeColor = Color.White;
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
            string[] allLines = File.ReadAllLines(HabitsFolderPath + "/" + habitList[count].Name + ".txt");
            int index = indexOfrepetitionNumber[count];
            string newLine = "";

            for (int i = 0; i < allLines[4].Count(); i++)
            {
                if (i == index)
                {
                    newLine += '1';
                }
                else
                {
                    newLine += allLines[4][i];
                }
            }
            allLines[4] = newLine;
            File.WriteAllLines(HabitsFolderPath + "/" + habitList[count].Name + ".txt", allLines);
            MessageBox.Show(string.Format("{0} tarihine tik atma işlemi başarılı.", DateTime.Now.ToString("dd.MM.yyyy")), "Geri Bildirim", MessageBoxButtons.OK);
            this.restartForm();
        }
    }
}

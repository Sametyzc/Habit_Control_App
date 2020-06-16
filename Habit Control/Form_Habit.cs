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
    struct Habit
    {
        public string Name;
        public int repetitionNumber;
        public DateTime startDate;
        public DateTime endDate;
        public string continuity;
    }
    public partial class Form_Habit : Form
    {

        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("tr-TR");

        private Form parentForm;

        private string HabitsFolderPath = "./Habits";
        private string fileName;
        Habit habit = new Habit();

        public Form_Habit(Form parentForm, string fileName)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.fileName = fileName;
            this.FormClosed += new FormClosedEventHandler(When_Form_Closed);

            Load_Habit();
            Load_Content();

        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void When_Form_Closed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        private void Load_Habit()
        {
            int lineCount = 0;
            foreach (string line in File.ReadAllLines(HabitsFolderPath + "/" + fileName + ".txt"))
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
                    break;
                lineCount++;
            }
        }

        private void Load_Content()
        {
            Label_Name.Text = habit.Name;
            Label_Repetition_Number.Text = habit.repetitionNumber.ToString();
            Label_startDate.Text = habit.startDate.ToString("dd.MM.yyyy");
            Label_endDate.Text = habit.endDate.ToString("dd.MM.yyyy");
            Load_Calendar();
        }

        private void Load_Calendar()
        {
            int dayCount = 0;
            DateTime currentDate = habit.startDate;
            for (int i = 0; i < TPL_Cells.RowCount; i += 2)
            {
                for (int j = 0; j < TPL_Cells.ColumnCount; j++)
                {
                    if (i == 12 || (currentDate > habit.endDate) || (habit.continuity.Count() == 0))
                    {
                        goto LoopEnd;
                    }

                    if ((i + 1) >= TPL_Cells.RowCount - 2)
                    {
                        TPL_Cells.RowCount++;
                        TPL_Cells.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
                    }

                    //Add date label to table panel layout
                    Label label_date = new Label();
                    label_date.BackColor = Color.Coral;
                    label_date.Dock = DockStyle.Fill;
                    label_date.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
                    label_date.ForeColor = Color.White;
                    label_date.Name = "Label_Date" + j.ToString() + i.ToString();
                    label_date.Size = new Size(102, 58);
                    label_date.TabIndex = 0;
                    label_date.Text = currentDate.ToString("dd.MM.yyyy");
                    label_date.TextAlign = ContentAlignment.MiddleCenter;

                    TPL_Cells.Controls.Add(label_date, j, i);

                    //Add status label to table panel layout
                    Label label_status = new Label();
                    label_status.Dock = DockStyle.Fill;
                    label_status.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
                    label_status.Name = "Label_Status" + j.ToString() + (i + 1).ToString();
                    label_status.Size = new Size(102, 40);
                    label_status.TabIndex = 1;
                    label_status.TextAlign = ContentAlignment.MiddleCenter;
                    label_status.BackColor = Color.Silver;

                    if (habit.continuity[0].Equals('0'))
                    {
                        label_status.ForeColor = Color.Red;
                        label_status.Text = "X";
                    }
                    else
                    {
                        label_status.ForeColor = Color.Green;
                        label_status.Text = "✓";
                    }

                    habit.continuity = habit.continuity.Remove(0, 1);
                    TPL_Cells.Controls.Add(label_status, j, i + 1);

                    currentDate = currentDate.AddDays(habit.repetitionNumber);
                }
            }
            LoopEnd:;

        }

    }
}

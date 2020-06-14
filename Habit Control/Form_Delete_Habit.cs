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

    public partial class Form_Delete_Habit : Form
    {
        Dictionary<int, string> comboSource = new Dictionary<int, string>();

        private string HabitsFolderPath = "./Habits";
        private Form parentForm;
        private bool doHaveHabit = true;

        public Form_Delete_Habit(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.FormClosed += new FormClosedEventHandler(When_Form_Closed);

            //Load Habits to comboBox_Habits

            DirectoryInfo directoryInfo = new DirectoryInfo(HabitsFolderPath);
            int fileCount = 0;
            foreach (var file in directoryInfo.GetFiles("*.txt"))
            {
                comboSource.Add(fileCount, file.Name.Split('.').First());
                fileCount++;
            }

            if (fileCount <= 0)
            {
                doHaveHabit = false;
            }
            else
            {
                comboBox_Habits.DataSource = new BindingSource(comboSource, null);
                comboBox_Habits.DisplayMember = "Value";
                comboBox_Habits.ValueMember = "Key";
                comboBox_Habits.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        public bool getDoHaveHabit()
        {
            return doHaveHabit;
        }

        private void When_Form_Closed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
            ((Form1)parentForm).restartForm();
        }

        private void Button_Accept_Click(object sender, EventArgs e)
        {
            string selectedItem = comboSource[comboBox_Habits.SelectedIndex];
            string fileName = selectedItem + ".txt";

            DialogResult dialogResult = MessageBox.Show(string.Format("Silmek istediğinden emin misin. \n {0}", selectedItem), "Geri Bildirim", MessageBoxButtons.YesNo);

            DirectoryInfo directoryInfo = new DirectoryInfo(HabitsFolderPath);
            if (dialogResult.Equals(DialogResult.Yes))
            {
                foreach (var file in directoryInfo.GetFiles("*.txt"))
                {
                    if (file.Name.Equals(fileName))
                    {
                        file.Delete();
                        break;
                    }
                }
                MessageBox.Show("Silme işlemi başarı ile gerçekleşti.", "Geri Bildirim", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

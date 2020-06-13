using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Habit_Control
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Add_Habit_Click(object sender, EventArgs e)
        {
            Form_Add_Habit form_Add_Habit = new Form_Add_Habit(this);
            form_Add_Habit.Show();
            this.Enabled = false;
        }

    }
}

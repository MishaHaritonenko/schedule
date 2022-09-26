using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schedule
{
    public partial class AddScheduleEntryForm : Form
    {
      
        public Entry GetScheduleEntry()
        {
            return new Entry {Day = txtDay.Text, Name = txtTeacher.Text, Subject = txtSubject.Text, Begin = udBegin.Value, End = udEnd.Value};
        }
        public AddScheduleEntryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddScheduleEntryForm_Load(object sender, EventArgs e)
        {
            txtDay.Text = "monday";
            txtSubject.Text = "subject1";
            txtTeacher.Text = "teacher1";
            udBegin.Value = 9;
            udEnd.Value = 10;
        }
    }
}

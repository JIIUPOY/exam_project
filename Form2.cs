using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Экз_ТП_WF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.provideParentFormInstanse(this);
            this.Hide();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            
            //if ()
            //{
            //
            //}
            foreach (Student st in Group.GetInstance().NameStudents)
            {
                //dataGridView1.Rows.Add(st.Name);
                int? sum_1 = 0;
                foreach (Subject sub in st.subjects.Subjects)
                {
                    sum_1 += sub.Mark;
                }
                double? average = sum_1 / 15.0;
                dataGridView1.Rows.Add("", st.Name, Math.Round((double)average, 2));
            }
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
            





        }
    }
}

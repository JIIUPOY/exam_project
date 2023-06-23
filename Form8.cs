using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Экз_ТП_WF
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> namesOfStud = new List<string>();

            foreach (Student St in Group.GetInstance().NameStudents)
            {
                namesOfStud.Add(St.Name);
            }
            comboBox126.DataSource = namesOfStud;

            Student new_st = Group.GetInstance().GetStudentByName(comboBox126.Text);
            comboBox111.Text = new_st.subjects.Subjects[0].Mark.ToString();
            comboBox112.Text = new_st.subjects.Subjects[1].Mark.ToString();
            comboBox113.Text = new_st.subjects.Subjects[2].Mark.ToString();
            comboBox114.Text = new_st.subjects.Subjects[3].Mark.ToString();
            comboBox115.Text = new_st.subjects.Subjects[4].Mark.ToString();
            comboBox116.Text = new_st.subjects.Subjects[5].Mark.ToString();
            comboBox117.Text = new_st.subjects.Subjects[6].Mark.ToString();
            comboBox118.Text = new_st.subjects.Subjects[7].Mark.ToString();
            comboBox119.Text = new_st.subjects.Subjects[8].Mark.ToString();
            comboBox120.Text = new_st.subjects.Subjects[9].Mark.ToString();
            comboBox121.Text = new_st.subjects.Subjects[10].Mark.ToString();
            comboBox122.Text = new_st.subjects.Subjects[11].Mark.ToString();
            comboBox123.Text = new_st.subjects.Subjects[12].Mark.ToString();
            comboBox124.Text = new_st.subjects.Subjects[13].Mark.ToString();
            comboBox125.Text = new_st.subjects.Subjects[14].Mark.ToString();


        }

        private void comboBox126_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student new_st = Group.GetInstance().GetStudentByName(comboBox126.Text);
            comboBox111.Text = new_st.subjects.Subjects[0].Mark.ToString();
            comboBox112.Text = new_st.subjects.Subjects[1].Mark.ToString();
            comboBox113.Text = new_st.subjects.Subjects[2].Mark.ToString();
            comboBox114.Text = new_st.subjects.Subjects[3].Mark.ToString();
            comboBox115.Text = new_st.subjects.Subjects[4].Mark.ToString();
            comboBox116.Text = new_st.subjects.Subjects[5].Mark.ToString();
            comboBox117.Text = new_st.subjects.Subjects[6].Mark.ToString();
            comboBox118.Text = new_st.subjects.Subjects[7].Mark.ToString();
            comboBox119.Text = new_st.subjects.Subjects[8].Mark.ToString();
            comboBox120.Text = new_st.subjects.Subjects[9].Mark.ToString();
            comboBox121.Text = new_st.subjects.Subjects[10].Mark.ToString();
            comboBox122.Text = new_st.subjects.Subjects[11].Mark.ToString();
            comboBox123.Text = new_st.subjects.Subjects[12].Mark.ToString();
            comboBox124.Text = new_st.subjects.Subjects[13].Mark.ToString();
            comboBox125.Text = new_st.subjects.Subjects[14].Mark.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student st = Group.GetInstance().GetStudentByName(comboBox126.Text);
            

            Subject subj = st.subjects.Subjects[0];
            subj.Mark = Convert.ToInt32(comboBox111.Text);
            st.subjects.Subjects[0] = subj;

            Subject subj1 = st.subjects.Subjects[1];
            subj1.Mark = Convert.ToInt32(comboBox112.Text);
            st.subjects.Subjects[1] = subj1;

            Subject subj2 = st.subjects.Subjects[2];
            subj2.Mark = Convert.ToInt32(comboBox113.Text);
            st.subjects.Subjects[2] = subj2;

            Subject subj3 = st.subjects.Subjects[3];
            subj3.Mark = Convert.ToInt32(comboBox114.Text);
            st.subjects.Subjects[3] = subj3;

            Subject subj4 = st.subjects.Subjects[4];
            subj4.Mark = Convert.ToInt32(comboBox115.Text);
            st.subjects.Subjects[4] = subj4;


            Subject subj5 = st.subjects.Subjects[5];
            subj5.Mark = Convert.ToInt32(comboBox116.Text);
            st.subjects.Subjects[5] = subj5;

            Subject subj6 = st.subjects.Subjects[6];
            subj6.Mark = Convert.ToInt32(comboBox117.Text);
            st.subjects.Subjects[6] = subj6;

            Subject subj7 = st.subjects.Subjects[7];
            subj7.Mark = Convert.ToInt32(comboBox118.Text);
            st.subjects.Subjects[7] = subj7;

            Subject subj8 = st.subjects.Subjects[8];
            subj8.Mark = Convert.ToInt32(comboBox119.Text);
            st.subjects.Subjects[8] = subj8;

            Subject subj9 = st.subjects.Subjects[9];
            subj9.Mark = Convert.ToInt32(comboBox120.Text);
            st.subjects.Subjects[9] = subj9;

            Subject subj10 = st.subjects.Subjects[10];
            subj10.Mark = Convert.ToInt32(comboBox121.Text);
            st.subjects.Subjects[10] = subj10;

            Subject subj11 = st.subjects.Subjects[11];
            subj11.Mark = Convert.ToInt32(comboBox122.Text);
            st.subjects.Subjects[11] = subj11;

            Subject subj12 = st.subjects.Subjects[12];
            subj12.Mark = Convert.ToInt32(comboBox123.Text);
            st.subjects.Subjects[12] = subj12;

            Subject subj13 = st.subjects.Subjects[13];
            subj13.Mark = Convert.ToInt32(comboBox124.Text);
            st.subjects.Subjects[13] = subj13;

            Subject subj14 = st.subjects.Subjects[14];
            subj14.Mark = Convert.ToInt32(comboBox125.Text);
            st.subjects.Subjects[14] = subj14;

            int? sum = 0;
            foreach (Subject sub in st.subjects.Subjects)
            {
                sum += sub.Mark;
            }
            double? average = sum / 15.0;
        }
    }
}

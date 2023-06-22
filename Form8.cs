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
    }
}

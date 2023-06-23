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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<string> list_hor = new List<string>();
            int count_all = 0;
            int count_hor = 0;
            
            int count_5 = 0;
            foreach (Student st in Group.GetInstance().NameStudents)
            {
                int flag = 0;
                count_all++;
                int count_4 = 0;


                foreach (Subject sub in st.subjects.Subjects)
                {
                    if (sub.Mark == 4)
                    {
                        count_4++;
                        //flag++;
                        //if (sub.Mark == 4)
                        //{
                        //    count_4 ++;
                        //}
                    }

                }
                if (count_4 != 0)
                {
                    list_hor.Add(st.Name);
                    count_hor++;
                }
            }

            foreach (String NameOfSt in list_hor)
            {
                dataGridView1.Rows.Add("", NameOfSt);
            }

            label1.Text = "Процент хорошистов: " + (((count_hor) * 100 / (count_all))).ToString() + "%";
            

        }
    }
}

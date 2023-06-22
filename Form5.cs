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
            List<string> list_hor = new List<string>();
            int flag = 0;
            int count_4 = 0;
            foreach (Student st in Group.GetInstance().NameStudents)
            {

                foreach (Subject sub in st.subjects.Subjects)
                {
                    if (sub.Mark == 5 || sub.Mark == 4)
                    {
                        if (sub.Mark == 4)
                        {
                            count_4++;
                        }

                    }

                }
                if ((count_4 != 0))
                {
                    list_hor.Add(st.Name);
                }
            }

            foreach (String NameOfSt in list_hor)
            {
                dataGridView1.Rows.Add("", NameOfSt);
            }

        }
    }
}

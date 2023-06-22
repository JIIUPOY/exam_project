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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list_hor = new List<string>();
            int flag = 0;
            foreach (Student st in Group.GetInstance().NameStudents)
            {
                
                foreach (Subject sub in st.subjects.Subjects)
                {
                    if (sub.Mark == 5) 
                    {
                        flag++;
                        
                    }
                    else if (sub.Mark == 4)
                    {
                        flag--;
                    }
                }
                if (flag == 15)
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

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
            dataGridView1.Rows.Clear();
            int count_otl  = 0;
            int count_all = 0;
            
            List<string> list_hor = new List<string>();
            
            foreach (Student st in Group.GetInstance().NameStudents)
            {
                count_all++;
                int flag = 0;

                foreach (Subject sub in st.subjects.Subjects)
                {
                    if (sub.Mark == 5) 
                    {
                        flag++;
                        
                    }
                    
                }
                if (flag == 15)
                {
                    list_hor.Add(st.Name);
                    count_otl++;
                }
            }
            foreach (String NameOfSt in list_hor)
            {
                    dataGridView1.Rows.Add("", NameOfSt);
            }
           
            

            label1.Text = "Процент отличников: " + ((count_otl) * 100 / (count_all)).ToString() + "%";
            //label2.Text = perc.ToString();
            //label3.Text = percent.ToString();
            label4.Text = count_otl.ToString();
            label5.Text = count_all.ToString();
            //label6.Text = (perc*100).ToString();
        }
    }
}

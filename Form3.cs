using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Экз_ТП_WF;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Экз_ТП_WF
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            putDropDown();
            this.SuspendLayout();
           // createSubjectLabels();
            this.ResumeLayout();
            List<Student> students = new List<Student>();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.Name = textBox1.Text;
            string[] names = {
                "Методы программирования",
                "Историческое многообразие современного общества",
                "Аналитическая геометрия",
                "Дифференциальное исчисление",
                "Языки программирования",
                "Физика",
                "Зарубежная и отечественная философия",
                "Кратные ряды и интегралы",
                "Интегральное исчисление",
                "Дифференциальные уравнения",
                "Теория функций комплексного переменного",
                "Теория вероятностей и математическая статистика",
                "Основы нефтегазового дела",
                "Концепции современного естествознания",
                "Специальная подготовка"
            };
            
            
            foreach (String value in names)
            {
                Subject subject = new Subject();
                subject.Name = value;
                st.subjects.Subjects.Add(subject);
            }
            


            Subject subj = st.subjects.Subjects[0];
            subj.Mark = Convert.ToInt32(comboBox1.Text);
            st.subjects.Subjects[0] = subj;

            Subject subj1 = st.subjects.Subjects[1];
            subj1.Mark = Convert.ToInt32(comboBox2.Text);
            st.subjects.Subjects[1] = subj1;

            Subject subj2 = st.subjects.Subjects[2];
            subj2.Mark = Convert.ToInt32(comboBox3.Text);
            st.subjects.Subjects[2] = subj2;

            Subject subj3 = st.subjects.Subjects[3];
            subj3.Mark = Convert.ToInt32(comboBox4.Text);
            st.subjects.Subjects[3] = subj3;

            Subject subj4 = st.subjects.Subjects[4];
            subj4.Mark = Convert.ToInt32(comboBox5.Text);
            st.subjects.Subjects[4] = subj4;


            Subject subj5 = st.subjects.Subjects[5];
            subj5.Mark = Convert.ToInt32(comboBox6.Text);
            st.subjects.Subjects[5] = subj5;

            Subject subj6 = st.subjects.Subjects[6];
            subj6.Mark = Convert.ToInt32(comboBox7.Text);
            st.subjects.Subjects[6] = subj6;

            Subject subj7 = st.subjects.Subjects[7];
            subj7.Mark = Convert.ToInt32(comboBox8.Text);
            st.subjects.Subjects[7] = subj7;

            Subject subj8 = st.subjects.Subjects[8];
            subj8.Mark = Convert.ToInt32(comboBox9.Text);
            st.subjects.Subjects[8] = subj8;

            Subject subj9 = st.subjects.Subjects[9];
            subj9.Mark = Convert.ToInt32(comboBox10.Text);
            st.subjects.Subjects[9] = subj9;

            Subject subj10 = st.subjects.Subjects[10];
            subj10.Mark = Convert.ToInt32(comboBox11.Text);
            st.subjects.Subjects[10] = subj10;

            Subject subj11 = st.subjects.Subjects[11];
            subj11.Mark = Convert.ToInt32(comboBox12.Text);
            st.subjects.Subjects[11] = subj11;

            Subject subj12 = st.subjects.Subjects[12];
            subj12.Mark = Convert.ToInt32(comboBox13.Text);
            st.subjects.Subjects[12] = subj12;

            Subject subj13 = st.subjects.Subjects[13];
            subj13.Mark = Convert.ToInt32(comboBox14.Text);
            st.subjects.Subjects[13] = subj13;

            Subject subj14 = st.subjects.Subjects[14];
            subj14.Mark = Convert.ToInt32(comboBox15.Text);
            st.subjects.Subjects[14] = subj14;

            int? sum = 0;
            foreach (Subject sub in st.subjects.Subjects)
            {
                sum += sub.Mark;
            }
            double? average = sum / 15.0;

            Group.GetInstance().NameStudents.Add(st);
            List<string> namesOfStud = new List<string>();

            foreach (Student St in Group.GetInstance().NameStudents)
            {
                namesOfStud.Add(St.Name);
            }
            
            
        }

        private void putDropDown()
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox7.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox8.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox9.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox10.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox11.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox12.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox13.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox14.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox15.DropDownStyle = ComboBoxStyle.DropDownList;
        }

       // private void createSubjectLabels()
       // {
           // SubjectsMemento memento = SubjectsMemento.create();

           // memento.DefaultSetUp();

       //     foreach (Subject subject in SubjectsMemento.create().Subjects)
        //    {


         //       int a = 10;
         //       int b = 15;
               
        //        int id = subject.Id;
        //        string labelName = "label" + id.ToString();

         //       Label customLabel = createLabel(labelName, out a, out b);

         //       MessageBox.Show(subject.Name);
        //        customLabel.Text = subject.Name;

        //        this.Controls.Add(customLabel);
                
         //   }

       //     return;
        //}

      //  private Label createLabel(string labelName, out int a, out int b)
      //  {
      //      Label label = new Label();
       //     label.AutoSize = true;
       //     label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //label.Location = new System.Drawing.Point(++a, ++b);
       //     label.Name = labelName;
       //     label.Size = new System.Drawing.Size(440, 76);
       //     label.TabIndex = 15;

        //    return label;
       // }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

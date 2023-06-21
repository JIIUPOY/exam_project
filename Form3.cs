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

namespace Экз_ТП_WF
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            putDropDown();
            this.SuspendLayout();
            createSubjectLabels();
            this.ResumeLayout();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void createSubjectLabels()
        {
           // SubjectsMemento memento = SubjectsMemento.create();

           // memento.DefaultSetUp();

            foreach (Subject subject in SubjectsMemento.create().Subjects)
            {


                int a = 10;
                int b = 15;
               
                int id = subject.Id;
                string labelName = "label" + id.ToString();

                Label customLabel = createLabel(labelName, out a, out b);

                MessageBox.Show(subject.Name);
                customLabel.Text = subject.Name;

                this.Controls.Add(customLabel);
                
            }

            return;
        }

        private Label createLabel(string labelName, out int a, out int b)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label.Location = new System.Drawing.Point(++a, ++b);
            label.Name = labelName;
            label.Size = new System.Drawing.Size(440, 76);
            label.TabIndex = 15;

            return label;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

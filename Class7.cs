using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Экз_ТП_WF;

namespace Экз_ТП_WF
{
    public class SubjectsMemento
    {
        private int currentSubjectId;
        private static int maxSubjectsCount = 20;
        public List<Subject> subjects;
        private static SubjectsMemento instance;

        public SubjectsMemento()
        {
            subjects = new List<Subject>();
        }

        public void DefaultSetUp()
        {
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

            foreach (string name in names)
            {
                addSubject(name);
            }
        }

        public List<Subject> Subjects 
        {
            get { return subjects; }
            set { subjects = value; }
        }

        public void addSubject(string name)
        {
           if (getSubjectByName(name) == null)
           {
                throw new ArgumentException("Невозможно добавить предмет с существующим названием");
           }

           subjects.Add(new Subject(name, ++currentSubjectId));
        }

        public Subject? getSubjectByName(string name)
        {
            return subjects.Find(x => x.Name == name);
        }

        public static SubjectsMemento create()
        {

            MessageBox.Show("дошел");
            if (instance == null)
            {
                instance = new SubjectsMemento();
            }

            return instance;
        }
    }
}

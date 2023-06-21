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
        private List<Subject> subjects;
        private static SubjectsMemento instance;

        private SubjectsMemento()
        {
            currentSubjectId = 0;
            subjects = new List<Subject>();
        }

        public void DefaultSetUp()
        {
            string[] names = {
                "Методы программирования",
                "Современное обществознание",
                "Историческое многообразие",
                "Аналитическая геометрия",
                "Дифференциальное исчисление",
                "Теория функций комплексного переменного",
                "Физика",
                "Интегральное исчисление",
                "Зарубежная и отечественная философия",
                "Кратные ряды и интегралы",
                "Дифференциальные уравнения",
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

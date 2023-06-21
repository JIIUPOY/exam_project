using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Экз_ТП_WF
{
 

   
    public class Student
    {
        public string Name { get; set; }
         public int? Id { get; set; }
        public SubjectsMemento subjects { get; set; }
    } 

    public struct Subject
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public int? Mark { get; set; }

        public Subject(string Name, int Id, int Mark = 0)
        {
            MessageBox.Show(Name);
            this.Name = Name;
            this.Id = Id;
            this.Mark = Mark;
        }

    }
    
}

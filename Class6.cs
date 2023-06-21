namespace Экз_ТП_WF
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Экз_ТП_WF
    {
        public class Student
        {
            public string Name { get; set; }
            public int? Id { get; set; }
            public List<Subject> subjects { get; set; }

        }

        public struct Subject
        {
            public string Name { get; set; }
            public int Id { get; set; }


        }

        public class Mark
        {
            public int Id { get; set; }
            public int StId { get; set; }
            public int SubId { get; set; }
            public int Value { get; set; }
        }
    }
}

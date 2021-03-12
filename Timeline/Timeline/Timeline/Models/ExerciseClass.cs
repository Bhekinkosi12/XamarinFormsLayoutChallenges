using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timeline.Models
{
    public class ExerciseClass
    {
        private string _classname;
        private string _instructor;
        public DateTime ClassTime { get; set;}
        public string ClassName { get{_classname; } set{_classname = value}  }
        public string Instructor { get; set; }
        

        public bool IsLast { get; set; } = false;
    }
}

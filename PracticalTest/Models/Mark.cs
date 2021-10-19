using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalTest.Models
{
    public class Mark
    {       
        public int StudentId { get; set; }      
        public int TeacherSubjectId { get; set; }
        public int Marks { get; set; }
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities
{
    public class School
    {
        public string SchoolName { get; set; }
        public List<StudentClass> Classes { get; set; } = new List<StudentClass>();

        public StudentClass HighestPerformingClass =>
            Classes.OrderByDescending(c => c.IncludedStudents.Average(s => s.FinalGradeInt)).FirstOrDefault();
    }
}
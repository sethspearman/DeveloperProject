using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities
{
    public class StudentClass
    {
        public int Grade { get; set; }
        public string Teacher { get; set; }
        public string ClassName { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public int StudentCount => Students.Count;
        public int StudentCountForAverage => IncludedStudents.Count;
        public List<Student> ExcludedStudents => Students.Where(s =>  s.FinalGradeInt == 0).ToList();
        public List<Student> IncludedStudents => Students.Where(s =>  s.FinalGradeInt > 0).ToList();
        public string IncludedStudentsString => string.Join(",", IncludedStudents.Select(s=>s.StudentName));
        public string ExcludedStudentsString => string.Join(",", ExcludedStudents.Select(s => s.StudentName));
        public double ClassAverage => IncludedStudents.Average(s => s.FinalGradeInt);
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace Domain.Entities
{
    public class School
    {
        public string SchoolName { get; set; }
        public List<StudentClass> Classes { get; set; } = new List<StudentClass>();

        public StudentClass HighestPerformingClass =>
            Classes.OrderByDescending(c => c.IncludedStudents.Average(s => s.FinalGradeInt)).FirstOrDefault();

        public override string ToString()
        {
            var result = new StringBuilder(500);
            result.Append("******************************************************" + nl(1));
            result.Append($"*HIGHEST PERFORMING CLASS:  {nl(1)}    {this.HighestPerformingClass.ClassName}    {nl(2)}*");
            result.Append($"******************************************************{nl(3)}");

            result.Append("~~~~CLASS AVERAGES~~~~" + nl(1));
            foreach (var studentClass in this.Classes)
            {
                result.Append($"{studentClass.ClassName} average is {studentClass.ClassAverage}" + nl(1));
            }

            result.Append($"{nl(3)}");
            result.Append("~~~~CLASS INFORMATION~~~~" + nl(1));

            foreach (var studentClass in this.Classes)
            {
                result.Append($"Class Name: {studentClass.ClassName}    Class Count: {studentClass.StudentCount}    Student Count Used To Calculate Average:  {studentClass.IncludedStudents.Count}      Names of Excluded Student: {studentClass.ExcludedStudentsString}" + nl(2));
            }

            return result.ToString();
        }

        public string nl(int quantity)
        {
            return new string('\n',quantity);
        }
    }   
}
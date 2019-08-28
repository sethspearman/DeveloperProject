using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using Domain.Entities;
using Interfaces;

namespace Data
{
    public class FileSchoolRepository:ISchoolRepository
    {
        private IEnumerable<string> _files;
        public FileSchoolRepository(string searchPath)
        {
            _files = Directory.EnumerateFiles(searchPath);
        }
        public School GetSchool()
        {
            var school = new School() { SchoolName = "Test Elementary School" };

            foreach (var file in _files)
            {
                var studentClass = GetClass(file);
                school.Classes.Add(studentClass);
            }

            return school;
        }

        private StudentClass GetClass(string filePath)
        {
            var result = new StudentClass();

            using (var reader = new StreamReader(filePath))
            {
                using (var csv = new CsvReader(reader))
                {
                    csv.Configuration.HasHeaderRecord = true;
                    csv.Configuration.RegisterClassMap<StudentMap>();
                    var records = csv.GetRecords<Student>();

                    foreach (var student in records)
                    {
                       result.Students.Add(student); 
                    }
                }
            }

            return result;
        }

        private sealed class StudentMap:ClassMap<Student>
        {
            public StudentMap()
            {
                Map(s => s.StudentName).Name("Student Name");
                Map(g => g.FinalGrade).Name("Grade");
            }
        }
    }
}

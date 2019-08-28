using Domain.Entities;
using Interfaces;

namespace SchoolTests
{
    public class FakeSchoolRepository:ISchoolRepository
    {
        public School GetSchool()
        {
            var school = new School() { SchoolName = "Test Elementary School" };

            var class1 = new StudentClass() { ClassName = "ClassA", Grade = 5, Teacher = "" };
            class1.Students.Add(new Student() { StudentName = "Fernando Powell", FinalGrade = 92 });
            class1.Students.Add(new Student() { StudentName = "William Norton", FinalGrade = 70 });
            class1.Students.Add(new Student() { StudentName = "Dalton Boone", FinalGrade = 88 });
            class1.Students.Add(new Student() { StudentName = "Edwardo French", FinalGrade = 52 });
            class1.Students.Add(new Student() { StudentName = "Antoinette Santiago", FinalGrade = 82 });
            class1.Students.Add(new Student() { StudentName = "Rena Hayden", FinalGrade = 99 });
            class1.Students.Add(new Student() { StudentName = "Tyson Best", FinalGrade = 75 });
            class1.Students.Add(new Student() { StudentName = "Eliza Tyler", FinalGrade = 62 });
            class1.Students.Add(new Student() { StudentName = "Edith Adkins", FinalGrade = 0 });
            class1.Students.Add(new Student() { StudentName = "Charlotte Villanueva", FinalGrade = 95 });

            var class2 = new StudentClass() { ClassName = "ClassB", Grade = 5, Teacher = "" };
            class2.Students.Add(new Student() { StudentName = "Tammy Cunningham", FinalGrade = 99.9 });
            class2.Students.Add(new Student() { StudentName = "Marcia Dunlap", FinalGrade = 43.2 });
            class2.Students.Add(new Student() { StudentName = "Emma Savage", FinalGrade = 65.4 });
            class2.Students.Add(new Student() { StudentName = "Janna Fleming", FinalGrade = 88.5 });
            class2.Students.Add(new Student() { StudentName = "Emilio Rangel", FinalGrade = 92.1 });
            class2.Students.Add(new Student() { StudentName = "Martha Mcclure", FinalGrade = 94.6 });
            class2.Students.Add(new Student() { StudentName = "Jason Vang", FinalGrade = 75.3 });
            class2.Students.Add(new Student() { StudentName = "Rosa Chavez", FinalGrade = 78.9 });
            class2.Students.Add(new Student() { StudentName = "Hayden Boyle", FinalGrade = 89.1 });
            class2.Students.Add(new Student() { StudentName = "Margarita Marks", FinalGrade = 79.5 });

            var class3 = new StudentClass() { ClassName = "ClassC", Grade = 5, Teacher = "" };
            class3.Students.Add(new Student() { StudentName = "Aileen Yoder", FinalGrade = 83 });
            class3.Students.Add(new Student() { StudentName = "Maryanne Anderson", FinalGrade = 66 });
            class3.Students.Add(new Student() { StudentName = "Benton Donaldson", FinalGrade = 52 });
            class3.Students.Add(new Student() { StudentName = "Myrtle Ingram", FinalGrade = 98 });
            class3.Students.Add(new Student() { StudentName = "Lina Beck", FinalGrade = 95 });
            class3.Students.Add(new Student() { StudentName = "Alisa Roy", FinalGrade = 93 });
            class3.Students.Add(new Student() { StudentName = "Faye Cervantes", FinalGrade = 84 });
            class3.Students.Add(new Student() { StudentName = "Brooks Villarreal", FinalGrade = 82 });
            class3.Students.Add(new Student() { StudentName = "Jarrett Henderson", FinalGrade = 75 });
            class3.Students.Add(new Student() { StudentName = "Darlene Mcconnell", FinalGrade = 73 });

            school.Classes.AddRange(new[] { class1, class2, class3 });

            return school;
        }
    }
}
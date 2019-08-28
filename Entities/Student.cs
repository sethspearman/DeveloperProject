namespace Domain.Entities
{
    public class Student
    {
        public string StudentName { get; set; }
        public double FinalGrade { get; set; }
        public int FinalGradeInt => (int) FinalGrade;
    }
}
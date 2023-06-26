namespace Zadanie_4
{
    class Program
    {
        private static void Main(string[] args)
        {
            var students = new List<Student>
            {
                CreateStudent("Kamil", "Łukaszewicz", 146101, 5, Gender.Mężczyzna),
                CreateStudent("Janusz", "Kowalski", 146202, 2, Gender.Mężczyzna),
                CreateStudent("Martyna", "Nowakowska", 146303, 3, Gender.Kobieta),
                CreateStudent("Andrzej", "Duda", 146404, 0, Gender.Mężczyzna),
                CreateStudent("Grzegorz", "Adamski", 146505, 7, Gender.Mężczyzna)
            };

            double averageGrade = GetAverageGrade(students);
            ShowStudentsData(students);
            Console.WriteLine($"Średnia ocen studentów: {averageGrade}");
        }
        
        private static Student CreateStudent(string name, string lastName, int index, double grade, Gender gender)
        {
            var student = new Student();

            student.Name = name;
            student.LastName = lastName;
            student.Index = index;
            if (grade < 2)
                student.Grade = 2;
            else if(grade > 5)
                student.Grade = 5;
            else
                student.Grade = grade;
            student.Gender = gender;
            
            return student;
        }

        private static double GetAverageGrade(List<Student> students)
        {
            var averageGrade = students.Average(student => student.Grade);

            return averageGrade;
        }

        private static void ShowStudentsData(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"[{student.Name} {student.LastName}] [Nr albumu: {student.Index}] [Ocena: {student.Grade}] [Płeć: {student.Gender}]");
            }
        }
        
        private struct Student
        {
            public string Name;
            public string LastName;
            public int Index;
            public double Grade;
            public Gender Gender;
        }

        private enum Gender
        {
            Kobieta,
            Mężczyzna
        }
    }
}
using System.Drawing;

namespace projects_student_gpa_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int course1Grade = 4;
            int course2Grade = 3;
            int course3Grade = 3;
            int course4Grade = 3;
            int course5Grade = 4;

            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;
            int creditHoursTotal = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

            // Multiplication of the grade value and credit hours
            int gradeValue1 = course1Grade * course1Credit;
            int gradeValue2 = course2Grade * course2Credit;
            int gradeValue3 = course3Grade * course3Credit;
            int gradeValue4 = course4Grade * course4Credit;
            int gradeValue5 = course5Grade * course5Credit;
            int gradeValueTotal = gradeValue1 + gradeValue2 + gradeValue3 + gradeValue4 + gradeValue5;

            // Students' overall grade point average
            double gradePointAverage = Math.Round((double)gradeValueTotal / (double)creditHoursTotal, 2);

            Console.WriteLine(@$"
Student: {studentName}

Course          Grade   Credit Hours	
{course1Name}         {course1Grade}       {course1Credit}
{course2Name}         {course2Grade}       {course2Credit}
{course3Name}         {course3Grade}       {course3Credit}
{course4Name}  {course4Grade}       {course4Credit}
{course5Name}      {course5Grade}       {course5Credit}

Final GPA:          {gradePointAverage}
");
        }
    }
}

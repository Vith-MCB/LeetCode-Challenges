using static System.Formats.Asn1.AsnWriter;
using System.Security;

double AverageCalc(int totalOfStudents, float sumOfGrades)
{
    return sumOfGrades / totalOfStudents;
}

float grade = 0, sumOfGrades = 0;
string gradeString = "";
int studentCount = 0;

while (grade != -1)
{
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("|       - Average Calculator -      |");
    Console.WriteLine("-------------------------------------");

    Console.WriteLine("Grade:");
    gradeString = Console.ReadLine();

    if (gradeString.Equals("-1")) { break; }

    //Parsing the value
    bool sucess = float.TryParse(gradeString, out grade);
    if (sucess)
    {
        sumOfGrades += grade;
        studentCount++;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("The Value is invalid!");
        continue;
        Console.WriteLine();
    }

}

double average = AverageCalc(studentCount, sumOfGrades);

Console.WriteLine("Average: {0}", average);
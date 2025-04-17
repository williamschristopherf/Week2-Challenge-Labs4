using Week2_Challenge_Labs4;

bool continueProgram = true;
char userChar;

//While loop allows the program to take in more than one student and prompt the user to end the program at the end
while (continueProgram)
{
    Student student1 = new Student();

    Console.WriteLine("Enter student information: ");
    Console.WriteLine("Roll Number: ");
    student1.RollNumber = Console.ReadLine();
    Console.WriteLine("Student name: ");
    student1.StudentName = Console.ReadLine();
    Console.WriteLine("Physics grade: ");
    student1.PhysicsGrade = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Chemistry grade: ");
    student1.ChemistryGrade = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Computer grade: ");
    student1.ComputerGrade = Convert.ToDouble(Console.ReadLine());

    student1.Total = student1.CalculateTotal(student1.PhysicsGrade, student1.ChemistryGrade, student1.ComputerGrade);
    student1.Percent = student1.CalculatePercent(student1.Total);
    student1.CalculateDivision();

    //Using verbatum interpolated strings to format a large block of strings without writing code repeatedly.
    Console.WriteLine($"""

    Roll Number:                   {student1.RollNumber}
    Name of student:               {student1.StudentName}
    Marks in Physics:              {student1.PhysicsGrade}
    Marks in Chemistry:            {student1.ChemistryGrade}
    Marks in Computer Application: {student1.ComputerGrade}
    Total marks:                   {student1.Total}/300
    Percentage:                    {student1.Percent.ToString("P")}
    Division:                      {student1.Division}

    """);

    Console.WriteLine("Do you have another student to enter?");
    Console.WriteLine("\"y\" for yes: \"n\" for no");
    userChar = Convert.ToChar(Console.ReadLine().ToLower());

    if (userChar == 'n')
    {
        Console.WriteLine("Good Bye");
        continueProgram = false;
    }
}

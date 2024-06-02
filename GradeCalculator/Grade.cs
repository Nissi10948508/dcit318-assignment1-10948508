// High level statements were used hence the absence of generated code like the class statement.
Console.Write("Enter a numerical grade (0-100): ");
int grade = int.Parse(Console.ReadLine());

if (grade >= 90)
{
    Console.WriteLine("Your grade is A");
}
else if (grade >= 80)
{
    Console.WriteLine("Your grade is B");
}
else if (grade >= 70)
{
    Console.WriteLine("Your grade is C");
}
else if (grade >= 60)
{
    Console.WriteLine("Your grade is D");
}
else
{
    Console.WriteLine("Your grade is F");
}


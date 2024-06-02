// High level statements were used hence the absence of generated code like the class statement.
Console.WriteLine("Enter the lengths of the three sides of the triangle:");

Console.Write("Side One: ");
double side1 = double.Parse(Console.ReadLine());

Console.Write("Side Two: ");
double side2 = double.Parse(Console.ReadLine());

Console.Write("Side Three: ");
double side3 = double.Parse(Console.ReadLine());

if (side1 == side2 && side2 == side3)
{
    Console.WriteLine("The triangle is Equilateral.");
}
else if (side1 == side2 || side2 == side3 || side1 == side3)
{
    Console.WriteLine("The triangle is Isosceles.");
}
else
{
    Console.WriteLine("The triangle is Scalene.");
}
// High level statements were used hence the absence of generated code like the class statement
const int regularPrice = 10;
const int discountPrice = 7;

Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

int ticketPrice = (age <= 12 || age >= 65) ? discountPrice : regularPrice;

Console.WriteLine($"Ticket price: GHC{ticketPrice}");
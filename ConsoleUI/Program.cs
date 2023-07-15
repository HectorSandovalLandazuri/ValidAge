// See https://aka.ms/new-console-template for more information
Console.Write("¿Cuál es tu edad? ");
string ageText=Console.ReadLine();

bool isValidAge = int.TryParse(ageText, out int age);
int year= DateTime.Today.Year;


if (isValidAge) { 
    Console.WriteLine($"Vas a tener {age+10} años en 10 años.");
    if (age < (year-2000)) {
        Console.WriteLine("No habías nacido en el año 2000.");
    } else
    {
        Console.WriteLine($"Tenías {age-(year-2000)} años en el año 2000.");
    }
} else
{
    Console.WriteLine("No es una edad válida.");
}

